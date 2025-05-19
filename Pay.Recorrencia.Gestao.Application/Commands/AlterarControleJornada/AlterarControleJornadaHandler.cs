using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Pay.Recorrencia.Gestao.Application.Commands.AlterarControleJornada;
using Pay.Recorrencia.Gestao.Domain.Repositories;
using Pay.Recorrencia.Gestao.Domain.Entities;

namespace Pay.Recorrencia.Gestao.Application.Commands.AlterarControleJornada
{
    public class AlterarControleJornadaHandler : IRequestHandler<AlterarControleJornadaCommand, CommandResult>
    {
        private readonly IAlterarControleJornadaRepository _jornadaRepository;

        public AlterarControleJornadaHandler(IAlterarControleJornadaRepository jornadaRepository)
        {
            _jornadaRepository = jornadaRepository;
        }

        public async Task<CommandResult> Handle(AlterarControleJornadaCommand request, CancellationToken cancellationToken)
        {
            var entidadeAlterar = await _jornadaRepository.ObterPorChavesAsync(request.TpJornada, request.IdRecorrencia, request.IdE2E);

            if (entidadeAlterar == null)
            {
                return new CommandResult
                {
                    CodigoRetorno = "NOK",
                    MensagemErro = "ERRO-PIXAUTO-020 - Jornada não encontrada"
                };
            }

            entidadeAlterar.AtualizarComDados(request);

            await _jornadaRepository.AtualizarAsync(entidadeAlterar);

            return new CommandResult
            {
                CodigoRetorno = "OK",
                MensagemErro = string.Empty
            };
        }
    }
}


using MediatR;
using System;

namespace Pay.Recorrencia.Gestao.Application.Commands.AlterarControleJornada
{
    public class AlterarControleJornadaCommand : IRequest<CommandResult>
    {
        public string TpJornada { get; set; }
        public string IdRecorrencia { get; set; }
        public string IdE2E { get; set; }
        public string IdConciliacaoRecebedor { get; set; }
        public string SituacaoJornada { get; set; }
        public DateTime? DtAgendamento { get; set; }
        public decimal? VlAgendamento { get; set; }
        public DateTime? DtPagamento { get; set; }
        public DateTime? DataHoraCriacao { get; set; }
        public DateTime? DataUltimaAtualizacao { get; set; }

        public string NomeFuncional { get; set; }
        public string NomeTecnico { get; set; }
        public string Observacoes { get; set; }
    }

    public class CommandResult
    {
        public string CodigoRetorno { get; set; } // OK ou NOK
        public string MensagemErro { get; set; }
    }
}


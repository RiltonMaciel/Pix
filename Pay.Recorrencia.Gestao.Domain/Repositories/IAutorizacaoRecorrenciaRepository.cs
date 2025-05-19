using Pay.Recorrencia.Gestao.Domain.Entities;

namespace Pay.Recorrencia.Gestao.Domain.Repositories
{
    public interface IAutorizacaoRecorrenciaRepository
    {
        #region IncluirAutorizacaoRecorrencia

        Task<AutorizacaoRecorrencia> ConsultaAutorizacao(Guid id);

        Task<AtualizacaoAutorizacaoRecorrencia> ConsultarAtualizacaoAutorizacaoRecorrencia(Guid id);

        Task<AutorizacaoRecorrencia> InsertAutorizacaoRecorrencia(AutorizacaoRecorrencia autorizacaoRecorrencia);

        Task<AtualizacaoAutorizacaoRecorrencia> InsertAtualizacoesAutorizacaoRecorrencia(AutorizacaoRecorrencia atualizacaoAutorizacaoRecorrencia);

        Task<AtualizacaoAutorizacaoRecorrencia> InsertAtualizacoesAutorizacaoRecorrencia(AtualizacaoAutorizacaoRecorrencia atualizacaoAutorizacao);

        #endregion


        #region AlterarAutorizacaoRecorrencia
        Task<IEnumerable<AtualizacaoAutorizacaoRecorrencia>> ObterAtualizacoesAsync();
        Task<AtualizacaoAutorizacaoRecorrencia> ObterAtualizacoesPorIdAsync(Guid id);

        void Update(AutorizacaoRecorrencia autorizacao);
        #endregion
    }
}

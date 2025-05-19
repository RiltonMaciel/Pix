using System.Threading.Tasks;
using Pay.Recorrencia.Gestao.Domain.Entities;

namespace Pay.Recorrencia.Gestao.Domain.Repositories
{
    public interface IAlterarControleJornadaRepository
    {
        Task<AlterarControleJornada> ObterPorChavesAsync(string tpJornada, string idRecorrencia, string idE2E);
        Task AtualizarAsync(AlterarControleJornada jornada);
    }
}

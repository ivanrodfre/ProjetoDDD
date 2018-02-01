using Domain.Entidades;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface IClienteRepository : IBaseRepository<Cliente>, IDapperRepository<Cliente>
    {
        Task<Cliente> GetIdAsync(int id);
    }
}

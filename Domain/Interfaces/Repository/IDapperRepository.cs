using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repository
{
    public interface IDapperRepository<TEntityDapper> where TEntityDapper : class
    {
        Task<IEnumerable<TEntityDapper>> GetAllAsync();

    }
}

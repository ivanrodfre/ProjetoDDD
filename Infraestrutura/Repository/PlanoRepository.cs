using Dapper;
using Domain.Entidades;
using Domain.Interfaces.Repository;
using Infraestrutura.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infraestrutura.Repository
{
    public class PlanoRepository : BaseRepository<Plano>, IPlanoRepository
    {
        private readonly DapperContext _dapperContext;

        public PlanoRepository(ApplicationDbContext context, DapperContext dapperContext) : base(context)
        {
            _dapperContext = dapperContext;
        }

        public async Task<IEnumerable<Plano>> GetAllAsync()
        {
            var query = @"SELECT * FROM Planos";

            return await _dapperContext.Connection.QueryAsync<Plano>(query);
        }
    }
}

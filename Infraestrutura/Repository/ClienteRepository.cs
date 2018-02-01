using Domain.Entidades;
using Domain.Interfaces.Repository;
using Dapper;
using Infraestrutura.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infraestrutura.Repository
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        private readonly DapperContext _dapperContext;

        public ClienteRepository(ApplicationDbContext context, DapperContext dapperContext) : base(context)
        {
            _dapperContext = dapperContext;
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            var query = "SELECT * FROM Clientes";

            return await _dapperContext.Connection.QueryAsync<Cliente>(query);
        }

        public async Task<Cliente> GetIdAsync(int id)
        {
            var query = "SELECT * FROM Clientes where clienteId = @id";

            return await _dapperContext.Connection.QueryFirstAsync<Cliente>(query, new { id = id });
        }

    }
}

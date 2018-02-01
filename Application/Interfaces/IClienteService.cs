using Application.ViewModels;
using Domain.Entidades;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<ClienteViewModel>> GetAllAsync();
        Task<ClienteViewModel> GetIdAsync(int id);
        void Add(ClienteViewModel cliente);
    }
}

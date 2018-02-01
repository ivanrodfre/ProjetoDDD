using Domain.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPlanosService
    {
        Task<IEnumerable<Plano>> GetPlanosAsync();
    }
}

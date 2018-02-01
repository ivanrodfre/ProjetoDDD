using Application.Interfaces;
using Domain.Entidades;
using Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Servicos
{
    public class PlanosService : IPlanosService
    {

        private readonly IPlanoRepository _planoRepository;

        public PlanosService(IPlanoRepository planoRepository)
        {
            _planoRepository = planoRepository;
        }

        public async Task<IEnumerable<Plano>> GetPlanosAsync()
        {
            return await _planoRepository.GetAllAsync();
        }

        
    }
}

using Application.Interfaces;
using Application.ViewModels;
using AutoMapper;
using Domain.Entidades;
using Domain.Interfaces.Infra;
using Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Application.Servicos
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public ClienteService(IClienteRepository clienteRepository, IMapper mapper, IUnitOfWork uow)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
            _uow = uow;
        }

        public void Add(ClienteViewModel cliente)
        {
            try
            {
                var model = _mapper.Map<Cliente>(cliente);

                _clienteRepository.Add(model);
                _uow.Commit();
            }
            catch (System.Exception ex)
            {

                throw;
            }

        }

        public async Task<IEnumerable<ClienteViewModel>> GetAllAsync()
        {
            var query = _mapper.Map<IEnumerable<ClienteViewModel>>(await _clienteRepository.GetAllAsync());
            return query;
        }

        public async Task<ClienteViewModel> GetIdAsync(int id)
        {
            var query = _mapper.Map<ClienteViewModel>(await _clienteRepository.GetIdAsync(id));
            return query;
        }

    }
}

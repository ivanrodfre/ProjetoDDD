using Application.ViewModels;
using AutoMapper;
using Domain.Entidades;

namespace Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            //Model, ViewModel
            CreateMap<Cliente, ClienteViewModel>();
        }
    }
}

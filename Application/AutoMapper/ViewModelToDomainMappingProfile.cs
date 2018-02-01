using Application.ViewModels;
using AutoMapper;
using Domain.Entidades;

namespace Application.AutoMapper
{
    class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            //ViewModel, Model
            CreateMap<ClienteViewModel, Cliente>();
        }
    }
}

using Application.Interfaces;
using Domain.Interfaces.Repository;
using Application.Servicos;
using Infraestrutura.Data;
using Microsoft.Extensions.DependencyInjection;
using Infraestrutura.Repository;
using AutoMapper;
using Domain.Interfaces.Infra;
using Infraestrutura.UoW;

namespace IoC.Configuration
{
    public class InjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Contextos
            services.AddDbContext<ApplicationDbContext>();
            services.AddScoped<DapperContext>();

            //Mapper
            services.AddSingleton(Mapper.Configuration);
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));


            //Injeção da Infra
            services.AddScoped<IPlanoRepository, PlanoRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();


            //Injeção do Core
            services.AddScoped<IPlanosService, PlanosService>();
            services.AddScoped<IClienteService, ClienteService>();

        }
    }
}

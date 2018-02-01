using Application.Interfaces;
using Domain.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Servicos
{
    public class PlanosMockService : IPlanosService
    {
        public Task<IEnumerable<Plano>> GetPlanosAsync() {

            IEnumerable<Plano> planos = new[]
            {
                new Plano
                {
                    Nome = "Plano Master",
                    Valor = 10000,
                    Ativo = true
                },
                new Plano
                {
                    Nome = "Plano Meio",
                    Valor = 5000,
                    Ativo = true
                },
                new Plano
                {
                    Nome = "Plano Master",
                    Valor = 3000,
                    Ativo = true
                },

            };

            return Task.FromResult(planos);
        }
    }
}

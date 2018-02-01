using Domain.Entidades;

namespace Domain.Interfaces.Repository
{
    public interface IPlanoRepository : IBaseRepository<Plano>, IDapperRepository<Plano>
    {
    }
}

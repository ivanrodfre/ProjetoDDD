namespace Domain.Interfaces.Infra
{
    public interface IUnitOfWork
    {
        void Commit();
        void BeginCommit();
        void BeginTransaction();
        void BeginRollback();
    }
}

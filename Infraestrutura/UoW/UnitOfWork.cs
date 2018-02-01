using Domain.Interfaces.Infra;
using Infraestrutura.Data;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace Infraestrutura.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IDbContextTransaction _transaction;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void BeginCommit()
        {
            _transaction.Commit(); 
        }

        public void BeginRollback()
        {
            _transaction.Rollback();
        }

        public void BeginTransaction()
        {
            _transaction = _context.Database.BeginTransaction();
        }

        public void Dispose()
        {
            _context.Dispose();

            if (_transaction != null)
            {
                _transaction.Dispose();
                _transaction = null;
            }

            GC.SuppressFinalize(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace LibPrj1.UOW
{
    public abstract class UnitOfWork<T> : IDisposable where T : DbContext
    {
        protected readonly DbContext dbContext;
        protected UnitOfWork(string connectionString, string migrationAssembly)
        {
            dbContext = (DbContext)Activator.CreateInstance(typeof(T), connectionString, migrationAssembly);
        }
        public void Save()
        {
            dbContext.SaveChanges();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }


    }
}

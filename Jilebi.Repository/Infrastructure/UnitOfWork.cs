using Jilebi.Repository;
using Jilebi.Repository.Infrastructure.Contract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MVCTutorial.Repository.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly JilebiDBEntities _dbContext;

        public UnitOfWork()
        {
            _dbContext = new JilebiDBEntities();
        }

        public DbContext Db
        {
            get { return _dbContext; }
        }

        public void Dispose()
        {
        }
    }

}
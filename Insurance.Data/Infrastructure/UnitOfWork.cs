using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Insurance.Data.Infrastructure
{

    public class UnitOfWork : IUnitOfWork
    {
        private IDataBaseFactory myFactory;
        public UnitOfWork(IDataBaseFactory factory)
        {
            myFactory = factory;
        }
        public void Commit()
        {
            myFactory.DataContext.SaveChanges();
        }

        public void CommitAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            myFactory.DataContext.Dispose();
        }

        public IRepositoryBase<T> getRepository<T>() where T : class
        {
            return new RepositoryBase<T>(myFactory);
        }
    }

}
using Insurance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Data.Infrastructure
{
    public class DataBaseFactory : IDataBaseFactory
    {
        private EntityContext dataContext;

        public EntityContext DataContext
        {
            get { return dataContext; }
            
        }
        public DataBaseFactory()
        {
            dataContext = new EntityContext();
        }
    }
}

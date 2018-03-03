using Insurance.Data.Infrastructure;
using Insurance.Domaine.Entity;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Service
{
  public  class EvenementService : Service<evenement>
    {
        private static IDataBaseFactory dbf = new DataBaseFactory();
        private static IUnitOfWork uow = new UnitOfWork(dbf);

        public EvenementService() : base(uow)
        {

        }

    }
}

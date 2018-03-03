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
    public class TopicService : Service<topic>
    {
        private static IDataBaseFactory dbf = new DataBaseFactory();
        private static IUnitOfWork uow = new UnitOfWork(dbf);

        public TopicService() : base(uow)
        {

        }

    }
}
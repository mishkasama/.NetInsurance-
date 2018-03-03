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
    public class SousCategoryService : Service<souscategory>
    {
        private static IDataBaseFactory dbf = new DataBaseFactory();
        private static IUnitOfWork uow = new UnitOfWork(dbf);

        public SousCategoryService() : base(uow)
        {

        }

        public List<souscategory> getByName(string name)
        {
            return uow.getRepository<souscategory>()
                .getAll()
                .Where(p => p.Name==name).ToList();
             
        }

    }
}
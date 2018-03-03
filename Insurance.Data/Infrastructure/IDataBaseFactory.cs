using Insurance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Data.Infrastructure
{

    public interface IDataBaseFactory
    {
        EntityContext DataContext { get; }
    }

}
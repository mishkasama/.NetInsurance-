using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class SousCategoryModel
    {
        public int idSousCategory { get; set; }
        public UserModel user { get; set; }
        public CategoryModel idCategory { get; set; }
        public String name { get; set; }
    }
}
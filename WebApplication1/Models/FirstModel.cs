using Insurance.Domaine.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class FirstModel
    {

        public List<topic> topic { get; set; }

        public List<category> category { get; set; }

        public List<souscategory> souscategory { get; set; }
    }
}
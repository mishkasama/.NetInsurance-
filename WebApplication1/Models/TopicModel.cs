using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class TopicModel
    {

        public int idTopic { get; set; }
        public string sujet { get; set; }
        public string contenu { get; set; }
        public int MyProperty { get; set; }
        public string dateCreation { get; set; }
        public string lastpost { get; set; }
        public UserModel idCreateur { get; set; }
        public SousCategoryModel idSousCategory { get; set; }
    }
}
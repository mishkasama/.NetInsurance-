namespace WebApplication1.Models
{
    using Insurance.Domaine.Entity;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    [Table("sinister")]
    public partial class sinisterModels
    {
        public int id { get; set; }

        [StringLength(255)]
        public string dateCreation { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string latitude { get; set; }

        [StringLength(255)]
        public string longitude { get; set; }

        [StringLength(255)]
        public string nameFirstname { get; set; }

        [StringLength(255)]
        public string nameInsurancCompany { get; set; }

        [StringLength(255)]
        public string policyNum { get; set; }

        [StringLength(255)]
        public string state { get; set; }

        [StringLength(255)]
        public string tel { get; set; }

        [StringLength(255)]
        public string urlImage { get; set; }

        public int? insured_id { get; set; }

        public virtual users users { get; set; }
    }
}

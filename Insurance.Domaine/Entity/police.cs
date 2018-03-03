namespace Insurance.Domaine.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("insurance.police")]
    public partial class police
    {
        [Key]
        public int numPolice { get; set; }

        public DateTime? endDate { get; set; }

        public int points { get; set; }

        public float price { get; set; }

        public DateTime? startDate { get; set; }

        public int? insured_id { get; set; }

        public int? typeContrat_IdTypeContrat { get; set; }

        [StringLength(255)]
        public string vehicle_Matriculation { get; set; }

        public virtual vehicle vehicle { get; set; }

        public virtual typecontract typecontract { get; set; }

        public virtual users users { get; set; }
    }
}

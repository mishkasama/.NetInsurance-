namespace Insurance.Domaine.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("insurance.insured")]
    public partial class insured
    {
        [Key]
        public int IdInsured { get; set; }

        [StringLength(255)]
        public string firstName { get; set; }

        [StringLength(255)]
        public string lastName { get; set; }
    }
}

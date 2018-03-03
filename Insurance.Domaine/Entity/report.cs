namespace Insurance.Domaine.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("insurance.report")]
    public partial class report
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        [Required]
        [StringLength(255)]
        public string description { get; set; }

        public int fileName { get; set; }
    }
}

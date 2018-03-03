namespace Insurance.Domaine.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("insurance.contact")]
    public partial class contact
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string email { get; set; }

        [Required]
        [StringLength(255)]
        public string adresse { get; set; }

        [Required]
        [StringLength(255)]
        public string website { get; set; }

        [Required]
        [StringLength(255)]
        public string telephone { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }
    }
}

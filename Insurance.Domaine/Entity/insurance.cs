namespace Insurance.Domaine.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("insurance.insurance")]
    public partial class insurance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public insurance()
        {
            insuranceproduct1 = new HashSet<insuranceproduct>();
            reclamation = new HashSet<reclamation>();
        }

        [Key]
        public int id_Ins { get; set; }

        public DateTime? dateCreation { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string mail { get; set; }

        [StringLength(255)]
        public string nameInsurance { get; set; }

        [StringLength(255)]
        public string phone { get; set; }

        public int rate { get; set; }

        public int? addresse_id { get; set; }

        public int? id_Pro { get; set; }

        public virtual address address { get; set; }

        public virtual insuranceproduct insuranceproduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<insuranceproduct> insuranceproduct1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reclamation> reclamation { get; set; }
    }
}

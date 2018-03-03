namespace Insurance.Domaine.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("insurance.typecontract")]
    public partial class typecontract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public typecontract()
        {
            police = new HashSet<police>();
        }

        [Key]
        public int IdTypeContrat { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public float pricePerSemester { get; set; }

        public float pricePerYear { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<police> police { get; set; }
    }
}

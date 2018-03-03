namespace Insurance.Domaine.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("insurance.insuranceproduct")]
    public partial class insuranceproduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public insuranceproduct()
        {
            insurance = new HashSet<insurance>();
        }

        [Key]
        public int id_Pro { get; set; }

        [StringLength(255)]
        public string deal { get; set; }

        public byte[] img { get; set; }

        public int moyRate { get; set; }

        public int nb_rate { get; set; }

        public int note { get; set; }

        public int rate { get; set; }

        [StringLength(255)]
        public string text { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        public int? id_In { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<insurance> insurance { get; set; }

        public virtual insurance insurance1 { get; set; }
    }
}

namespace Insurance.Domaine.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("insurance.vehicle")]
    public partial class vehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vehicle()
        {
            demande = new HashSet<demande>();
            police = new HashSet<police>();
        }

        [Key]
        [StringLength(255)]
        public string Matriculation { get; set; }

        [StringLength(255)]
        public string Color { get; set; }

        [StringLength(255)]
        public string HorsePower { get; set; }

        [StringLength(255)]
        public string Mark { get; set; }

        [StringLength(255)]
        public string Model { get; set; }

        public int NumChassis { get; set; }

        public int? idInsured { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<demande> demande { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<police> police { get; set; }

        public virtual users users { get; set; }
    }
}

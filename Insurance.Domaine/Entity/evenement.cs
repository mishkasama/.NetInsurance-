namespace Insurance.Domaine.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("insurance.evenement")]
    public partial class evenement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public evenement()
        {
            participate = new HashSet<participate>();
            users = new HashSet<users>();
        }

        public int EvenementId { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Start_Date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Finish_Date { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public int? UserId { get; set; }

        public int? AgenceId { get; set; }

        [StringLength(255)]
        public string Localisation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<participate> participate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<users> users { get; set; }
    }
}

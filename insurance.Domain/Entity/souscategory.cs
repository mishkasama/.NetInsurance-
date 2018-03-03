namespace insurance.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("insurance.souscategory")]
    public partial class souscategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public souscategory()
        {
            topic = new HashSet<topic>();
        }

        [Key]
        public int idSousCategory { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public int? idCategory { get; set; }

        public int? idUser { get; set; }

        public virtual category category { get; set; }

        public virtual user user { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<topic> topic { get; set; }
    }
}

namespace insurance.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("insurance.topic")]
    public partial class topic
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public topic()
        {
            messages = new HashSet<messages>();
            user1 = new HashSet<user>();
        }

        [Key]
        public int idTopic { get; set; }

        [StringLength(255)]
        public string contenu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateCreation { get; set; }

        public DateTime? lastpost { get; set; }

        [StringLength(255)]
        public string sujet { get; set; }

        public int? idCreateur { get; set; }

        public int? idSousCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<messages> messages { get; set; }

        public virtual souscategory souscategory { get; set; }

        public virtual user user { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> user1 { get; set; }
    }
}

namespace insurance.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("insurance.messages")]
    public partial class messages
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public messages()
        {
            reponse = new HashSet<reponse>();
            user1 = new HashSet<user>();
        }

        [Key]
        public int idMessage { get; set; }

        [StringLength(255)]
        public string contenu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateEdit { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datePost { get; set; }

        public int? nbLike { get; set; }

        public int? idPosteur { get; set; }

        public int? idTopic { get; set; }

        public virtual user user { get; set; }

        public virtual topic topic { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reponse> reponse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> user1 { get; set; }
    }
}

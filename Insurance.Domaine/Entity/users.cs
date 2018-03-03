namespace Insurance.Domaine.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("insurance.users")]
    public partial class users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public users()
        {
            demande = new HashSet<demande>();
            favoris = new HashSet<favoris>();
            likes = new HashSet<likes>();
            messages = new HashSet<messages>();
            participate = new HashSet<participate>();
            police = new HashSet<police>();
            reponse = new HashSet<reponse>();
            souscategory = new HashSet<souscategory>();
            topic = new HashSet<topic>();
            vehicle = new HashSet<vehicle>();
            evenement = new HashSet<evenement>();
        }

        public int id { get; set; }

        public DateTime? BirthdayDate { get; set; }

        [StringLength(255)]
        public string adress { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string login { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        [StringLength(255)]
        public string phone { get; set; }

        [StringLength(255)]
        public string role { get; set; }

        public int? Online { get; set; }

        [StringLength(255)]
        public string avatar { get; set; }

        [StringLength(255)]
        public string firstName { get; set; }

        [Column(TypeName = "bit")]
        public bool? isActif { get; set; }

        [StringLength(255)]
        public string lastName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<demande> demande { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<favoris> favoris { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<likes> likes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<messages> messages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<participate> participate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<police> police { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reponse> reponse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<souscategory> souscategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<topic> topic { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vehicle> vehicle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<evenement> evenement { get; set; }
    }
}

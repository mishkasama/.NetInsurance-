namespace insurance.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("insurance.reponse")]
    public partial class reponse
    {
        [Key]
        public int idReponse { get; set; }

        [StringLength(255)]
        public string contenu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateEdit { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datePost { get; set; }

        public int? idUser { get; set; }

        public int? idMessage { get; set; }

        public virtual messages messages { get; set; }

        public virtual user user { get; set; }
    }
}

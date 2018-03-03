namespace Insurance.Domaine.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("insurance.attt")]
    public partial class attt
    {
        public int id { get; set; }

        [StringLength(255)]
        public string matriculation { get; set; }

        public int numChassie { get; set; }
    }
}

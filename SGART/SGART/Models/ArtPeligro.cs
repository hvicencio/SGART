namespace SGART.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArtPeligro")]
    public partial class ArtPeligro
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdArt { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPeligro { get; set; }

        [StringLength(2)]
        public string Aplica { get; set; }

        public virtual Art Art { get; set; }

        public virtual Peligro Peligro { get; set; }
    }
}

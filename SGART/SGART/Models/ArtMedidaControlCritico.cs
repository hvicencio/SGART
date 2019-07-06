namespace SGART.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArtMedidaControlCritico")]
    public partial class ArtMedidaControlCritico
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdArt { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdControlCritico { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdMedidaControlCritico { get; set; }

        public virtual Art Art { get; set; }

        public virtual ControlCritico ControlCritico { get; set; }

        public virtual MedidaControlCritico MedidaControlCritico { get; set; }
    }
}

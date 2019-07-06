namespace SGART.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArtControlCritico")]
    public partial class ArtControlCritico
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdArt { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdControlCritico { get; set; }

        [StringLength(2)]
        public string AplicaEmpleado { get; set; }

        [StringLength(2)]
        public string AplicaSupervisor { get; set; }

        public virtual Art Art { get; set; }

        public virtual ControlCritico ControlCritico { get; set; }
    }
}

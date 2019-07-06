namespace SGART.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArtPreguntaRiesgo")]
    public partial class ArtPreguntaRiesgo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdArt { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPreguntaRiesgo { get; set; }

        [StringLength(255)]
        public string Respuesta { get; set; }

        public virtual Art Art { get; set; }

        public virtual PreguntaRiesgo PreguntaRiesgo { get; set; }
    }
}

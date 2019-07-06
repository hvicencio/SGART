namespace SGART.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PreguntaRiesgo")]
    public partial class PreguntaRiesgo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PreguntaRiesgo()
        {
            ArtPreguntaRiesgo = new HashSet<ArtPreguntaRiesgo>();
        }

        [Key]
        public int IdPreguntaRiesgo { get; set; }

        [StringLength(255)]
        public string DescripcionPregunta { get; set; }

        public int? NumeroPregunta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtPreguntaRiesgo> ArtPreguntaRiesgo { get; set; }
    }
}

namespace SGART.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Art")]
    public partial class Art
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Art()
        {
            Actividad = new HashSet<Actividad>();
            ArtControlCritico = new HashSet<ArtControlCritico>();
            ArtMedidaControlCritico = new HashSet<ArtMedidaControlCritico>();
            ArtPeligro = new HashSet<ArtPeligro>();
            ArtPreguntaRiesgo = new HashSet<ArtPreguntaRiesgo>();
        }

        [Key]
        public int IdArt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        public DateTime? HoraInicio { get; set; }

        public DateTime? HoraTermino { get; set; }

        [StringLength(255)]
        public string Lugar { get; set; }

        [StringLength(255)]
        public string Trabajo { get; set; }

        [StringLength(255)]
        public string Estado { get; set; }

        [StringLength(255)]
        public string Realizador { get; set; }

        [StringLength(255)]
        public string Confirmador { get; set; }

        public int IdArea { get; set; }

        public int IdEmpresa { get; set; }

        public int IdSuperintendencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Actividad> Actividad { get; set; }

        public virtual Area Area { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual Superintendencia Superintendencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtControlCritico> ArtControlCritico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtMedidaControlCritico> ArtMedidaControlCritico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtPeligro> ArtPeligro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtPreguntaRiesgo> ArtPreguntaRiesgo { get; set; }
    }
}

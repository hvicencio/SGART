namespace SGART.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ControlCritico")]
    public partial class ControlCritico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ControlCritico()
        {
            ArtControlCritico = new HashSet<ArtControlCritico>();
            ArtMedidaControlCritico = new HashSet<ArtMedidaControlCritico>();
            MedidaControlCritico = new HashSet<MedidaControlCritico>();
        }

        [Key]
        public int IdControlCritico { get; set; }

        [StringLength(255)]
        public string TituloControlCritico { get; set; }

        [StringLength(255)]
        public string DescripcionControlCritico { get; set; }

        [StringLength(255)]
        public string PreguntaVerificacionSupervisor { get; set; }

        [StringLength(255)]
        public string PreguntaVerificacionEmpleado { get; set; }

        public int? NumeroControlCritico { get; set; }

        public int IdPeligro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtControlCritico> ArtControlCritico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtMedidaControlCritico> ArtMedidaControlCritico { get; set; }

        public virtual Peligro Peligro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedidaControlCritico> MedidaControlCritico { get; set; }
    }
}

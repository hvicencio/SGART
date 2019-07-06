namespace SGART.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Actividad")]
    public partial class Actividad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Actividad()
        {
            Riesgo = new HashSet<Riesgo>();
        }

        [Key]
        public int IdActividad { get; set; }

        [StringLength(255)]
        public string DescripcionActividad { get; set; }

        public int? Secuencia { get; set; }

        public int IdProcedimiento { get; set; }

        public int? IdArt { get; set; }

        public virtual Art Art { get; set; }

        public virtual Procedimiento Procedimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Riesgo> Riesgo { get; set; }
    }
}

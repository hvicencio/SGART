namespace SGART.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Riesgo")]
    public partial class Riesgo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Riesgo()
        {
            MedidaControl = new HashSet<MedidaControl>();
        }

        [Key]
        public int IdRiesgo { get; set; }

        [StringLength(255)]
        public string DescripcionRiesgo { get; set; }

        public int IdActividad { get; set; }

        public virtual Actividad Actividad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedidaControl> MedidaControl { get; set; }
    }
}

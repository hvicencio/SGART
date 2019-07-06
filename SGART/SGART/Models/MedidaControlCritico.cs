namespace SGART.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MedidaControlCritico")]
    public partial class MedidaControlCritico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedidaControlCritico()
        {
            ArtMedidaControlCritico = new HashSet<ArtMedidaControlCritico>();
        }

        [Key]
        public int IdMedidaControlCritico { get; set; }

        [StringLength(255)]
        public string DescripcionMedidaControlCritico { get; set; }

        public int IdControlCritico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtMedidaControlCritico> ArtMedidaControlCritico { get; set; }

        public virtual ControlCritico ControlCritico { get; set; }
    }
}

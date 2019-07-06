namespace SGART.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Peligro")]
    public partial class Peligro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Peligro()
        {
            ArtPeligro = new HashSet<ArtPeligro>();
            ControlCritico = new HashSet<ControlCritico>();
        }

        [Key]
        public int IdPeligro { get; set; }

        [StringLength(255)]
        public string DescripcionPeligro { get; set; }

        [StringLength(255)]
        public string Regla { get; set; }

        public int? NumeroRegla { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtPeligro> ArtPeligro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ControlCritico> ControlCritico { get; set; }
    }
}

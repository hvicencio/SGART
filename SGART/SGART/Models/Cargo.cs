namespace SGART.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cargo")]
    public partial class Cargo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cargo()
        {
            Empleado = new HashSet<Empleado>();
        }

        [Key]
        public int IdCargo { get; set; }

        [StringLength(255)]
        public string DescripcionCargo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleado> Empleado { get; set; }

        public Cargo(int idCargo, string descripcionCargo)
        {
            IdCargo = idCargo;
            DescripcionCargo = descripcionCargo;
        }
    }
}

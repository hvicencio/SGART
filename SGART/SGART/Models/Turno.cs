namespace SGART.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Turno")]
    public partial class Turno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Turno()
        {
            Empleado = new HashSet<Empleado>();
        }

        [Key]
        public int IdTurno { get; set; }

        [StringLength(255)]
        public string DescripcionTurno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleado> Empleado { get; set; }

        public Turno(int idTurno, string descripcionTurno)
        {
            IdTurno = idTurno;
            DescripcionTurno = descripcionTurno;
        }
    }
}

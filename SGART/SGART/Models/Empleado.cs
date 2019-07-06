namespace SGART.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empleado")]
    public partial class Empleado
    {
        [Key]
        [StringLength(12)]
        public string Run { get; set; }

        [StringLength(255)]
        public string Apellido { get; set; }

        [StringLength(255)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(255)]
        public string Usuario { get; set; }

        [StringLength(255)]
        public string Contrasena { get; set; }

        public int IdCargo { get; set; }

        public int IdRol { get; set; }

        public int IdTurno { get; set; }

        public int IdEmpresa { get; set; }

        public virtual Cargo Cargo { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual Rol Rol { get; set; }

        public virtual Turno Turno { get; set; }

        public Empleado(string run, string apellido, string nombre, string usuario, string contrasena, int idCargo, int idRol, int idTurno, int idEmpresa)
        {
            Run = run;
            Apellido = apellido;
            Nombre = nombre;
            Usuario = usuario;
            Contrasena = contrasena;
            IdCargo = idCargo;
            IdRol = idRol;
            IdTurno = idTurno;
            IdEmpresa = idEmpresa;
        }
        public Empleado()
        {
        }
    }
}

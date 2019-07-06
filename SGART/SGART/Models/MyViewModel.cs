using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGART.Models
{
    public class MyViewModel
    {

        public IEnumerable<SGART.Models.Empleado> Empleados { get; set; }
        public SGART.Models.Empleado Empleado { get; set; }
        public IEnumerable<SGART.Models.Rol> Roles { get; set; }
        public SGART.Models.Rol Rol { get; set; }
        public IEnumerable<SGART.Models.Turno> Turnos { get; set; }
        public SGART.Models.Turno Turno { get; set; }
        public IEnumerable<SGART.Models.Cargo> Cargos { get; set; }
        public SGART.Models.Cargo Cargo { get; set; }


    }
}
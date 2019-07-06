using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SGART.Models;

namespace SGART.Controllers
{
    public class DashboardAdminController : Controller
    {
        private ModelGsart db = new ModelGsart ();
        // GET: DashboardAdmin
        public ActionResult Index()
        {
            MyViewModel myView = new MyViewModel
            {
                Empleados = db.Empleado.ToList(),
                Roles = db.Rol.ToList(),
                Turnos = db.Turno.ToList(),
                Cargos = db.Cargo.ToList()
            };
            return View(myView);
        }
    }
}
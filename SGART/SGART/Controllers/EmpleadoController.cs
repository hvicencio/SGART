using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SGART.Models;

namespace SGART.Controllers
{
    public class EmpleadoController : Controller
    {
        private ModelGsart db = new ModelGsart();

        // GET: Empleado
        public ActionResult Index()
        {
            var empleado = db.Empleado.Include(e => e.Cargo).Include(e => e.Rol).Include(e => e.Turno);
            ViewBag.IdCargo = new SelectList(db.Cargo, "IdCargo", "DescripcionCargo");
            ViewBag.IdRol = new SelectList(db.Rol, "IdRol", "DescripcionRol");
            ViewBag.IdTurno = new SelectList(db.Turno, "IdTurno", "DescripcionTurno");
            ViewBag.IdEmpresa = new SelectList(db.Empresa, "IdEmpresa", "DescripcionEmpresa");
            return View(empleado.ToList());
        }


        public ActionResult Create(string run, string nombre, string apellido, string usuario, string contrasena, int IdRol, int Idcargo, int IdTurno, int IdEmpresa)
        {
            if (run.Count() > 0 || run != "" || nombre.Count() > 0 || nombre != "" || apellido.Count() > 0 || apellido != ""
                || usuario.Count() > 0 || usuario != "" || contrasena.Count() > 0 || contrasena != "" || IdRol.ToString().Count() > 0
                || IdTurno.ToString().Count() > 0 || Idcargo.ToString().Count() > 0 || IdEmpresa.ToString().Count() > 0)
            {
                Empleado empleado = new Empleado(run, apellido, nombre, usuario, contrasena, Idcargo, IdRol, IdTurno, IdEmpresa);
                db.Empleado.Add(empleado);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(string run, string nombre, string apellido, string usuario, string contrasena, int IdRol, int Idcargo, int IdTurno, int IdEmpresa)
        {
            if (run.Count() > 0 || run != "" || nombre.Count() > 0 || nombre != "" || apellido.Count() > 0 || apellido != ""
                || usuario.Count() > 0 || usuario != "" || contrasena.Count() > 0 || contrasena != "" || IdRol.ToString().Count() > 0 || IdRol.ToString() != ""
                || IdTurno.ToString().Count() > 0 || IdTurno.ToString() != "" || Idcargo.ToString().Count() > 0 || Idcargo.ToString() != "" || IdEmpresa.ToString().Count() > 0 || IdEmpresa.ToString() != "")
            {
                Empleado empleado = db.Empleado.Find(run);
                if (empleado != null)
                {
                    db.Empleado.Remove(empleado);
                    Empleado empleadoNuevo = new Empleado(run, apellido, nombre, usuario, contrasena, Idcargo, IdRol, IdTurno, IdEmpresa);

                    empleado.Run = run;
                    empleado.Nombre = nombre;
                    empleado.Apellido = apellido;
                    empleado.Usuario = usuario;
                    empleado.Contrasena = contrasena;
                    empleado.IdEmpresa = IdEmpresa;
                    empleado.IdRol = IdRol;
                    empleado.IdCargo = Idcargo;
                    empleado.IdTurno = IdTurno;
                    db.SaveChanges();
                }

            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(string run)
        {
            Empleado empleado = db.Empleado.Find(run);
            if (empleado != null)
            {
                db.Empleado.Remove(empleado);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

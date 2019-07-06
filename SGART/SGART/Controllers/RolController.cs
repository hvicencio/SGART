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
    public class RolController : Controller
    {
        private ModelGsart db = new ModelGsart();

        // GET: Rol
        public ActionResult Index()
        {
            return View(db.Rol.ToList());
        }

        public ActionResult Create(string descripcionRol)
        {
            if (descripcionRol.Length != 0 || descripcionRol != "")
            {
                Rol Rol = new Rol(0, descripcionRol);
                db.Rol.Add(Rol);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int idRol, string descripcionRolModificar)
        {
            if (descripcionRolModificar.Length != 0 || descripcionRolModificar != "")
            {
                Rol Rol = db.Rol.Find(idRol);
                if (Rol != null)
                {
                    Rol.DescripcionRol = descripcionRolModificar;
                    db.SaveChanges();
                }

            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int idRol)
        {
            Rol Rol = db.Rol.Find(idRol);
            if (Rol != null)
            {
                db.Rol.Remove(Rol);
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

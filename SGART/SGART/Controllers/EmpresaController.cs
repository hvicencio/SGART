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
    public class EmpresaController : Controller
    {
        private ModelGsart db = new ModelGsart();

        public ActionResult Index()
        {
            return View(db.Empresa.ToList());
        }

        public ActionResult Create(string descripcionEmpresa)
        {
            if (descripcionEmpresa.Length != 0 || descripcionEmpresa != "")
            {
                Empresa Empresa = new Empresa(0, descripcionEmpresa);
                db.Empresa.Add(Empresa);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int idEmpresa, string descripcionEmpresaModificar)
        {
            if (descripcionEmpresaModificar.Length != 0 || descripcionEmpresaModificar != "")
            {
                Empresa Empresa = db.Empresa.Find(idEmpresa);
                if (Empresa != null)
                {
                    Empresa.DescripcionEmpresa = descripcionEmpresaModificar;
                    db.SaveChanges();
                }

            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int idEmpresa)
        {
            Empresa Empresa = db.Empresa.Find(idEmpresa);
            if (Empresa != null)
            {
                db.Empresa.Remove(Empresa);
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

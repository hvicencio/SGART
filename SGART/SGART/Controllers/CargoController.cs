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
    public class CargoController : Controller
    {
        private ModelGsart db = new ModelGsart();

        // GET: Cargo
        public ActionResult Index()
        {
            return View(db.Cargo.ToList());
        }


        public ActionResult Create(string descripcionCargo)
        {
            if (descripcionCargo.Length != 0 || descripcionCargo != "")
            {
                Cargo cargo = new Cargo(0, descripcionCargo);
                db.Cargo.Add(cargo);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int idCargo, string descripcionCargoModificar)
        {
            if (descripcionCargoModificar.Length != 0 || descripcionCargoModificar != "")
            {
                Cargo cargo = db.Cargo.Find(idCargo);
                cargo.DescripcionCargo = descripcionCargoModificar;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int idCargo)
        {
            Cargo cargo = db.Cargo.Find(idCargo);
            if (cargo != null)
            {
                db.Cargo.Remove(cargo);
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

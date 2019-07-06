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
    public class TurnoController : Controller
    {
        private ModelGsart db = new ModelGsart();

        // GET: Turno
        public ActionResult Index()
        {
            return View(db.Turno.ToList());
        }

        public ActionResult Create(string descripcionTurno)
        {
            if (descripcionTurno.Length != 0 || descripcionTurno != "")
            {
                Turno turno = new Turno(0, descripcionTurno);
                db.Turno.Add(turno);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int idTurno, string descripcionTurnoModificar)
        {
            if (descripcionTurnoModificar.Length != 0 || descripcionTurnoModificar != "")
            {
                Turno turno = db.Turno.Find(idTurno);
                if (turno != null)
                {
                    turno.DescripcionTurno = descripcionTurnoModificar;
                    db.SaveChanges();
                }

            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int idTurno)
        {
            Turno turno = db.Turno.Find(idTurno);
            if (turno != null)
            {
                db.Turno.Remove(turno);
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

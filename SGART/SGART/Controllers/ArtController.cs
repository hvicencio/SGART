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
    public class ArtController : Controller
    {
        private ModelGsart db = new ModelGsart();

        // GET: Art
        public ActionResult Index()
        {
            var art = db.Art.Include(a => a.Area).Include(a => a.Empresa).Include(a => a.Superintendencia);
            return View(art.ToList());
        }

        // GET: Art/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Art art = db.Art.Find(id);
            if (art == null)
            {
                return HttpNotFound();
            }
            return View(art);
        }

        // GET: Art/Create
        public ActionResult Create()
        {
            ViewBag.IdArea = new SelectList(db.Area, "IdArea", "DescripcionArea");
            ViewBag.IdEmpresa = new SelectList(db.Empresa, "IdEmpresa", "DescripcionEmpresa");
            ViewBag.IdSuperintendencia = new SelectList(db.Superintendencia, "IdSuperintendencia", "DescripcionSuperintendencia");
            return View();
        }

        // POST: Art/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdArt,Fecha,HoraInicio,HoraTermino,Lugar,Trabajo,Estado,Realizador,Confirmador,IdArea,IdEmpresa,IdSuperintendencia")] Art art)
        {
            if (ModelState.IsValid)
            {
                db.Art.Add(art);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdArea = new SelectList(db.Area, "IdArea", "DescripcionArea", art.IdArea);
            ViewBag.IdEmpresa = new SelectList(db.Empresa, "IdEmpresa", "DescripcionEmpresa", art.IdEmpresa);
            ViewBag.IdSuperintendencia = new SelectList(db.Superintendencia, "IdSuperintendencia", "DescripcionSuperintendencia", art.IdSuperintendencia);
            return View(art);
        }

        // GET: Art/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Art art = db.Art.Find(id);
            if (art == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdArea = new SelectList(db.Area, "IdArea", "DescripcionArea", art.IdArea);
            ViewBag.IdEmpresa = new SelectList(db.Empresa, "IdEmpresa", "DescripcionEmpresa", art.IdEmpresa);
            ViewBag.IdSuperintendencia = new SelectList(db.Superintendencia, "IdSuperintendencia", "DescripcionSuperintendencia", art.IdSuperintendencia);
            return View(art);
        }

        // POST: Art/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdArt,Fecha,HoraInicio,HoraTermino,Lugar,Trabajo,Estado,Realizador,Confirmador,IdArea,IdEmpresa,IdSuperintendencia")] Art art)
        {
            if (ModelState.IsValid)
            {
                db.Entry(art).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdArea = new SelectList(db.Area, "IdArea", "DescripcionArea", art.IdArea);
            ViewBag.IdEmpresa = new SelectList(db.Empresa, "IdEmpresa", "DescripcionEmpresa", art.IdEmpresa);
            ViewBag.IdSuperintendencia = new SelectList(db.Superintendencia, "IdSuperintendencia", "DescripcionSuperintendencia", art.IdSuperintendencia);
            return View(art);
        }

        // GET: Art/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Art art = db.Art.Find(id);
            if (art == null)
            {
                return HttpNotFound();
            }
            return View(art);
        }

        // POST: Art/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Art art = db.Art.Find(id);
            db.Art.Remove(art);
            db.SaveChanges();
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using prgGestionDeCompañias;

namespace prgGestionDeCompañias.Controllers
{
    public class ProyectosController : Controller
    {
        private BDPortafolioUcrContext db = new BDPortafolioUcrContext();

        // GET: Proyectos
        public ActionResult Index()
        {
            return View(db.tbProyectos.ToList());
        }

        // GET: Proyectos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbProyectos tbProyectos = db.tbProyectos.Find(id);
            if (tbProyectos == null)
            {
                return HttpNotFound();
            }
            return View(tbProyectos);
        }

        // GET: Proyectos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Proyectos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idProyecto,nombre,descripcion,estado,tipo,informacion")] tbProyectos tbProyectos)
        {
            if (ModelState.IsValid)
            {
                db.tbProyectos.Add(tbProyectos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbProyectos);
        }

        // GET: Proyectos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbProyectos tbProyectos = db.tbProyectos.Find(id);
            if (tbProyectos == null)
            {
                return HttpNotFound();
            }
            return View(tbProyectos);
        }

        // POST: Proyectos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idProyecto,nombre,descripcion,estado,tipo,informacion")] tbProyectos tbProyectos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbProyectos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbProyectos);
        }

        // GET: Proyectos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbProyectos tbProyectos = db.tbProyectos.Find(id);
            if (tbProyectos == null)
            {
                return HttpNotFound();
            }
            return View(tbProyectos);
        }

        // POST: Proyectos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbProyectos tbProyectos = db.tbProyectos.Find(id);
            db.tbProyectos.Remove(tbProyectos);
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

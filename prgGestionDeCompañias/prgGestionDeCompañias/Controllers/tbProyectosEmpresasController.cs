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
    public class tbProyectosEmpresasController : Controller
    {
        private BDPortafolioUcrContext db = new BDPortafolioUcrContext();

        // GET: tbProyectosEmpresas
        public ActionResult Index()
        {
            var tbProyectosEmpresa = db.tbProyectosEmpresa.Include(t => t.tbEmpresas).Include(t => t.tbProyectos);
            return View(tbProyectosEmpresa.ToList());
        }

        // GET: tbProyectosEmpresas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbProyectosEmpresa tbProyectosEmpresa = db.tbProyectosEmpresa.Find(id);
            if (tbProyectosEmpresa == null)
            {
                return HttpNotFound();
            }
            return View(tbProyectosEmpresa);
        }

        // GET: tbProyectosEmpresas/Create
        public ActionResult Create()
        {
            ViewBag.idEmpresa = new SelectList(db.tbEmpresas, "idEmpresa", "nombre");
            ViewBag.idProyecto = new SelectList(db.tbProyectos, "idProyecto", "nombre");
            return View();
        }

        // POST: tbProyectosEmpresas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idEmpresa,idProyecto,horasInvertidas")] tbProyectosEmpresa tbProyectosEmpresa)
        {
            if (ModelState.IsValid)
            {
                db.tbProyectosEmpresa.Add(tbProyectosEmpresa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idEmpresa = new SelectList(db.tbEmpresas, "idEmpresa", "nombre", tbProyectosEmpresa.idEmpresa);
            ViewBag.idProyecto = new SelectList(db.tbProyectos, "idProyecto", "nombre", tbProyectosEmpresa.idProyecto);
            return View(tbProyectosEmpresa);
        }

        // GET: tbProyectosEmpresas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbProyectosEmpresa tbProyectosEmpresa = db.tbProyectosEmpresa.Find(id);
            if (tbProyectosEmpresa == null)
            {
                return HttpNotFound();
            }
            ViewBag.idEmpresa = new SelectList(db.tbEmpresas, "idEmpresa", "nombre", tbProyectosEmpresa.idEmpresa);
            ViewBag.idProyecto = new SelectList(db.tbProyectos, "idProyecto", "nombre", tbProyectosEmpresa.idProyecto);
            return View(tbProyectosEmpresa);
        }

        // POST: tbProyectosEmpresas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idEmpresa,idProyecto,horasInvertidas")] tbProyectosEmpresa tbProyectosEmpresa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbProyectosEmpresa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idEmpresa = new SelectList(db.tbEmpresas, "idEmpresa", "nombre", tbProyectosEmpresa.idEmpresa);
            ViewBag.idProyecto = new SelectList(db.tbProyectos, "idProyecto", "nombre", tbProyectosEmpresa.idProyecto);
            return View(tbProyectosEmpresa);
        }

        // GET: tbProyectosEmpresas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbProyectosEmpresa tbProyectosEmpresa = db.tbProyectosEmpresa.Find(id);
            if (tbProyectosEmpresa == null)
            {
                return HttpNotFound();
            }
            return View(tbProyectosEmpresa);
        }

        // POST: tbProyectosEmpresas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbProyectosEmpresa tbProyectosEmpresa = db.tbProyectosEmpresa.Find(id);
            db.tbProyectosEmpresa.Remove(tbProyectosEmpresa);
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

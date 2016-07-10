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
    public class tbCorreosController : Controller
    {
        private BDPortafolioUcrContext db = new BDPortafolioUcrContext();

        // GET: tbCorreos
        public ActionResult Index()
        {
            var tbCorreos = db.tbCorreos.Include(t => t.tbCapacitaciones).Include(t => t.tbEmpresas).Include(t => t.tbEstudiantes).Include(t => t.tbProfesores);
            return View(tbCorreos.ToList());
        }

        // GET: tbCorreos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbCorreos tbCorreos = db.tbCorreos.Find(id);
            if (tbCorreos == null)
            {
                return HttpNotFound();
            }
            return View(tbCorreos);
        }

        // GET: tbCorreos/Create
        public ActionResult Create()
        {
            ViewBag.idPersona = new SelectList(db.tbCapacitaciones, "id", "nombre");
            ViewBag.idPersona = new SelectList(db.tbEmpresas, "idEmpresa", "nombre");
            ViewBag.idPersona = new SelectList(db.tbEstudiantes, "idEstudiante", "carnet");
            ViewBag.idPersona = new SelectList(db.tbProfesores, "idProfesor", "nombre");
            return View();
        }

        // POST: tbCorreos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCorreo,idPersona,tipoPersona,correo")] tbCorreos tbCorreos)
        {
            if (ModelState.IsValid)
            {
                db.tbCorreos.Add(tbCorreos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idPersona = new SelectList(db.tbCapacitaciones, "id", "nombre", tbCorreos.idPersona);
            ViewBag.idPersona = new SelectList(db.tbEmpresas, "idEmpresa", "nombre", tbCorreos.idPersona);
            ViewBag.idPersona = new SelectList(db.tbEstudiantes, "idEstudiante", "carnet", tbCorreos.idPersona);
            ViewBag.idPersona = new SelectList(db.tbProfesores, "idProfesor", "nombre", tbCorreos.idPersona);
            return View(tbCorreos);
        }

        // GET: tbCorreos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbCorreos tbCorreos = db.tbCorreos.Find(id);
            if (tbCorreos == null)
            {
                return HttpNotFound();
            }
            ViewBag.idPersona = new SelectList(db.tbCapacitaciones, "id", "nombre", tbCorreos.idPersona);
            ViewBag.idPersona = new SelectList(db.tbEmpresas, "idEmpresa", "nombre", tbCorreos.idPersona);
            ViewBag.idPersona = new SelectList(db.tbEstudiantes, "idEstudiante", "carnet", tbCorreos.idPersona);
            ViewBag.idPersona = new SelectList(db.tbProfesores, "idProfesor", "nombre", tbCorreos.idPersona);
            return View(tbCorreos);
        }

        // POST: tbCorreos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCorreo,idPersona,tipoPersona,correo")] tbCorreos tbCorreos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbCorreos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idPersona = new SelectList(db.tbCapacitaciones, "id", "nombre", tbCorreos.idPersona);
            ViewBag.idPersona = new SelectList(db.tbEmpresas, "idEmpresa", "nombre", tbCorreos.idPersona);
            ViewBag.idPersona = new SelectList(db.tbEstudiantes, "idEstudiante", "carnet", tbCorreos.idPersona);
            ViewBag.idPersona = new SelectList(db.tbProfesores, "idProfesor", "nombre", tbCorreos.idPersona);
            return View(tbCorreos);
        }

        // GET: tbCorreos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbCorreos tbCorreos = db.tbCorreos.Find(id);
            if (tbCorreos == null)
            {
                return HttpNotFound();
            }
            return View(tbCorreos);
        }

        // POST: tbCorreos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbCorreos tbCorreos = db.tbCorreos.Find(id);
            db.tbCorreos.Remove(tbCorreos);
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

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
    public class tbDireccionesController : Controller
    {
        private BDPortafolioUcrContext db = new BDPortafolioUcrContext();

        // GET: tbDirecciones
        public ActionResult Index()
        {
            var tbDirecciones = db.tbDirecciones.Include(t => t.tbEmpresas).Include(t => t.tbEstudiantes).Include(t => t.tbProfesores);
            return View(tbDirecciones.ToList());
        }

        // GET: tbDirecciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbDirecciones tbDirecciones = db.tbDirecciones.Find(id);
            if (tbDirecciones == null)
            {
                return HttpNotFound();
            }
            return View(tbDirecciones);
        }

        // GET: tbDirecciones/Create
        public ActionResult Create()
        {
            ViewBag.idPersona = new SelectList(db.tbEmpresas, "idEmpresa", "nombre");
            ViewBag.idPersona = new SelectList(db.tbEstudiantes, "idEstudiante", "carnet");
            ViewBag.idPersona = new SelectList(db.tbProfesores, "idProfesor", "nombre");
            return View();
        }

        // POST: tbDirecciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idDireccion,tipoPersona,idPersona,direccion,provincia,canton,distrito")] tbDirecciones tbDirecciones)
        {
            if (ModelState.IsValid)
            {
                db.tbDirecciones.Add(tbDirecciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idPersona = new SelectList(db.tbEmpresas, "idEmpresa", "nombre", tbDirecciones.idPersona);
            ViewBag.idPersona = new SelectList(db.tbEstudiantes, "idEstudiante", "carnet", tbDirecciones.idPersona);
            ViewBag.idPersona = new SelectList(db.tbProfesores, "idProfesor", "nombre", tbDirecciones.idPersona);
            return View(tbDirecciones);
        }

        // GET: tbDirecciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbDirecciones tbDirecciones = db.tbDirecciones.Find(id);
            if (tbDirecciones == null)
            {
                return HttpNotFound();
            }
            ViewBag.idPersona = new SelectList(db.tbEmpresas, "idEmpresa", "nombre", tbDirecciones.idPersona);
            ViewBag.idPersona = new SelectList(db.tbEstudiantes, "idEstudiante", "carnet", tbDirecciones.idPersona);
            ViewBag.idPersona = new SelectList(db.tbProfesores, "idProfesor", "nombre", tbDirecciones.idPersona);
            return View(tbDirecciones);
        }

        // POST: tbDirecciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idDireccion,tipoPersona,idPersona,direccion,provincia,canton,distrito")] tbDirecciones tbDirecciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbDirecciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idPersona = new SelectList(db.tbEmpresas, "idEmpresa", "nombre", tbDirecciones.idPersona);
            ViewBag.idPersona = new SelectList(db.tbEstudiantes, "idEstudiante", "carnet", tbDirecciones.idPersona);
            ViewBag.idPersona = new SelectList(db.tbProfesores, "idProfesor", "nombre", tbDirecciones.idPersona);
            return View(tbDirecciones);
        }

        // GET: tbDirecciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbDirecciones tbDirecciones = db.tbDirecciones.Find(id);
            if (tbDirecciones == null)
            {
                return HttpNotFound();
            }
            return View(tbDirecciones);
        }

        // POST: tbDirecciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbDirecciones tbDirecciones = db.tbDirecciones.Find(id);
            db.tbDirecciones.Remove(tbDirecciones);
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

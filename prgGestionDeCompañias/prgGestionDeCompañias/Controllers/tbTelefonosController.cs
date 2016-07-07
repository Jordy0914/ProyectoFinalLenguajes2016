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
    public class tbTelefonosController : Controller
    {
        private BDPortafolioUcrContext db = new BDPortafolioUcrContext();

        // GET: tbTelefonos
        public ActionResult Index()
        {
            var tbTelefonos = db.tbTelefonos.Include(t => t.tbCapacitaciones).Include(t => t.tbEmpresas).Include(t => t.tbEstudiantes).Include(t => t.tbProfesores);
            return View(tbTelefonos.ToList());
        }

        // GET: tbTelefonos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbTelefonos tbTelefonos = db.tbTelefonos.Find(id);
            if (tbTelefonos == null)
            {
                return HttpNotFound();
            }
            return View(tbTelefonos);
        }

        // GET: tbTelefonos/Create
        public ActionResult Create()
        {
            ViewBag.idPersona = new SelectList(db.tbCapacitaciones, "idCapacitacion", "nombre");
            ViewBag.idPersona = new SelectList(db.tbEmpresas, "idEmpresa", "nombre");
            ViewBag.idPersona = new SelectList(db.tbEstudiantes, "idEstudiante", "carnet");
            ViewBag.idPersona = new SelectList(db.tbProfesores, "idProfesor", "nombre");
            return View();
        }

        // POST: tbTelefonos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idTelefono,telefono,idPersona,tipoPers")] tbTelefonos tbTelefonos)
        {
            if (ModelState.IsValid)
            {
                db.tbTelefonos.Add(tbTelefonos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idPersona = new SelectList(db.tbCapacitaciones, "idCapacitacion", "nombre", tbTelefonos.idPersona);
            ViewBag.idPersona = new SelectList(db.tbEmpresas, "idEmpresa", "nombre", tbTelefonos.idPersona);
            ViewBag.idPersona = new SelectList(db.tbEstudiantes, "idEstudiante", "carnet", tbTelefonos.idPersona);
            ViewBag.idPersona = new SelectList(db.tbProfesores, "idProfesor", "nombre", tbTelefonos.idPersona);
            return View(tbTelefonos);
        }

        // GET: tbTelefonos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbTelefonos tbTelefonos = db.tbTelefonos.Find(id);
            if (tbTelefonos == null)
            {
                return HttpNotFound();
            }
            ViewBag.idPersona = new SelectList(db.tbCapacitaciones, "idCapacitacion", "nombre", tbTelefonos.idPersona);
            ViewBag.idPersona = new SelectList(db.tbEmpresas, "idEmpresa", "nombre", tbTelefonos.idPersona);
            ViewBag.idPersona = new SelectList(db.tbEstudiantes, "idEstudiante", "carnet", tbTelefonos.idPersona);
            ViewBag.idPersona = new SelectList(db.tbProfesores, "idProfesor", "nombre", tbTelefonos.idPersona);
            return View(tbTelefonos);
        }

        // POST: tbTelefonos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idTelefono,telefono,idPersona,tipoPers")] tbTelefonos tbTelefonos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbTelefonos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idPersona = new SelectList(db.tbCapacitaciones, "idCapacitacion", "nombre", tbTelefonos.idPersona);
            ViewBag.idPersona = new SelectList(db.tbEmpresas, "idEmpresa", "nombre", tbTelefonos.idPersona);
            ViewBag.idPersona = new SelectList(db.tbEstudiantes, "idEstudiante", "carnet", tbTelefonos.idPersona);
            ViewBag.idPersona = new SelectList(db.tbProfesores, "idProfesor", "nombre", tbTelefonos.idPersona);
            return View(tbTelefonos);
        }

        // GET: tbTelefonos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbTelefonos tbTelefonos = db.tbTelefonos.Find(id);
            if (tbTelefonos == null)
            {
                return HttpNotFound();
            }
            return View(tbTelefonos);
        }

        // POST: tbTelefonos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbTelefonos tbTelefonos = db.tbTelefonos.Find(id);
            db.tbTelefonos.Remove(tbTelefonos);
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

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
    public class tbEmpresasController : Controller
    {
        private BDPortafolioUcrContext db = new BDPortafolioUcrContext();

        // GET: tbEmpresas
        public ActionResult Index()
        {
            return View(db.tbEmpresas.ToList());
        }

        // GET: tbEmpresas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbEmpresas tbEmpresas = db.tbEmpresas.Find(id);
            if (tbEmpresas == null)
            {
                return HttpNotFound();
            }
            return View(tbEmpresas);
        }

        // GET: tbEmpresas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbEmpresas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idEmpresa,nombre,descripcionGene,foto")] tbEmpresas tbEmpresas, [Bind(Include = "idDireccion,tipoPersona,idEmpresa,direccion,provincia,canton,distrito")] tbDirecciones tbDirecciones, [Bind(Include = "idTelefono,telefono,idEmpresa,tipoPers")] tbTelefonos tbTelefonos, [Bind(Include = "idCorreo,idEmpresa,tipoPersona,correo")] tbCorreos tbCorreos)
        {
            if (ModelState.IsValid)
            {
                db.tbEmpresas.Add(tbEmpresas);
                db.tbDirecciones.Add(tbDirecciones);
                db.tbTelefonos.Add(tbTelefonos);
                db.tbCorreos.Add(tbCorreos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbEmpresas);
        }

        // GET: tbEmpresas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbEmpresas tbEmpresas = db.tbEmpresas.Find(id);
            if (tbEmpresas == null)
            {
                return HttpNotFound();
            }
            return View(tbEmpresas);
        }

        // POST: tbEmpresas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idEmpresa,nombre,descripcionGene,foto")] tbEmpresas tbEmpresas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbEmpresas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbEmpresas);
        }

        // GET: tbEmpresas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbEmpresas tbEmpresas = db.tbEmpresas.Find(id);
            if (tbEmpresas == null)
            {
                return HttpNotFound();
            }
            return View(tbEmpresas);
        }

        // POST: tbEmpresas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbEmpresas tbEmpresas = db.tbEmpresas.Find(id);
            db.tbEmpresas.Remove(tbEmpresas);
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

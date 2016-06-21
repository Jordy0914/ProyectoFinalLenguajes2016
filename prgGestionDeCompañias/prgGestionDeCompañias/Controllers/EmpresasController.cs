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
    public class EmpresasController : Controller
    {
        private BDPortafolioUcrContext db = new BDPortafolioUcrContext();

        // GET: Empresas
        public ActionResult Index()
        {
            return View(db.tbEmpresas.ToList());
        }

        // GET: Empresas/Details/5
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

        // GET: Empresas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empresas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idEmpresa,nombre,descripcionGene,foto")] tbEmpresas tbEmpresas)
        {
            if (ModelState.IsValid)
            {
                db.tbEmpresas.Add(tbEmpresas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbEmpresas);
        }

        // GET: Empresas/Edit/5
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

        // POST: Empresas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: Empresas/Delete/5
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

        // POST: Empresas/Delete/5
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

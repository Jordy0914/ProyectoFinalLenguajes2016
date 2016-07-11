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
    public class ConveniosController : Controller
    {
        private BDPortafolioUcrContext db = new BDPortafolioUcrContext();

        // GET: Convenios
        public ActionResult Index()
        {
            return View(db.tbConvenios.ToList());
        }

        // GET: Convenios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbConvenios tbConvenios = db.tbConvenios.Find(id);
            if (tbConvenios == null)
            {
                return HttpNotFound();
            }
            return View(tbConvenios);
        }

        // GET: Convenios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Convenios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idConvenio,descripcion,fechaCrea,estado")] tbConvenios tbConvenios)
        {
            if (ModelState.IsValid)
            {
                db.tbConvenios.Add(tbConvenios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbConvenios);
        }

        // GET: Convenios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbConvenios tbConvenios = db.tbConvenios.Find(id);
            if (tbConvenios == null)
            {
                return HttpNotFound();
            }
            return View(tbConvenios);
        }

        // POST: Convenios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idConvenio,descripcion,fechaCrea,estado")] tbConvenios tbConvenios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbConvenios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbConvenios);
        }

        // GET: Convenios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbConvenios tbConvenios = db.tbConvenios.Find(id);
            if (tbConvenios == null)
            {
                return HttpNotFound();
            }
            return View(tbConvenios);
        }

        // POST: Convenios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbConvenios tbConvenios = db.tbConvenios.Find(id);
            db.tbConvenios.Remove(tbConvenios);
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

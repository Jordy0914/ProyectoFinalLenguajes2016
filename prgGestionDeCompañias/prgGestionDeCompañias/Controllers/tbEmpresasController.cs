﻿using System;
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
            BDPortafolioUcrContext db = new BDPortafolioUcrContext();
            tbEmpresas datos = new tbEmpresas();
            tbDirecciones datos1 = new tbDirecciones();
            tbTelefonos datos2 = new tbTelefonos();
            tbCorreos datos3 = new tbCorreos();


            //obtengo el ultimo numero del id de la tabla y le sumo 1 para hacer un consecutivo

            var maximo = ((from codigo in db.tbEmpresas select (int?)codigo.idEmpresa).Max()) + 1;

            var maximoDireccion = ((from codDireccion in db.tbDirecciones select (int?)codDireccion.idDireccion).Max()) + 1;

            var maximoTelefono = ((from codTelefono in db.tbTelefonos select (int?)codTelefono.idTelefono).Max()) + 1;

            var maximoCorreo = ((from codCorreo in db.tbCorreos select (int?)codCorreo.idCorreo).Max()) + 1;


            if ((maximo == 0) && (maximoDireccion == 0) && (maximoTelefono == 0) && (maximoCorreo == 0))
            {
                maximo = 1;
                datos.idEmpresa = Convert.ToInt32(1);

                maximoDireccion = 1;
                datos1.idDireccion = Convert.ToInt32(1);

                maximoTelefono = 1;
                datos2.idTelefono = Convert.ToInt32(1);

                maximoCorreo = 1;
                datos3.idCorreo = Convert.ToInt32(1);

                return View(datos);
            }//fin del if para comprobar que los codigos sean igual a cero
            else
            {
                datos.idEmpresa = Convert.ToInt32(maximo);
                datos1.idDireccion = Convert.ToInt32(maximoDireccion);
                datos2.idTelefono = Convert.ToInt32(maximoTelefono);
                datos3.idCorreo = Convert.ToInt32(maximoCorreo);
                return View(datos);
            }//fin del else
        }

        // POST: tbEmpresas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idEmpresa,nombre,descripcionGene,foto")] tbEmpresas tbEmpresas, [Bind(Include = "idDireccion,tipoPersona,idEmpresa,direccion,provincia,canton,distrito")] tbDirecciones tbDirecciones, [Bind(Include = "idTelefono,telefono,idEmpresa,tipoPersona")] tbTelefonos tbTelefonos, [Bind(Include = "idCorreo,idEmpresa,tipoPersona,correo")] tbCorreos tbCorreos)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prgGestionDeCompañias.Controllers
{
    public class CapacitacionController : Controller
    {
        // GET: Capacitacion
        public ActionResult Index()
        {
            return View();
        }

        // GET: Capacitacion/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Capacitacion/Create
        public ActionResult Insertar()
        {
            return View();
        }

        // POST: Capacitacion/Create
        [HttpPost]
        public ActionResult Insertar(Models.CapacitacionModels capacitacion)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BDPortafolioUcrContext())
                {
                    var temp = db.tbCapacitaciones.Create();
                    temp.id = capacitacion.Id;
                    temp.nombre = capacitacion.Nombre;
                    temp.descripcion = capacitacion.Descripcion;
                    temp.ubicacion = capacitacion.Ubicacion;
                    temp.idPersona = capacitacion.IdPersona;
                    temp.fechaInic = capacitacion.FechaInic;
                    temp.fechaFin = capacitacion.FechaFin;
                    temp.inversion = capacitacion.Inversion;
                    temp.tipoCertificado = capacitacion.TipoCertificado;
                    db.tbCapacitaciones.Add(temp);
                    db.SaveChanges();

                    return RedirectToAction("Index", "Home");
                } //fin del using
            }// fin del if
            else
            {
                ModelState.AddModelError("", "El registro fue incorrecto");
            }
        return View();    
        }

        // GET: Capacitacion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Capacitacion/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Capacitacion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Capacitacion/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

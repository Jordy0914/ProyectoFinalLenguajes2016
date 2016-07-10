using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prgGestionDeCompañias.Controllers
{
    public class ProyectosController : Controller
    {
        // GET: Proyectos
        public ActionResult Index()
        {
            return View();
        }

        // GET: Proyectos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Proyectos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Proyectos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult RegistrarProyectos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarProyectos(Models.RegistrarProyecto proyecto)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BDPortafolioUcrContext())
                {
                    var proyect = db.tbProyectos.Create();
                    proyect.idProyecto = proyecto.idProyecto;
                    proyect.nombre = proyecto.nombre;
                    proyect.descripcion = proyecto.descripcion;
                    proyect.estado = proyecto.estado;
                    proyect.tipo = proyecto.tipo;
                    byte[] data = new byte[proyecto.informacion.ContentLength];
                    proyecto.informacion.InputStream.Read(data, 0, proyecto.informacion.ContentLength);
                    proyect.informacion = data;
                    proyect.nombreDocumento = proyecto.informacion.FileName;
                    db.tbProyectos.Add(proyect);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }//fin del using
            }//fin del Isvalid
            else
            {
                ModelState.AddModelError("", "El registro fue incorrecto");
            }
            return View();
        }//fin del metodo de Resgitro

        // GET: Proyectos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Proyectos/Edit/5
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

        // GET: Proyectos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Proyectos/Delete/5
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

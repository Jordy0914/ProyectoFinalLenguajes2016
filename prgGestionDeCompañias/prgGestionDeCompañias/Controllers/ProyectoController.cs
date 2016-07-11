using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using prgGestionDeCompañias;

namespace prgGestionDeCompañias.Models
{
    public class ProyectoController : Controller
    {
        private BDPortafolioUcrContext db = new BDPortafolioUcrContext();

        // GET: Proyecto
        public ActionResult Index()
        {
            return View(db.tbProyectos.ToList());
        }

        // GET: Proyecto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbProyectos tbProyectos = db.tbProyectos.Find(id);
            if (tbProyectos == null)
            {
                return HttpNotFound();
            }
            return View(tbProyectos);
        }

        // GET: Proyecto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Proyecto/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create(Models.RegistrarProyecto proyecto)
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
                    return RedirectToAction("Index");
                }//fin del using
            }//fin del Isvalid
            else
            {
                ModelState.AddModelError("", "El registro fue incorrecto");
            }
            return View();
        }//fin del metodo de Registro


        // GET: Proyecto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbProyectos tbProyectos = db.tbProyectos.Find(id);
            if (tbProyectos == null)
            {
                return HttpNotFound();
            }
            return View(tbProyectos);
        }

        // POST: Proyecto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbProyectos tbProyectos = db.tbProyectos.Find(id);
            db.tbProyectos.Remove(tbProyectos);
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

        public FileContentResult DescargarArchivo(int id)
        {
            byte[] data;
            string name;

            tbProyectos tbProyectos = db.tbProyectos.Find(id);
            data = (byte[])tbProyectos.informacion.ToArray();
            name = tbProyectos.nombreDocumento;
            return File(data, "Text", name);
        }
    }
}

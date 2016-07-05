using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using models = prgGestionDeCompañias.Models;
//using ent = prgGestionDeCompañias_Entidad;


namespace prgGestionDeCompañias.Controllers
{
    public class MaterialDidacticoController : Controller
    {
        // GET: MaterialDidactico
        public ActionResult Index()

        {
            BDPortafolioUcrContext dbContext = new BDPortafolioUcrContext();
            //realizo la consulta
            var consulta = from datos in dbContext.tbArchivos
                           orderby datos.idArchivo ascending
                           select datos;
            //se crea la una coleccion de elementos

            IEnumerable<tbArchivos> archivos = consulta.ToList();

            return View(archivos);         
        }

        // GET: MaterialDidactico/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MaterialDidactico/Create
        public ActionResult AgregarMaterial()
        {
            BDPortafolioUcrContext db = new BDPortafolioUcrContext();
            Models.AgregarMaterialDidactico datos = new Models.AgregarMaterialDidactico();
            //obtengo el ultimo numero del id de la tabla y le sumo 1
            //para hacer un consecutivo

            var maximo = ((from codigo in db.tbMaterialesDida select (int?)codigo.idMaterialDida).Max()) + 1;

            //lo convietro en string y se lo asigno al al id de la tabla
            //del modelo creado por nosotros
            if (maximo == 0)
            {
                maximo = 1;
                datos.idMaterialDidactico = Convert.ToInt32(1);
                return View(datos);
            }
            else
            {
                datos.idMaterialDidactico = Convert.ToInt32(maximo);
                return View(datos);
            }

        }

        // POST: MaterialDidactico/Create


        [HttpPost]
        public ActionResult AgregarMaterial(models.AgregarMaterialDidactico material)
        {
           
                // TODO: Add insert logic here
               

                if (ModelState.IsValid)
                {
                    using (var db = new BDPortafolioUcrContext())
                    {

                    var materiales = db.tbMaterialesDida.Create();
                    var archivos = db.tbArchivos.Create();
                    var autores = db.tbAutores.Create();

                    byte[] data = new byte[material.archivo.ContentLength];
                    material.archivo.InputStream.Read(data, 0, material.archivo.ContentLength);

                
                    archivos.idArchivo = Convert.ToInt32(4);//
                    archivos.archivo = data;


                    // material.contenido = material.archivo.ContentType;
                    // archivos.archivo = material.archivo.ContentType;

                    materiales.nombreArch = material.archivo.FileName;
                    int cod = Convert.ToInt32(materiales.idMaterialDida);
                   // materiales.idMaterialDida = Convert.ToInt32(material.idMaterialDidactico);
                    materiales.titulo = material.titulo;
                    materiales.fechaPubl = Convert.ToDateTime( material.fechaPublicacion);
                    materiales.ciudad = material.cuidad;
                    materiales.pais = material.pais;


                   
                    autores.nombre = material.autor;
                    autores.idAutor = Convert.ToInt32(3);
                    

                    db.tbMaterialesDida.Add(materiales);
                    db.tbArchivos.Add(archivos);
                    db.tbAutores.Add(autores);

                    db.SaveChanges();
                   
                    return RedirectToAction("AgregarMaterial", "MaterialDidactico");
                        //return RedirectToAction("Index"); es que traia por defecto

               }//fin del using
         }//fin del if valid

         else
           {
              ModelState.AddModelError("", "El registro fue incorrecto");
           }

            return View();
        }//fin del metodo para agregar material didactico

        // GET: MaterialDidactico/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MaterialDidactico/Edit/5
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

        // GET: MaterialDidactico/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MaterialDidactico/Delete/5
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



        public FileContentResult DescargarArchivo(int id)
        {

            Byte[] data;
            String nombre;

            using (var db = new BDPortafolioUcrContext())
            {

                var archivos = db.tbArchivos.Create();
                var materiales = db.tbMaterialesDida.Create();

            data = (Byte[])archivos.archivo.ToArray();
                nombre = materiales.nombreArch;
          }

            return File(data,"Text",nombre);
        }

    }
}

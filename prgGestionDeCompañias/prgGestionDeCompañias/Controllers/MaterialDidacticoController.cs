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
        [HttpGet]
        public ActionResult Listado()

        {
            BDPortafolioUcrContext dbContext = new BDPortafolioUcrContext();
            //realizo la consulta
            var consulta = from datos in dbContext.tbMaterialesDida
                           orderby datos.idMaterialDida ascending
                           select datos;
            //se crea la una coleccion de elementos

            IEnumerable < tbMaterialesDida > material = consulta.ToList();
        
            return View(material);      
        }

        // GET: MaterialDidactico/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MaterialDidactico/Create
        [HttpGet]
        public ActionResult AgregarMaterial()
        {
            BDPortafolioUcrContext db = new BDPortafolioUcrContext();
            Models.AgregarMaterialDidactico datos = new Models.AgregarMaterialDidactico();
            
            //obtengo el ultimo numero del id de la tabla y le sumo 1 para hacer un consecutivo

            var maximo = ((from codigo in db.tbMaterialesDida select (int?)codigo.idMaterialDida).Max()) + 1;

            var maximoAutores = ((from codAutor in db.tbAutores select (int?)codAutor.idAutor).Max()) + 1;

            var maximoArchivo = ((from codArchivo in db.tbArchivos select (int?) codArchivo.idArchivo).Max()) + 1;
          
            
            if ((maximo == 0) && (maximoAutores == 0) && (maximoArchivo==0))
            {
                maximo = 1;
                datos.idMaterialDidactico = Convert.ToInt32(1);

                maximoAutores = 1;
                datos.idAutor = Convert.ToInt32(1);

                maximoArchivo = 1;
                datos.idArchivo = Convert.ToInt32(1);

                return View(datos);
            }//fin del if para comprobar que los codigos sean igual a cero
            else
            {
                datos.idMaterialDidactico = Convert.ToInt32(maximo);
                datos.idAutor = Convert.ToInt32(maximoAutores);
                datos.idArchivo = Convert.ToInt32(maximoArchivo);
                return View(datos);
            }//fin del else

        }//fin del http get

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
                    // var archivoMaterial = db.tbArchivosMateDida;
                    // var autoresArchivo = db.tbAutoresMateDida;

                    byte[] data = new byte[material.archivo.ContentLength];
                    material.archivo.InputStream.Read(data, 0, material.archivo.ContentLength);

        ///////////////////////// Agrega el archivo /////////////////////////////////////////////////      

                    archivos.idArchivo = Convert.ToInt32(material.idArchivo);
                    archivos.archivo = data;


                    // material.contenido = material.archivo.ContentType;
                    // archivos.archivo = material.archivo.ContentType;

         //////////////////////  Nombre del Archivo ////////////////////////////////////////////////

                    materiales.nombreArch = material.archivo.FileName;

        ////////////////////// Datos del material didactico //////////////////////////////////////

                    int cod = Convert.ToInt32(material.idMaterialDidactico);
                    materiales.idMaterialDida = cod;
                    materiales.titulo = material.titulo;
                    materiales.fechaPubl = Convert.ToDateTime( material.fechaPublicacion);
                    materiales.ciudad = material.cuidad;
                    materiales.pais = material.pais;


        /////////////////////////////// Datos del el autor/////////////////////////////////////////

                    autores.nombre = material.autor;
                    autores.idAutor = Convert.ToInt32(material.idAutor);
                    
        /////////////////////////// agrega la informacion a las tablas ////////////////////////////
                    db.tbMaterialesDida.Add(materiales);
                    db.tbArchivos.Add(archivos);
                    db.tbAutores.Add(autores);
       ///////////////////////// Guarda los cambios //////////////////////////////////////////////         
                    db.SaveChanges();
                   
                   return RedirectToAction("Listado", "MaterialDidactico");
                    //return RedirectToAction("Index");// es que traia por defecto

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
        [HttpGet]
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using models = prgGestionDeCompañias.Models;

namespace prgGestionDeCompañias.Controllers
{
    public class EmpresaController : Controller
    {

 //********************* GET: Empresa************************************************
        public ActionResult Index()
        {
            BDPortafolioUcrContext dbContext = new BDPortafolioUcrContext();
            //realizo la consulta
            var consulta = from datos in dbContext.tbEmpresas
                           orderby datos.idEmpresa ascending
                           select datos;
            //se crea la una coleccion de elementos

            var consultaDireccion = from datos in dbContext.tbDirecciones
                                orderby datos.idDireccion ascending
                                select datos;

            var consultaTelefono = from datos in dbContext.tbTelefonos
                                    orderby datos.idTelefono ascending
                                    select datos;

            var consultaCorreo = from datos in dbContext.tbCorreos
                                    orderby datos.idCorreo ascending
                                    select datos;

            IEnumerable<tbEmpresas> empresas = consulta.ToList();
            IEnumerable<tbDirecciones> direcciones = consultaDireccion.ToList();
            IEnumerable<tbTelefonos> telfono = consultaTelefono.ToList();
            IEnumerable<tbCorreos> correos = consultaCorreo.ToList();
            return View();
        }

//************************** GET: Empresa/Details/5*****************************************
        public ActionResult Details(int id)
        {
            return View();
        }

//************************** GET: Empresa/Create************************************************
        [HttpGet]
        public ActionResult AgregarEmpresa()
        {
            BDPortafolioUcrContext db = new BDPortafolioUcrContext();
            Models.AgregarEmpresasModel datos = new Models.AgregarEmpresasModel();

            tbEmpresas datos0 = new tbEmpresas();
            tbDirecciones datos1 = new tbDirecciones();
            tbTelefonos datos2 = new tbTelefonos();
            tbCorreos datos3 = new tbCorreos();

            var maximo = ((from codigo in db.tbEmpresas select (int?)codigo.idEmpresa).Max()) + 1;
            var maximoDireccion = ((from codigo in db.tbDirecciones select (int?)codigo.idDireccion).Max()) + 1;
            var maximoTelefono = ((from codigo in db.tbTelefonos select (int?)codigo.idTelefono).Max()) + 1;
            var maximoCorreo = ((from codigo in db.tbCorreos select (int?)codigo.idCorreo).Max()) + 1;
            if ((maximo == 0) && (maximoDireccion == 0) && (maximoTelefono == 0) && (maximoCorreo == 0))
            {
                maximo = 1;
                datos.idEmpresa = Convert.ToInt32(1);

                maximoDireccion = 1;
                datos.idDireccion = Convert.ToInt32(1);

                maximoTelefono = 1;
                datos.idTelefono = Convert.ToInt32(1);

                maximoCorreo = 1;
                datos.idCorreo = Convert.ToInt32(1);
                return View();
            }
            else
            {
                datos.idEmpresa = Convert.ToInt32(maximo);
                datos.idDireccion = Convert.ToInt32(maximoDireccion);
                datos.idTelefono = Convert.ToInt32(maximoTelefono);
                datos.idCorreo = Convert.ToInt32(maximoCorreo);
                return View(datos);
            }
        }

//*************************** POST: Empresa/Create***************************************
        [HttpPost]
        public ActionResult AgregarEmpresa(models.AgregarEmpresasModel empresa)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BDPortafolioUcrContext())
                {

                    var empresas = db.tbEmpresas.Create();
                    var direcciones = db.tbDirecciones.Create();
                    var telefonos = db.tbTelefonos.Create();
                    var correos = db.tbCorreos.Create();

                   // byte[] data = new byte[empresa.foto.ContentLength];
                    //empresa.foto.InputStream.Read(data, 0, empresa.foto.ContentLength);

//********************** Datos de la Empresa*****************************************************

                    int cod = Convert.ToInt32(empresa.idEmpresa);
                    empresas.idEmpresa = cod;
                    empresas.nombre = empresa.nombre;
                    empresas.descripcionGene = empresa.descripcionGene;

                    int codD = Convert.ToInt32(empresa.idDireccion);
                    direcciones.idDireccion = codD;
                    direcciones.tipoPersona = empresa.tipoPersona;

                    int idD=Convert.ToInt32(empresa.idPersona);
                    direcciones.idPersona = idD;
                    direcciones.direccion = empresa.direccion;
                    direcciones.provincia = empresa.provincia;
                    direcciones.canton = empresa.canton;
                    direcciones.distrito = empresa.distrito;

                    int codT=Convert.ToInt32(empresa.idTelefono);
                    telefonos.idTelefono = codT;
                    telefonos.telefono = empresa.telefono;

                    int idT=Convert.ToInt32(empresa.idPersona);
                    telefonos.idPersona = idT;
                    telefonos.tipoPers = empresa.tipoPersona;

                   int codC= Convert.ToInt32(empresa.idCorreo);
                   correos.idCorreo = codC;

                   int idP=  Convert.ToInt32(empresa.idPersona);
                   correos.idPersona = idP;
                   correos.tipoPersona = empresa.tipoPersona;
                   correos.correo = empresa.correo;

//************************* agrega la informacion a las tablas***************************************
                  //  db.tbEmpresas.Add(empresas);
                    db.tbDirecciones.Add(direcciones);
                    db.tbTelefonos.Add(telefonos);
                    db.tbCorreos.Add(correos);

                    db.SaveChanges();

                    return RedirectToAction("Agregar Empresa", "Empresa");
                }//fin del using
            }//fin del if valid

            else
            {
                ModelState.AddModelError("", "El registro fue incorrecto");
            }

            return View();

        }//Fin del Metodo

//************************** GET: Empresa/Edit/5************************************************
        public ActionResult Edit(int id)
        {
            return View();
        }

//***************** POST: Empresa/Edit/5*****************************************
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

//*********** GET: Empresa/Delete/5******************************************
        public ActionResult Delete(int id)
        {
            return View();
        }

//********************** POST: Empresa/Delete/5*****************************
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

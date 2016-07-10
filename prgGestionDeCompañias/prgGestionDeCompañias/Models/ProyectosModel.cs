using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//Biblioteca que permite validar el modelo
using System.Globalization;
using System.Web;
//Biblioteca de configuracion del uso de varios idiomas

namespace prgGestionDeCompañias.Models
{
    public class RegistrarProyecto
    {
        [Required]//valida la entrada de datos al campo
        [Display(Name = "Codigo del Proyecto:")]
        public int idProyecto { get; set; }

        [Required] //entra en validacion el campo
        //le indico que es un string de 100, y ademas no le permito caracteres extraños
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Caracteres inválidos.")]
        [StringLength(100)]
        [Display(Name = "Nombre del Proyecto:")]
        public string nombre { get; set; }

        [Required] //entra en validacion el campo
        //le indico que es un string de 100, y ademas no le permito caracteres extraños
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Caracteres inválidos.")]
        [StringLength(100)]
        [Display(Name = "Descripción:")]
        public string descripcion { get; set; }

        [Required] //entra en validacion el campo
        //le indico que es un string de 100, y ademas no le permito caracteres extraños
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Caracteres inválidos.")]
        [StringLength(100)]
        [Display(Name = "Estado:")]
        public string estado { get; set; }

        [Required] //entra en validacion el campo
        //le indico que es un string de 100, y ademas no le permito caracteres extraños
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Caracteres inválidos.")]
        [StringLength(100)]
        [Display(Name = "Tipo:")]
        public string tipo { get; set; }

        //[Required]
       // [Display(Name = "Información: ")]
        public HttpPostedFileBase informacion { get; set; }
        //public byte[] informacion { get; set; }

        //[Required] //entra en validacion el campo
        ////le indico que es un string de 100, y ademas no le permito caracteres extraños
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Caracteres inválidos.")]
        //[StringLength(100)]
        //[Display(Name = "Nombre del Documento:")]
        //public string nombreDocumento { get; set; }
    }
}

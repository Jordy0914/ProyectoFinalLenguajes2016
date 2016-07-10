using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;// permite realizar validaciones a nuestra clase a nivel del models
using System.Globalization;//biblioteca de configuracion del uso de varios idiomas
using System.Web;

namespace prgGestionDeCompañias.Models
{
    public class AgregarMaterialDidactico
    {

        [Required]//valida la entrada de datos al campo
       
         // [StringLength(5)]
        [Editable(allowEdit: false)]
        [Display(Name = "Codigo del Material")]
        public int idMaterialDidactico { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Caracter invalido")]
        [Display(Name = "Titulo")]
        public string titulo { get; set; }

        [Display(Name = "Codigo del Autor")]
        public int idAutor { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Caracter invalido")]
        [Display(Name = "Autor")]
        public string autor { get; set; }

        [Required]
        [StringLength(100)]
        // [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Caracter invalido")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Fecha de Publicacion")]
        public string fechaPublicacion { get; set; }


        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Caracter invalido")]
        [Display(Name = "Cuidad")]
        public string cuidad { get; set; }


        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Caracter invalido")]
        [Display(Name = "Pais")]
        public string pais { get; set; }

        [Display(Name = "Codigo del Archivo")]
        public int idArchivo { get; set; }

        [Required]
        [Display(Name = "Archivo")]
        public HttpPostedFileBase archivo { get; set; }
        public string nombreArchivo { get; set; }


        public byte[] manual { get; set; }
        public string contenido { get; set; }


       


    }//fin de la clase Registrar Material Didactico



    public class ModificarMaterialDidactico
    {
        [Required]//valida la entrada de datos al campo
                  //  [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Caracter invalido")]
                  // [StringLength(5)]
        [Display(Name = "Codigo")]
        public int idMaterialDidactico { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Nombre del Archivo")]
        public string nombreArchivo { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Titulo")]
        public string titulo { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Caracter invalido")]
        [Display(Name = "Fecha de Publicacion")]//es lo que sale en la pagina web como un label
        public string fechaPublicacion { get; set; }


        [Required]
        [StringLength(100)]
        [Display(Name = "Cuidad")]
        public string cuidad { get; set; }


        [Required]//indica que este valor es requerido y no debe de quedar vacio
        [StringLength(100)]//indica el maximo de caracteres
        [Display(Name = "Pais")]
        public string pais { get; set; }


    }//fin de la clase modificar material didactico


    public class ConsultarMaterialDidactico
    {


        [Required]//valida la entrada de datos al campo
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Caracter invalido")]
        [StringLength(5)]
        [Display(Name = "Codigo")]//es lo que sale en la pagina web como un label
        public int idMaterialDidactico { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Nombre del Archivo")]//es lo que sale en la pagina web como un label
        public string nombreArchivo { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Titulo")]//es lo que sale en la pagina web como un label
        public string titulo { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Caracter invalido")]
        [Display(Name = "Fecha de Publicacion")]//es lo que sale en la pagina web como un label
        public string fechaPublicacion { get; set; }


        [Required]
        [StringLength(100)]
        [Display(Name = "Cuidad")]//es lo que sale en la pagina web como un label
        public string cuidad { get; set; }


        [Required]//indica que este valor es requerido y no debe de quedar vacio
        [StringLength(100)]//indica el maximo de caracteres
        [Display(Name = "Pais")]//es lo que sale en la pagina web como un label
        public string pais { get; set; }

    }//fin de la clase consultar material didactico


}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Globalization;


namespace prgGestionDeCompañias.Models
{
    public class AgregarEmpresas
    {
        [Required]
        [Display(Name = "Codigo")]
        public int idEmpresa { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "Descripción")]
        public string descripcionGene { get; set; }

        [Display(Name = "Logo de la empresa")]
        public HttpPostedFileBase logo { get; set; }

        [Required]
        [Display(Name = "Codigo Direccion")]
        public int idDireccion { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "Tipo Persona")]
        public string tipoPersona { get; set; }

        //[Required]
        //[Display(Name = "Codigo Persona")]
        //public int idPersona { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "Dirección")]
        public string direccion { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Provincia")]
        public string provincia { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Cantón")]
        public string canton { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Distrito")]
        public string distrito { get; set; }

        [Required]
        [Display(Name = "Codigo Telefono")]
        public int idTelefono { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Telefono")]
        public string telefono { get; set; }

        /*
        [Required]
        [Display(Name = "Codigo Persona")]
        public int idPersona { get; set; }
        [Required]
        [StringLength(1000)]
        [Display(Name = "Tipo Persona")]
        public string tipoPersona { get; set; }
        */
        [Required]
        [Display(Name = "Codigo E-mail")]
        public int idCorreo { get; set; }
        /*
        [Required]
        [Display(Name = "Codigo Persona")]
        public int idPersona { get; set; }
         [StringLength(1000)]
        [Display(Name = "Tipo Persona")]
        public string tipoPersona { get; set; }
        */

        [Required]
        [StringLength(100)]
        [Display(Name = "E-mail")]
        public string correo { get; set; }
    }//Fin de Agregar EmpresaModel

    //######################################################################################
    public class ModificarEmpresasModel
    {

        [Required]
        [StringLength(100)]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "Descripción")]
        public string descripcionGene { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "Dirección")]
        public string direccion { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Provincia")]
        public string provincia { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Cantón")]
        public string canton { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Distrito")]
        public string distrito { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Telefono")]
        public string telefono { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "E-mail")]
        public string correo { get; set; }
    }//Fin de modificar
}

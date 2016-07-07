using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;// permite realizar validaciones a nuestra clase a nivel del models
using System.Globalization;//biblioteca de configuracion del uso de varios idiomas


namespace prgGestionDeCompañias.Models
{
    public class AgregarEmpresasModel
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

        [Required]
        [StringLength(1000)]
        [Display(Name = "Dirección")]
        public string direccion { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "Provincia")]
        public string provincia { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "Cantón")]
        public string canton { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "Distrito")]
        public string distrito { get; set; }


        [Required]
        [StringLength(1000)]
        [Display(Name = "Telefono")]
        public int telefono { get; set; }

        [Required]
        [StringLength(1000)]
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
        [StringLength(1000)]
        [Display(Name = "Provincia")]
        public string provincia { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "Cantón")]
        public string canton { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "Distrito")]
        public string distrito { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "Telefono")]
        public int telefono { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "E-mail")]
        public string correo { get; set; }
    }//Fin de modificar
}
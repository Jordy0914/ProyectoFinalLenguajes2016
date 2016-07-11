using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace prgGestionDeCompañias.Models
{
    public class CapacitacionModel
    {
        [Required]
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }


        [Required]
        [StringLength(1000)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }


        [Display(Name = "Ubicación")]
        public string Ubicacion { get; set; }


        [Required]
        [Display(Name = "Codigo de Persona")]
        public string IdPersona { get; set; }


        [Required]
        [StringLength(1000)]
        [Display(Name = "Fecha Inicio")]
        public System.DateTime FechaInic { get; set; }


        [Required]
        [StringLength(1000)]
        [Display(Name = "Fecha Final")]
        public System.DateTime FechaFin { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Inversion")]
        public int Inversion { get; set; }


        [Required]
        [StringLength(100)]
        [Display(Name = "Tipo de Certificado")]
        public string TipoCertificado { get; set; }

    }
}
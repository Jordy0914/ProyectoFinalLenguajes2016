using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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


        [Display(Name = "Logo de la empresa")]
        public string Ubicacion { get; set; }


        [Required]
        [Display(Name = "Codigo Direccion")]
        public string IdPersona { get; set; }


        [Required]
        [StringLength(1000)]
        [Display(Name = "Tipo Persona")]
        public System.DateTime FechaInic { get; set; }


        [Required]
        [StringLength(1000)]
        [Display(Name = "Dirección")]
        public System.DateTime FechaFin { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Provincia")]
        public int Inversion { get; set; }


        [Required]
        [StringLength(100)]
        [Display(Name = "Cantón")]
        public string TipoCertificado { get; set; }

    }
}
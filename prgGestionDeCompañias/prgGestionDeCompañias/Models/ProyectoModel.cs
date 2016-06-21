using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace prgGestionDeCompañias.Models
{
    public class ProyectoModel
    {
        [Required] 
        [StringLength(5)]
        [Display(Name = "Identificación de la Empresa:")]
        public int idEmpresa { get; set; }

        [Required] 
        [StringLength(5)]
        [Display(Name = "Identificación del Proyecto:")]
        public int idProyecto { get; set; }

        [Required]
        [Display(Name = "Horas Invertidas:")]
        public int horasInvertidas { get; set; }
    }
}

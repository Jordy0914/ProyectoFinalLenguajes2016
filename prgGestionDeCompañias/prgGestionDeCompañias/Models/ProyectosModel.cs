using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace prgGestionDeCompañias.Models
{
    public class RegistrarProyectos
    {
        [Required]
        [StringLength(5)]
        [Display(Name = "Identificación del Proyecto:")]
        public int idProyecto { get; set; }

        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Caracteres inválidos.")]
        [StringLength(100)]
        [Display(Name = "Nombre del Proyecto:")]
        public string nombre { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Caracteres inválidos.")]
        [StringLength(100)]
        [Display(Name = "Descripción:")]
        public string descripcion { get; set; }

        [Required]
        [StringLength(11)] 
        [Display(Name = "Estado:")]
        public string estado { get; set; }

        [Required]
        [StringLength(11)]
        [Display(Name = "Tipo:")]
        public string tipo { get; set; }

        [Display(Name = "Información:")]
        public byte[] informacion { get; set; }
    }
}

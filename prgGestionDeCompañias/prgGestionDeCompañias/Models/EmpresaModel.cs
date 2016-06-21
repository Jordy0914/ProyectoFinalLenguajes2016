using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; 
using System.Globalization;

namespace prgGestionDeCompañias.Models
{
    public class EmpresaModel
    {
        [Required] 
        [StringLength(5)]
        [Display(Name = "Identificación de la Empresa")]
        public int idEmpresa { get; set; }

        [Required]
        [StringLength(100)]//Tamaño de la cadena
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Caracteres inválidos.")]
        [Display(Name = "Nombre de la Empresa:")]
        public string nombre { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Caracteres inválidos.")]
        [StringLength(100)]
        [Display(Name = "Descripción General:")]
        public string descripcionGene { get; set; }

        public byte[] foto { get; set; }
    }
}

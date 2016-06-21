using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //Permite realizar validaciones a nuestra clase a nivel del models.
using System.Globalization; //Biblioteca de configuracion del uso de varios idiomas.

namespace prgGestionDeCompañias.Models
{
    public class EmpresaModel
    {
        [Required] //Valida la entrada de datos al campo
        [StringLength(5)]//Tamaño de la cadena
        [Display(Name = "Identificación de la Empresa")]
        public int idEmpresa { get; set; }

        [Required]
        [StringLength(100)]//Tamaño de la cadena
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,100}$", ErrorMessage = "Caracteres inválidos.")]
        [Display(Name = "Nombre de la Empresa:")]
        public string nombre { get; set; }
        public string descripcionGene { get; set; }
        public byte[] foto { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;// permite realizar validaciones a nuestra clase a nivel del models
using System.Globalization;//biblioteca de configuracion del uso de varios idiomas
using System.Web;
using System.Web.UI.WebControls;

namespace prgGestionDeCompañias.Models
{
    public class AgregarConveniosModels
    {
		[Required]
        [Display(Name = "idConvenio:")]
		public int idConvenio { get; set; }
		
		[Required]
		[StringLength(500)]
		[RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        [Display(Name = "Descripcion:")]
		public string descripcion { get; set; }
		

		[Required (ErrorMessage = "seleccione la fecha")]
        [Display(Name = "Fecha creacion")]
		public System.DateTime fechaCrea { get; set; }
		
		[Required (ErrorMessage = "seleccione el estado")]
        [StringLength(500)]
        [Display(Name = "Estado")]
		public string estado { get; set; }	
		
		
		
    }
}
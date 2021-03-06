//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prgGestionDeCompañias
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    public partial class tbConvenios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbConvenios()
        {
            this.tbEmpresas = new HashSet<tbEmpresas>();
        }

        [Required]
        [Display(Name = "idConvenio:")]
        public int idConvenio { get; set; }

        [Required]
        [StringLength(500)]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        [Display(Name = "Descripcion:")]
        public string descripcion { get; set; }


        [Required(ErrorMessage = "seleccione la fecha")]
        [Display(Name = "Fecha creacion")]
        public System.DateTime fechaCrea { get; set; }

        [Required(ErrorMessage = "seleccione el estado")]
        [StringLength(500)]
        [Display(Name = "Estado")]
        public string estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpresas> tbEmpresas { get; set; }
    }
}

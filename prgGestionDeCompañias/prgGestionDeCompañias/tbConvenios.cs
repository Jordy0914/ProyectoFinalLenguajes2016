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
    
    public partial class tbConvenios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbConvenios()
        {
            this.tbEmpresas = new HashSet<tbEmpresas>();
        }
    
        public int idConvenio { get; set; }
        public string descripcion { get; set; }
        public System.DateTime fechaCrea { get; set; }
        public string estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpresas> tbEmpresas { get; set; }
    }
}

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
    
    public partial class tbEspecialidadesPorExpe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbEspecialidadesPorExpe()
        {
            this.tbProfesores = new HashSet<tbProfesore>();
        }
    
        public int idEspecialidad { get; set; }
        public string nombre { get; set; }
        public int tiempoExpe { get; set; }
        public string area { get; set; }
        public string puesto { get; set; }
        public string tipoEmpresa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProfesore> tbProfesores { get; set; }
    }
}

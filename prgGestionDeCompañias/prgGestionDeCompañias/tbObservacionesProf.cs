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
    
    public partial class tbObservacionesProf
    {
        public int idObservacion { get; set; }
        public int idProfesor { get; set; }
        public string descripcion { get; set; }
        public string observador { get; set; }
        public System.DateTime fecha { get; set; }
    
        public virtual tbProfesores tbProfesores { get; set; }
    }
}

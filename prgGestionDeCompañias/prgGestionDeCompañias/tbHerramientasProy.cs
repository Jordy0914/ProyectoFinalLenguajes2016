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
    
    public partial class tbHerramientasProy
    {
        public int idProyecto { get; set; }
        public int idHerramienta { get; set; }
        public int horasInvertidas { get; set; }
    
        public virtual tbHerramienta tbHerramienta { get; set; }
        public virtual tbProyecto tbProyecto { get; set; }
    }
}

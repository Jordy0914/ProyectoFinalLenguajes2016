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
    
    public partial class tbEmpresas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbEmpresas()
        {
            this.tbBolsasEmpl = new HashSet<tbBolsasEmpl>();
            this.tbCorreos = new HashSet<tbCorreos>();
            this.tbDirecciones = new HashSet<tbDirecciones>();
            this.tbProyectosEmpresa = new HashSet<tbProyectosEmpresa>();
            this.tbPuestosProf = new HashSet<tbPuestosProf>();
            this.tbTelefonos = new HashSet<tbTelefonos>();
            this.tbCapacitaciones = new HashSet<tbCapacitaciones>();
            this.tbConvenios = new HashSet<tbConvenios>();
            this.tbMaterialesDida = new HashSet<tbMaterialesDida>();
        }
    
        public int idEmpresa { get; set; }
        public string nombre { get; set; }
        public string descripcionGene { get; set; }
        public byte[] foto { get; set; }
        public int idDireccion { get; set; }
        public string tipoPersona { get; set; }
        public string direccion { get; set; }
        public string provincia { get; set; }
        public string canton { get; set; }
        public string distrito { get; set; }
        public int idTelefono { get; set; }
        public string telefono { get; set; }
        public int idCorreo { get; set; }
        public int idPersona { get; set; }
        public string correo { get; set; }





        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbBolsasEmpl> tbBolsasEmpl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCorreos> tbCorreos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDirecciones> tbDirecciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProyectosEmpresa> tbProyectosEmpresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPuestosProf> tbPuestosProf { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTelefonos> tbTelefonos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCapacitaciones> tbCapacitaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbConvenios> tbConvenios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbMaterialesDida> tbMaterialesDida { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;

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

        [Display(Name = "Foto/Logo:")]
        public byte[] foto { get; set; }

        public int idDireccion { get; set; }
        public string tipoPersona { get; set; }
        public string direccion { get; set; }
        public string provincia { get; set; }
        public string canton { get; set; }
        public string distrito { get; set; }

        public int idTelefono { get; set; }
        public int telefono { get; set; }
        public int idPersona { get; set; }
        public string tipoPers { get; set; }

        public int idCorreo { get; set; }
        //public string tipoPersona { get; set; }
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

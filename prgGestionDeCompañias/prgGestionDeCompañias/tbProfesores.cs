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
    
    public partial class tbProfesores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbProfesores()
        {
            this.tbCorreos = new HashSet<tbCorreos>();
            this.tbCursosLibr = new HashSet<tbCursosLibr>();
            this.tbDirecciones = new HashSet<tbDirecciones>();
            this.tbEspecialidadesProf = new HashSet<tbEspecialidadesProf>();
            this.tbEstudiosProf = new HashSet<tbEstudiosProf>();
            this.tbObservacionesProf = new HashSet<tbObservacionesProf>();
            this.tbPeriodosLaboProf = new HashSet<tbPeriodosLaboProf>();
            this.tbProyectosEstu = new HashSet<tbProyectosEstu>();
            this.tbProyectosProf = new HashSet<tbProyectosProf>();
            this.tbPuestosProf = new HashSet<tbPuestosProf>();
            this.tbTelefonos = new HashSet<tbTelefonos>();
            this.tbTitulosProf = new HashSet<tbTitulosProf>();
            this.tbProyectos = new HashSet<tbProyectos>();
            this.tbExperienciasAcad = new HashSet<tbExperienciasAcad>();
            this.tbGruposCurs = new HashSet<tbGruposCurs>();
            this.tbProyectos1 = new HashSet<tbProyectos>();
        }
    
        public int idProfesor { get; set; }
        public string nombre { get; set; }
        public string apaellido1 { get; set; }
        public string apellido2 { get; set; }
        public string usuario { get; set; }
        public string genero { get; set; }
        public System.DateTime fechaNaci { get; set; }
        public string jornada { get; set; }
        public string estado { get; set; }
        public string identificacion { get; set; }
        public string tipoIden { get; set; }
        public byte[] foto { get; set; }
        public byte[] curriculum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCorreos> tbCorreos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCursosLibr> tbCursosLibr { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDirecciones> tbDirecciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEspecialidadesProf> tbEspecialidadesProf { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEstudiosProf> tbEstudiosProf { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbObservacionesProf> tbObservacionesProf { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPeriodosLaboProf> tbPeriodosLaboProf { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProyectosEstu> tbProyectosEstu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProyectosProf> tbProyectosProf { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPuestosProf> tbPuestosProf { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTelefonos> tbTelefonos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTitulosProf> tbTitulosProf { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProyectos> tbProyectos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbExperienciasAcad> tbExperienciasAcad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbGruposCurs> tbGruposCurs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProyectos> tbProyectos1 { get; set; }
    }
}

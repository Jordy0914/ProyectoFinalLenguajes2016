using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prgGestionDeCompañias.Models
{
    public class CapacitacionModels
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Ubicacion { get; set; }
        public string IdPersona { get; set; }
        public System.DateTime FechaInic { get; set; }
        public System.DateTime FechaFin { get; set; }
        public int Inversion { get; set; }
        public string TipoCertificado { get; set; }

    }
}



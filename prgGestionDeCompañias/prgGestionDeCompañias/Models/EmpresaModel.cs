using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prgGestionDeCompañias.Models
{
    public class EmpresaModel
    {

        public int idEmpresa { get; set; }
        public string nombre { get; set; }
        public string descripcionGene { get; set; }
        public byte[] foto { get; set; }
    }
}

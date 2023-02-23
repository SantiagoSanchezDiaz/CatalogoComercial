using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dominio
{
    public class Marca
    {
        [DisplayName("IdMarca")]
        public int Id { get; set; }

        [DisplayName("Marca")]
        public string Detalle { get; set; }
        public override string ToString()
        {
            return Detalle;
        }
    }
}

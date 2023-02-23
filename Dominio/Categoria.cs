using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        [DisplayName("IdCategoria")]
        public int Id { get; set; }

        [DisplayName("Categoría")]
        public string Detalle { get; set; }
        public override string ToString()
        {
            return Detalle;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public class Productos
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public int Activo { get; set; }

    }
}

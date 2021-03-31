using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBang.Entidades
{
    class Usuario
    {
        public String nombre { get; set; }
        public int edad { get; set; }
        public char tipoUSer { get; set; }
        public String user { get; set; }
        public String contraseña { get; set; }
        public Pedido pedido { get; set; }
    }
}

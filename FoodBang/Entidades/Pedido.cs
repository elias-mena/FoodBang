using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBang.Entidades
{
    class Pedido
    {
        public List<Comida> Orden { get; set; } = new List<Comida>();
    }
}

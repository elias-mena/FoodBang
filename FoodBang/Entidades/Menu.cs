using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBang.Entidades
{
    class Menu
    {
       
            public List<Comida> Menuu { get; set; } = new List<Comida>();
            public Dictionary<String, List<Comida>> categorias { get; set; }
        
    }
}

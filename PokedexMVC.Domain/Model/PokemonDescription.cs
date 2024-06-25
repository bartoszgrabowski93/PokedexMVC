using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Domain.Model
{
    public class PokemonDescription
    {
        public int Id { get; set; } 
        public string Description { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Category { get; set; }
        public int PokemonRef { get; set; }
        public Pokemon Pokemon { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Domain.Model
{
    public class PokemonEvolution
    {
        public int Id { get; set; }
        public Pokemon Pokemon { get; set; }
        public int PokemonRef{ get; set; }
        public Pokemon? PrevEvolution { get; set; }
        public int? PrevPokemonId { get; set; }

        public Pokemon? NextEvolution { get; set; }
        public int? NextPokemonId { get; set; }
    }
}

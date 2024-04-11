using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Domain.Model
{
    public class Moveset
    {
        public int Id { get; set; }
        public int PokemonRef { get; set; }
        public Pokemon Pokemon { get; set; }
        public virtual ICollection<Move> Moves { get; set; }
    }
}

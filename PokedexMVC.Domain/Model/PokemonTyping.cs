using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Domain.Model
{
    public class PokemonTyping
    {
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
        public int TypingId { get; set;}
        public Typing Typing { get; set; }
    }
}

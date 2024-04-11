using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Domain.Model
{
    public class Typing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  ICollection<PokemonTyping> PokemonTypings { get; set;}
        
    }
}

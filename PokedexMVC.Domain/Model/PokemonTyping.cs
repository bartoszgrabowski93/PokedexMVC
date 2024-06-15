using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Domain.Model
{
    public class PokemonTyping
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Typing PrimaryType { get; set; }
        public int PrimaryTypeId { get; set; }
        public Typing? SecondaryType { get; set; }
        public int? SecondaryTypeId { get; set; } 
        public ICollection<Pokemon> Pokemons { get; set; }
    }
}

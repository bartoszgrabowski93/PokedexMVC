using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Domain.Model
{
    public class TypeCombination
    {
        public int Id { get; set; } 
        public BasicType PrimaryType { get; set; }
        public BasicType SecondaryType { get; set; }
        public virtual ICollection<Pokemon> Pokemons { get; set; }
    }
}

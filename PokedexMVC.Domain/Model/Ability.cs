using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Domain.Model
{
    public class Ability
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public AbilityEffect? AbEffect { get; set; }
        public ICollection<PokemonAbility> PokemonAbilities { get; set; }
       
    }
}

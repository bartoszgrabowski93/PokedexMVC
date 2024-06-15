using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Domain.Model
{
    public class PokemonAbilities
    {
        public int Id { get; set; }
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
        
        public Ability PrimaryAbility { get; set; }
        public int PrimaryAbilityId { get; set; }
        public Ability? SecondaryAbility { get; set; }
        public int? SecondaryAbilityId { get; set; }
        public Ability? HiddenAbility { get; set; }
        public int? HiddenAbilityId { get; set; }
    }
}

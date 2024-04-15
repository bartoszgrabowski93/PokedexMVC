using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Domain.Model
{
    public class Pokemon
    {
        public int Id { get; set; }
        public int PokedexNumber { get; set; }
        public string Name { get; set; } 
        public int PrimaryTypeId { get; set; }
        
        public virtual Typing PrimaryType { get; set; }
        public int? SecondaryTypeId { get; set; }
        public virtual Typing? SecondaryType { get; set; }
        public Moveset Moveset { get; set; }
        public PokemonDescription PokemonDescription { get; set; }
        public Statistic Statistic { get; set; }
        

    }
}

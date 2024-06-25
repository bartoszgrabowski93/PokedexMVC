using PokedexMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Application.Viewmodels.Pokemon
{
    public class PokemonDetailsVm
    {
        public int Id { get; set; }
        public byte[] Sprite { get; set; }
        public int PokemonNumber { get; set; }
        public string Name { get; set; }
        public Typing PrimaryType { get; set; }
        public Typing SecondaryType { get; set; }
        public string Description { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Category { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }

    }
}

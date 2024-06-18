﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Domain.Model
{
    public class PokemonAbility   
    {
        public int PokemonRef { get; set; }
        public Pokemon Pokemon { get; set; }
        public int AbilityRef { get; set; }
        public Ability Ability { get; set; }
    }
}
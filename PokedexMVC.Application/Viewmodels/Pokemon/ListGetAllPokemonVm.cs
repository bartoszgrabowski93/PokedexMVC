﻿using PokedexMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Application.Viewmodels.Pokemon
{
    public class ListGetAllPokemonVm
    {
        public List<GetAllPokemonVm> Pokemons { get; set; }
        public int Count { get; set; }
        
    }
}

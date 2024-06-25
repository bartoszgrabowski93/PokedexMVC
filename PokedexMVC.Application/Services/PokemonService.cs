using PokedexMVC.Application.Interfaces;
using PokedexMVC.Application.Viewmodels.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Application.Services
{
    public class PokemonService : IPokemonService
    {
        public int AddPokemon(NewPokemonVm pokemon)
        {
            throw new NotImplementedException();
        }

        public ListGetAllPokemonVm GetAllPokemon()
        {
            throw new NotImplementedException();
        }

        public PokemonDetailsVm GetPokemonDetails(int pokemonId)
        {
            throw new NotImplementedException();
        }
    }
}

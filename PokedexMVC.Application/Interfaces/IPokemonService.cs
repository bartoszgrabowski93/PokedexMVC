using PokedexMVC.Application.Viewmodels.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Application.Interfaces
{
    public interface IPokemonService
    {
        ListGetAllPokemonVm GetAllPokemon();
        int AddPokemon(NewPokemonVm pokemon);
        PokemonDetailsVm GetPokemonDetails(int pokemonId);
    }
}

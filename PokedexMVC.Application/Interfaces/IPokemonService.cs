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
        ListGetAllPokemonVm GetAllPokemonForList(int pageSize, int pageNumber, string searchString);
        int AddPokemon(NewPokemonVm pokemon);
        PokemonDetailsVm GetPokemonDetails(int pokemonId);
    }
}

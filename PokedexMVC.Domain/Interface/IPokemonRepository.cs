using PokedexMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Domain.Interface
{
    public interface IPokemonRepository
    {
        int AddPokemon(Pokemon pokemon);
        void DeletePokemon(int pokemonId);
        IQueryable<Pokemon> GetAllPokemons();
        Pokemon GetPokemon(int pokemonId);
            
       
    }
}

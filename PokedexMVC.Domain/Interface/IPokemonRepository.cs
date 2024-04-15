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
        Pokemon GetPokemonById(int pokemonId);
        Pokemon GetPokemonByPokdexNumber(int pokemonNumber);
        
       
    }
}

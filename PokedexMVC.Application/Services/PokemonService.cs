using PokedexMVC.Application.Interfaces;
using PokedexMVC.Application.Viewmodels.Pokemon;
using PokedexMVC.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Application.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly IPokemonRepository _pokemonRepo;
        public int AddPokemon(NewPokemonVm pokemon)
        {
            throw new NotImplementedException();
        }

        public ListGetAllPokemonVm GetAllPokemonForList()
        {
            var pokemons = _pokemonRepo.GetAllPokemons();
            ListGetAllPokemonVm result = new ListGetAllPokemonVm();
            result.Pokemons = new List<GetAllPokemonVm>();
            foreach (var pokemon in pokemons)
            {
                var pokemonVm = new GetAllPokemonVm()
                { 
                    Id = pokemon.Id,
                    Name = pokemon.Name,
                    PokemonNumber = pokemon.PokedexNumber
                };
                result.Pokemons.Add(pokemonVm);
            }
            result.Count = result.Pokemons.Count;
            return result;
        }

        public PokemonDetailsVm GetPokemonDetails(int pokemonId)
        {
            throw new NotImplementedException();
        }
    }
}

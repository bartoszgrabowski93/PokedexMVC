using PokedexMVC.Domain.Interface;
using PokedexMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Infrastructure.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly Context _context;
        public PokemonRepository(Context context)
        {
            _context = context;
        }

        public int AddPokemon(Pokemon pokemon)
        {
            _context.Pokemons.Add(pokemon);
            _context.SaveChanges();
            return pokemon.Id;
        }

        public void DeletePokemon(int pokemonId)
        {
            var pokemon = _context.Pokemons.Find(pokemonId);
            if (pokemon != null)
            {
                _context.Pokemons.Remove(pokemon);
                _context.SaveChanges();
            }else
            {
                Console.WriteLine("Nie znaleziono pokemona o danym numerze.");
            }
        }

        public Pokemon GetPokemon(int pokemonId) 
        {
            var pokemon = _context.Pokemons.FirstOrDefault(i => i.Id == pokemonId);           
            return pokemon;
        }

        public Pokemon GetPokemonByPokdexNumber(int pokemonNumber)
        {
            var pokemon = _context.Pokemons.FirstOrDefault(i => i.PokedexNumber == pokemonNumber);
            return pokemon;

        }

        public IQueryable<Pokemon> GetAllPokemons()
        
        {
            IQueryable<Pokemon> results = _context.Pokemons;
            return results;
        }

    }
}

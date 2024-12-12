using AutoMapper;
using AutoMapper.QueryableExtensions;
using PokedexMVC.Application.Interfaces;
using PokedexMVC.Application.Viewmodels.Pokemon;
using PokedexMVC.Domain.Interface;
using PokedexMVC.Domain.Model;
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
        private readonly IMapper _mapper;

        public PokemonService(IPokemonRepository pokemonRepo, IMapper mapper)
        {
            _pokemonRepo = pokemonRepo;
            _mapper = mapper;
        }
        public int AddPokemon(NewPokemonVm pokemon)
        {
            var newPokemon = new Pokemon();
            newPokemon.Id = pokemon.Id;
            newPokemon.PokedexNumber = pokemon.PokedexNumber;
            newPokemon.Name = pokemon.Name;
            _pokemonRepo.AddPokemon(newPokemon);
            return newPokemon.Id;                

        }

        public ListGetAllPokemonVm GetAllPokemonForList(int pageSize, int pageNumber, string searchString)
        {
            var pokemons = _pokemonRepo.GetAllPokemons().Where(p => p.Name.StartsWith(searchString))
                .ProjectTo<GetAllPokemonVm>(_mapper.ConfigurationProvider).ToList();
            var pokemonsToShow = pokemons.Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList();
            var pokemonList = new ListGetAllPokemonVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNumber,
                SearchString = searchString,
                Pokemons = pokemonsToShow,
                Count = pokemons.Count
            };
            return pokemonList;            
        }

        public NewPokemonVm GetPokemonForEdit(int pokemonId)
        {
            var pokemon = _pokemonRepo.GetPokemonById(pokemonId);
            var pokemonVm = _mapper.Map<NewPokemonVm>(pokemon);
            return pokemonVm;
        }

        public void UpdatePokemon(NewPokemonVm newPokemon)
        {
            var pokemon = _mapper.Map<Pokemon>(newPokemon);
            _pokemonRepo.UpdatePokemon(pokemon);
        }

        public PokemonDetailsVm GetPokemonDetails(int pokemonId)
        {
            var pokemon = _pokemonRepo.GetPokemonById(pokemonId);
            var pokemonVm = new PokemonDetailsVm();
            pokemonVm.Id = pokemon.Id;
            pokemonVm.PokemonNumber = pokemon.PokedexNumber;
            pokemonVm.Name = pokemon.Name;
            pokemonVm.Typing = pokemon.TypeCombo;
            // pokemonVm.Sprite = pokemon.Sprite;
                      
            return pokemonVm;   
                        
        }

        public void DeletePokemon(int pokemonId)
        {
            var pokemonToDelete = _pokemonRepo.GetPokemonById(pokemonId);
            if (pokemonToDelete != null)
            {
                _pokemonRepo.DeletePokemon(pokemonToDelete.Id);
            }
        }
      
    }
}

using AutoMapper;
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
            newPokemon.PokedexNumber = pokemon.PokemonNumber;
            newPokemon.Name = pokemon.Name;
            _pokemonRepo.AddPokemon(newPokemon);
            return newPokemon.Id;                

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
            var pokemon = _pokemonRepo.GetPokemon(pokemonId);
            var pokemonVm = new PokemonDetailsVm();
            pokemonVm.Id = pokemon.Id;
            pokemonVm.PokemonNumber = pokemon.PokedexNumber;
            pokemonVm.Name = pokemon.Name;
            pokemonVm.PrimaryType = pokemon.Typing;
            pokemonVm.Sprite = pokemon.Sprite;
            var pokemonDes = pokemon.PokemonDescription;
            pokemonVm.Description = pokemonDes.Description;
            pokemonVm.Height = pokemonDes.Height;
            pokemonVm.Weight = pokemonDes.Weight;
            pokemonVm.Category = pokemonDes.Category;
            var pokemonStats = pokemon.Statistic;
            pokemonVm.Health = pokemonStats.Health;
            pokemonVm.Attack = pokemonStats.Attack;
            pokemonVm.SpecialAttack = pokemonStats.SpecialAttack;
            pokemonVm.Defense = pokemonStats.Defense;
            pokemonVm.SpecialDefense = pokemonStats.SpecialDefense;
            pokemonVm.Speed = pokemonStats.Speed;            
            return pokemonVm;   
                        
        }

    }
}

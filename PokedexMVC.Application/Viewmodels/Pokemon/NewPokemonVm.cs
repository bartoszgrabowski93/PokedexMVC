using AutoMapper;
using FluentValidation;
using PokedexMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Application.Viewmodels.Pokemon
{
    public class NewPokemonVm : IMapFrom<PokedexMVC.Domain.Model.Pokemon>
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("National Pokedex Number")]
        [Required]
        public int PokemonNumber { get; set; }
        public string Name { get; set; }

        public void Mapping (Profile profile)
        {
            profile.CreateMap<NewPokemonVm, PokedexMVC.Domain.Model.Pokemon>();
        }
    }

    public class NewPokemonValidaton : AbstractValidator<NewPokemonVm>
    {
        public NewPokemonValidaton()
        {
            RuleFor(x => x.Name).NotNull();
            RuleFor(x => x.Name).MaximumLength(255);
            RuleFor(x => x.PokemonNumber).ExclusiveBetween(1, 1100);
        }
    }
}


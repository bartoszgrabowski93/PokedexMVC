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
        
        public int Id { get; set; }
        public int PokedexNumber { get; set; }
        public string Name { get; set; }

        public void Mapping (Profile profile)
        {
            profile.CreateMap<NewPokemonVm, PokedexMVC.Domain.Model.Pokemon>().ReverseMap();
        }
    }

    public class NewPokemonValidaton : AbstractValidator<NewPokemonVm>
    {
        public NewPokemonValidaton()
        {
            RuleFor(x => x.Name).NotNull();
            RuleFor(x => x.Name).MaximumLength(255);
            RuleFor(x => x.PokedexNumber).ExclusiveBetween(1, 1100);
        }
    }

    public class NewPokemonValidator : AbstractValidator<NewPokemonVm>
    {
        public NewPokemonValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.PokedexNumber).NotNull();
            RuleFor(x => x.PokedexNumber).InclusiveBetween(1, 1100);
            RuleFor(x => x.Name).NotNull();
            RuleFor(x => x.Name).MaximumLength(255);
        }
    }
}


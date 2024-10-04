using FluentValidation;
using PokedexMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Application.Viewmodels.Pokemon
{
    public class NewPokemonVm 
    {
        public int Id { get; set; }
        public int PokemonNumber { get; set; }
        public string Name { get; set; }
    }

    public class NewPokemonValidator : AbstractValidator<NewPokemonVm>
    {
        public NewPokemonValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.PokemonNumber).NotNull();
            RuleFor(x => x.PokemonNumber).InclusiveBetween(1, 1100);
            RuleFor(x => x.Name).NotNull();
            RuleFor(x => x.Name).MaximumLength(255);
        }
    }
}

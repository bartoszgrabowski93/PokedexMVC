
//using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using PokedexMVC.Application.Interfaces;
using PokedexMVC.Application.Services;
using PokedexMVC.Application.Viewmodels.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IPokemonService, PokemonService>();
            services.AddTransient<ITypingService, TypingService>();
            //services.AddTransient<IValidator<NewPokemonVm>, NewPokemonValidaton>();
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());          
            return services;
        }
    }
}

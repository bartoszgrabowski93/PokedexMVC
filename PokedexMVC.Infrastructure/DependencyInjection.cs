using Microsoft.Extensions.DependencyInjection;
using PokedexMVC.Domain.Interface;
using PokedexMVC.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IPokemonRepository, PokemonRepository>();
            services.AddTransient<ITypingRepository, TypingRepository>();             
            return services;
        }
    }
}

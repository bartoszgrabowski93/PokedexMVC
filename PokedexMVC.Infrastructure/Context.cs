using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PokedexMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Effect> Effects { get; set; }
        public DbSet<Move> Moves { get; set; }
        public DbSet<Moveset> Movesets { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonDescription> PokemonDescriptions { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<Typing> Typings { get; set; }

        public Context(DbContextOptions options) : base(options) 
        { 

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Pokemon>()
                .HasOne(a => a.Moveset).WithOne(b => b.Pokemon)
                .HasForeignKey<Moveset>(e => e.PokemonRef);

            builder.Entity<Pokemon>()
                .HasOne(a => a.PokemonDescription).WithOne(b => b.Pokemon)
                .HasForeignKey<PokemonDescription>(e => e.PokemonRef);

            builder.Entity<Pokemon>()
               .HasOne(a => a.Statistic).WithOne(b => b.Pokemon)
               .HasForeignKey<Statistic>(e => e.PokemonRef);
           
        }
    }
    
}

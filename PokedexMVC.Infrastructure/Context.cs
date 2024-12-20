﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PokedexMVC.Domain.Model;

namespace PokedexMVC.Infrastructure
{
    public class Context : IdentityDbContext<IdentityUser>
    {
        public DbSet<Ability> Abilities { get; set; }       
        public DbSet<BasicType> BasicTypes { get; set; }
        public DbSet<Move> Moves { get; set; }
        public DbSet<Moveset> Movesets { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonAbility> PokemonAbility { get; set; }
        public DbSet<PokemonDescription> PokemonDescriptions { get; set; }    
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<StatusEffect> Effects { get; set; }
        public DbSet<TypeCharacteristics> TypeCharacteristics { get; set; }
        public DbSet<TypeCombination> TypeCombinations { get; set; }

        public Context(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Relacje jeden - jeden
            builder.Entity<Pokemon>()
                .HasOne(a => a.Moveset).WithOne(b => b.Pokemon)
                .HasForeignKey<Moveset>(e => e.PokemonRef);

            builder.Entity<Pokemon>()
                .HasOne(a => a.PokemonDescription).WithOne(b => b.Pokemon)
                .HasForeignKey<PokemonDescription>(e => e.PokemonRef);

            builder.Entity<Pokemon>()
               .HasOne(a => a.Statistic).WithOne(b => b.Pokemon)
               .HasForeignKey<Statistic>(e => e.PokemonRef);

            builder.Entity<BasicType>()
                .HasOne(bt => bt.TypeCharacteristics).WithOne(tc => tc.Type)
                .HasForeignKey<TypeCharacteristics>(tc => tc.TypeRef);
                            

            // Relacja Wiele-Wiele
            builder.Entity<PokemonAbility>()
                .HasKey(pa => new { pa.PokemonRef, pa.AbilityRef });

            builder.Entity<PokemonAbility>()
                .HasOne<Ability>(pa => pa.Ability)
                .WithMany(a => a.PokemonAbilities)
                .HasForeignKey(pa => pa.AbilityRef);

            builder.Entity<PokemonAbility>()
                .HasOne<Pokemon>(pa => pa.Pokemon)
                .WithMany(p => p.PokemonAbilities)
                .HasForeignKey(pa => pa.PokemonRef);

            // Relacje inne

            

        }
    }

}

using AutoMapper;
using PokedexMVC.Application.Mapping;
using PokedexMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Application.Viewmodels.Pokemon
{
    public class PokemonDetailsVm : IMapFrom<PokedexMVC.Domain.Model.Pokemon>
    {
        public int Id { get; set; }
        
        public int PokemonNumber { get; set; }
        public string Name { get; set; }
        public int TypingId { get; set; }
        public TypeCombination Typing { get; set; }
        public byte[] Sprite { get; set; }

        public void Mapping(Profile profile)
        {
            
        }

    }
}

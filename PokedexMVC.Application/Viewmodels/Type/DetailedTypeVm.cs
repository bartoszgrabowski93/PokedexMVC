using AutoMapper;
using PokedexMVC.Application.Mapping;
using PokedexMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Application.Viewmodels.Type
{
    public class DetailedTypeVm : IMapFrom<PokedexMVC.Domain.Model.Typing>
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public List<PokedexMVC.Domain.Model.Pokemon> PokemonsInType { get; set; }
        public List<PokedexMVC.Domain.Model.Move> Moves { get; set; }

        public void Mapping(Profile profile) 
        {
            profile.CreateMap<PokedexMVC.Domain.Model.Typing, DetailedTypeVm>()
                .ForMember(t => t.PokemonsInType, opt => opt.MapFrom(s => s.Pokemons));
        }
    }
}

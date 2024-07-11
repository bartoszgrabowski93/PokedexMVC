using AutoMapper;
using PokedexMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Application.Viewmodels.Type
{
    public class GetAllTypesVm : IMapFrom<PokedexMVC.Domain.Model.Typing>
    { 
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<PokedexMVC.Domain.Model.Typing, GetAllTypesVm>();
        }
    }
}

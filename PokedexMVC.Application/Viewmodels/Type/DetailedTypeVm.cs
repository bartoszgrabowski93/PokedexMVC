using PokedexMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Application.Viewmodels.Type
{
    public class DetailedTypeVm
    {
        public string Name { get; set; }
        public List<Type> Weakness { get; set; }
        public List<Type> Strenght { get; set; }
        public List<Pokemon> PokemonsInType { get; set; }
        public List<Move> Moves { get; set; }
    }
}

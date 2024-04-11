using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Domain.Interace
{
    internal interface IPokemonService
    {
        public void AddPokemon();
        public void RemovePokemon();
        public void EditPokemon();

    }
}

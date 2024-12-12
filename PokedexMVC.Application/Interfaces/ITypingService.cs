using PokedexMVC.Application.Viewmodels.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Application.Interfaces
{
    public interface ITypingService
    {
        ListGetAllTypesVm GetAllTypes();
        
        void SetPokemonDualType(int pokemonId, int primaryTypeId, int secondaryTypeId);
        void SetPokemonType(int pokemonId, int typeId);
        int AddType(NewTypeVm model);
    }
}

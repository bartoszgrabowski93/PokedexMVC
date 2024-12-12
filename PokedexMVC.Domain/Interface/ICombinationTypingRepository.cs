using PokedexMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Domain.Interface
{
    public interface ICombinationTypingRepository
    {
        int AddCombinationTyping(TypeCombination typeCombination);
        void DeleteCombinationTyping(int combinationToDeleteId);
        IQueryable<TypeCombination> GetAllCombinationTyping();
        TypeCombination GetTypeCombinationById(int id);
        void AssignCombinationTypeToPokemon(Pokemon pokemon, TypeCombination typeCombination);
       
    }
}

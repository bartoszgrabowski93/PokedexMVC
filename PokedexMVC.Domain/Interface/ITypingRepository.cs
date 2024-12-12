using PokedexMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Domain.Interface
{
    public interface ITypingRepository
    {
        int AddTyping(BasicType type);

        void DeleteTyping(int typingId);

        IQueryable<BasicType> GetAllTypings();
        void SetTyping(Pokemon pokemon, TypeCombination typeCombo);
       
       
    }
}

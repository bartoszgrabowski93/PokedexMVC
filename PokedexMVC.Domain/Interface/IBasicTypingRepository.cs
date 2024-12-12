using PokedexMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Domain.Interface
{
    public interface IBasicTypingRepository
    {
        int AddBasicTyping(BasicType type);

        void DeleteBasicTyping(int typingId);
        void EditBasicTyping(int typingToEditId, BasicType typeNewData);

        IQueryable<BasicType> GetAllBasicTypings();
        BasicType GetBasicTypeById(int id);
       
       
    }
}

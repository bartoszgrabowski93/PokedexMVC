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
        int AddTyping(Typing type);

        void DeleteTyping(int typingId);

        IQueryable<Typing> GetAllTypings();
       
    }
}

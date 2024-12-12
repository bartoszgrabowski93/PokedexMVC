using PokedexMVC.Domain.Interface;
using PokedexMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Infrastructure.Repositories
{
    public class TypingRepository : ITypingRepository
    {
        private readonly Context _context;
        public TypingRepository(Context context)
        {
            _context = context;
        }

        public int AddTyping(BasicType type)
        {
            _context.BasicTypes.Add(type);
            _context.SaveChanges();
            return type.Id;
        }
        public void DeleteTyping(int typingId)
        {
            var typingToDelete = _context.BasicTypes.Find(typingId);
            if (typingToDelete != null)
            {
                _context.BasicTypes.Remove(typingToDelete);
                _context.SaveChanges();
            }else
            {
                Console.WriteLine($"Could not find Type with id : {typingId}.");
            }
        }

        public IQueryable<BasicType> GetAllTypings()
        {
            IQueryable<BasicType> typings = _context.BasicTypes;
            return typings; 
        }

        public void SetTyping(Pokemon pokemon, TypeCombination typeCombo)
        {
            throw new NotImplementedException();
        }

            
    }
}

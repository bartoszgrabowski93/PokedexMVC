using PokedexMVC.Domain.Interface;
using PokedexMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Infrastructure.Repositories
{
    public class TypingRepository : IBasicTypingRepository, ICombinationTypingRepository
    {
        private readonly Context _context;
        public TypingRepository(Context context)
        {
            _context = context;
        }

        public int AddBasicTyping(BasicType type)
        {
            _context.BasicTypes.Add(type);
            _context.SaveChanges();
            return type.Id;
        }

        public int AddCombinationTyping(TypeCombination typeCombination)
        {
            _context.TypeCombinations.Add(typeCombination);
            _context.SaveChanges();
            return typeCombination.Id;
        }

        public void AssignCombinationTypeToPokemon(Pokemon pokemon, TypeCombination typeCombination)
        {
            throw new NotImplementedException();
        }

        public void DeleteBasicTyping(int typingId)
        {
            var typingToDelete = _context.BasicTypes.Find(typingId);
            if (typingToDelete != null)
            {
                _context.BasicTypes.Remove(typingToDelete);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"Could not find Type with id : {typingId}.");
            }
        }

        public void DeleteCombinationTyping(int combinationToDeleteId)
        {
            var comboTypeToDelete = _context.TypeCombinations.Find(combinationToDeleteId);
            if (comboTypeToDelete != null)
            {
                _context.TypeCombinations.Remove(comboTypeToDelete);
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"Could not find Type with id : {combinationToDeleteId}.");
            }
        }
        

        public void EditBasicTyping(int typingToEditId, BasicType typeNewData)
        {
            var basicTypingToEdit = _context.BasicTypes.Find(typingToEditId);
            if (basicTypingToEdit != null)
            {
                basicTypingToEdit.Name = typeNewData.Name;

            }
            else
            {
                Console.WriteLine($"Could not find Type with id : {typingToEditId}.");
            }
        }

        public IQueryable<BasicType> GetAllBasicTypings()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TypeCombination> GetAllCombinationTyping()
        {
            throw new NotImplementedException();
        }

        public BasicType GetBasicTypeById(int id)
        {
            throw new NotImplementedException();
        }

        public TypeCombination GetTypeCombinationById(int id)
        {
            throw new NotImplementedException();
        }
    }

        
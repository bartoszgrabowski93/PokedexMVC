using AutoMapper;
using PokedexMVC.Application.Interfaces;
using PokedexMVC.Application.Viewmodels.Type;
using PokedexMVC.Domain.Interface;
using PokedexMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Application.Services
{
    public class TypingService : ITypingService
    {
        private readonly ITypingRepository _typingRepo;
        private readonly IMapper _mapper;

        public TypingService(ITypingRepository typingRepo, IMapper mapper)
        {
            _typingRepo = typingRepo;
            _mapper = mapper; 
        }

        public int AddType(NewTypeVm model)
        {
            var newTyping = new Typing();
            newTyping.Id = model.Id;
            newTyping.Name = model.Name;
            _typingRepo.AddTyping(newTyping);
            return newTyping.Id;
        }

        public ListGetAllTypesVm GetAllTypes()
        {
            var typings = _typingRepo.GetAllTypings();
            ListGetAllTypesVm listTypings = new ListGetAllTypesVm();
            listTypings.AllTypes = new List<GetAllTypesVm>();
            foreach (var typing in typings)
            {
                var typingVm = new GetAllTypesVm()
                {
                    Id = typing.Id,
                    Name = typing.Name
                };
                listTypings.AllTypes.Add(typingVm);
            }
            listTypings.Count = listTypings.AllTypes.Count;
            return listTypings;
        }

        public DetailedTypeVm GetTypeDetails(int typeId)
        {
            throw new NotImplementedException();
        }

        public void SetPokemonDualType(int pokemonId, int primaryTypeId, int secondaryTypeId)
        {
            throw new NotImplementedException();
        }

        public void SetPokemonType(int pokemonId, int typeId)
        {
            throw new NotImplementedException();
        }
    }
}

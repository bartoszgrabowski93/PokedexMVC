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
        DetailedTypeVm GetTypeDetails(int typeId);
    }
}

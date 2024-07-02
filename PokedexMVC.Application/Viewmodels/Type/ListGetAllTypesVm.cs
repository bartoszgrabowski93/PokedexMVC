using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Application.Viewmodels.Type
{
    public class ListGetAllTypesVm
    {
        public List<GetAllTypesVm> AllTypes { get; set; }
        public int Count { get; set; }
    }
}

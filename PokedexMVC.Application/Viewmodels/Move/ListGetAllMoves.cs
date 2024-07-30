using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Application.Viewmodels.Move
{
    public class ListGetAllMoves
    {
        public List<GetAllMovesVm> Moves { get; set; }
        public int Count { get; set; }
    }
}

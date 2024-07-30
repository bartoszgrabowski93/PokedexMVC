using PokedexMVC.Application.Viewmodels.Move;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexMVC.Application.Interfaces
{
    public interface IMoveService
    {
        ListGetAllMoves GetAllMovesToList();
        GetMoveDetailsVm GetMoveDetails(int moveId);
    }
}

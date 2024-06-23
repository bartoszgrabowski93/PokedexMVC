using Microsoft.AspNetCore.Mvc;

namespace PokedexMVC.Web.Controllers
{
    public class MoveControllercs : Controller
    {
        public IActionResult Index()
        {
            var list = moveService.GetAllMovesToList();
            return View(list);
        }

        public IActionResult Details()
        {
            var details = moveService.GetMoveDetails();
            return View(details);
        }

        [HttpGet]
        public IActionResult AddMove()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMove(moveModel model)
        {
            var moveid = moveService.AddMove(model);
            return View(moveid);
        }
    }
}

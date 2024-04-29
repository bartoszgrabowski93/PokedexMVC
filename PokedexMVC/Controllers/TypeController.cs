using Microsoft.AspNetCore.Mvc;

namespace PokedexMVC.Web.Controllers
{
    public class TypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

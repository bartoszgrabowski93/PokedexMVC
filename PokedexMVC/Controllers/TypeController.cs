using Microsoft.AspNetCore.Mvc;

namespace PokedexMVC.Web.Controllers
{
    public class TypeController : Controller
    {
        public IActionResult Index()
        {
            var model = typingService.GetAllTypes();
            return View(model);
        }

        public IActionResult Details(int typeId)
        {
            var model = typingService.GetTypeDetails(typeId);
            return View(model);
        }

        [HttpGet]
        public IActionResult SetPokemonDualType()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SetPokemonDualType(int pokemonId, int primaryTypeId, int secondaryTypeId)
        {
            var model = typingService.SetPokemonDualTyping(pokemonId, primaryTypeId, secondaryTypeId);
            return View(model);
        }

        [HttpGet]
        public IActionResult SetPokemonType() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult SetPokemonType(int pokemonId, int typeId)
        {
            var model = typingService.SetPokemonType(pokemonId, typeId);
            return View(model);
        }
    }
}

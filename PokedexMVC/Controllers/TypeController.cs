using Microsoft.AspNetCore.Mvc;
using PokedexMVC.Application.Interfaces;
using PokedexMVC.Application.Services;

namespace PokedexMVC.Web.Controllers
{
    public class TypeController : Controller
    {
        private readonly ITypingService _typingService;
        public TypeController(ITypingService typingService)
        {
            _typingService = typingService;
        }
        public IActionResult Index()
        {
            var model = _typingService.GetAllTypes();
            return View(model);
        }

        public IActionResult Details(int typeId)
        {
            var model = _typingService.GetTypeDetails(typeId);
            return View(model);
        }

        /*
        [HttpGet]
        public IActionResult AddType() 
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult AddType(TypingModel model)
        {
            var typeId = TypingService.AddType(model);
            return View(typeId);
        }
        [HttpGet]
        public IActionResult SetPokemonDualType()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SetPokemonDualType(int pokemonId, int primaryTypeId, int secondaryTypeId)
        {
            var model = _typingService.SetPokemonDualTyping(pokemonId, primaryTypeId, secondaryTypeId);
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
        */
    }
}

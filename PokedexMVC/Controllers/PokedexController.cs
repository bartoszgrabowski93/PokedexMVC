using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokedexMVC.Application.Interfaces;
using PokedexMVC.Application.Services;
using PokedexMVC.Application.Viewmodels.Pokemon;
using PokedexMVC.Web.Filters;



namespace PokedexMVC.Web.Controllers
{
    
    public class PokedexController : Controller
    {
        private readonly IPokemonService _pokemonService;
        public PokedexController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }
        
        [HttpGet]
        [Authorize(Roles = "Admin, DataManager, User")]
        public IActionResult Index()
        {            
             var model = _pokemonService.GetAllPokemonForList(10, 1, "");
            return View(model);            
        }
        [HttpPost]
        [Authorize(Roles = "Admin, DataManager, User")]
        public IActionResult Index(int pageSize, int? pageNumber, string searchString)
        {
            if (!pageNumber.HasValue)
            {
                pageNumber = 1;
            }
            if (searchString is null)
            {
                searchString = String.Empty;
            }
            var model = _pokemonService.GetAllPokemonForList(pageSize, pageNumber.Value, searchString);
            return View(model);
        }

        // GET: PokedexController/Details/5
        [Authorize(Roles = "Admin, DataManager, User")]
        public IActionResult PokemonDetails(int id)
        {
            var model = _pokemonService.GetPokemonDetails(id);
            return View(model);
        }

        
        [HttpGet]
        [Authorize(Roles = "Admin, DataManager")]
        public IActionResult AddPokemon()
        {
            return View(new NewPokemonVm());
        }
                
        [HttpPost]
        [Authorize(Roles = "Admin, DataManager")]
        public IActionResult AddPokemon(NewPokemonVm model)
        {
            _pokemonService.AddPokemon(model);
            return RedirectToAction("Index");
        }

        /*
        [HttpGet]
        public IActionResult AddPokemonDescription(int pokemonId)
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPokemonDescription(PokemonDescriptionModel model)
        {
            var id = _pokemonService.AddPokemonDescription(model);
            return View();
        }        
        */

        [HttpGet]
        [Authorize(Roles = "Admin, DataManager")]
        public IActionResult EditPokemon(int id)
        {
            var pokemon = _pokemonService.GetPokemonForEdit(id);
            return View(pokemon);

        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult EditPokemon(NewPokemonVm pokemon)
        {
            _pokemonService.UpdatePokemon(pokemon);
            return RedirectToAction("Index");
        }

        
        public IActionResult DeletePokemon(int id) 
        {
            _pokemonService.DeletePokemon(id);
            return RedirectToAction("Index");
        }
    }

}


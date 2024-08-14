using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokedexMVC.Application.Interfaces;
using PokedexMVC.Application.Services;
using PokedexMVC.Application.Viewmodels.Pokemon;



namespace PokedexMVC.Web.Controllers
{
    
    public class PokedexController : Controller
    {
        private readonly IPokemonService _pokemonService;
        public PokedexController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }
        // GET: PokedexController
        [HttpGet]
        public IActionResult Index()
        {            
             var model = _pokemonService.GetAllPokemonForList(10, 1, "");
            return View(model);            
        }
        [HttpPost]
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
        public IActionResult Details(int id)
        {
            var model = _pokemonService.GetPokemonDetails(id);
            return View(model);
        }

        // GET: PokedexController/Create
        [HttpGet]
        public IActionResult AddPokemon()
        {
            return View(new NewPokemonVm());
        }

        // POST: PokedexController/Create
        
        [HttpPost]        
         public IActionResult AddPokemon(NewPokemonVm model)
        {
            var id = _pokemonService.AddPokemon(model);
            return View();
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
    }

}


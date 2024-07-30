using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokedexMVC.Application.Interfaces;
using PokedexMVC.Application.Services;



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
        public IActionResult Index()
        {
            // utworzyć widok dla tej akcji
            // tabela z pokemonami
            // filtrowanie pokemonów
            // przygotowanie danych 
            // przekazanie filtrów do serwisu
            // serwis przygotowuje dane 
            // serwis zwraca dane do kontrollera w odpowiednim formacie

             var model = _pokemonService.GetAllPokemonForList();
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
            return View();
        }

        // POST: PokedexController/Create
        /*
        [HttpPost]        
         public IActionResult AddPokemon(PokemonModel model)
        {
            var id = _pokemonService.AddPokemon(model);
            return View();
        } 
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


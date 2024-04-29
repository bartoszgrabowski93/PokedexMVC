using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PokedexMVC.Web.Controllers
{
    public class PokedexController : Controller
    {
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

            var model = pokemonService.GetAllPokemonForList();
            return View(model);
        }

        // GET: PokedexController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: PokedexController/Create
        [HttpGet]
        public IActionResult AddPokemon()
        {
            return View();
        }

        // POST: PokedexController/Create
        [HttpPost]        
        public IActionResult AddPokemon(PokemonModel model)
        {
            var id = pokemonService.AddPokemon(model);
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
            var id = pokemonService.AddPokemonDescription(model);
            return View();
        }

        public IActionResult ViewPokemonDetails(int pokemonId)
        {
            var pokemonDetails = pokemonService.GetPokemonDetailsById(pokemondId);
            return View(pokemonDetails);
        }

    }
}

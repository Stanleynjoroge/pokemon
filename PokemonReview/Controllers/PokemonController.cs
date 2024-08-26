using Microsoft.AspNetCore.Mvc;
using PokemonReview.Interfaces;
using PokemonReview.Models;

namespace PokemonReview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;

        public PokemonController(IPokemonRepository pokemonRepository)
        {
                _pokemonRepository = pokemonRepository;
        }

        public IPokemonRepository PokemonRepository => _pokemonRepository;

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
        public IActionResult GetPokemons() 
        {
            var pokemons = PokemonRepository.GetPokemons();
            if (!ModelState.IsValid) 
                return BadRequest(ModelState);

                return Ok(pokemons);

               
        }
    }
}
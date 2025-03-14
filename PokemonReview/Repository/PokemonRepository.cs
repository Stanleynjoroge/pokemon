﻿
using PokemonReview.Data;
using PokemonReview.Interfaces;
using PokemonReview.Models;

namespace PokemonReview.Repository
{
    public class PokemonRepository :IPokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context) 
        {
            _context = context;
        }
        public ICollection<Pokemon>GetPokemons()
        {
            return _context.Pokemons.OrderBy(p => p.Id).ToList();
        }
    }
}

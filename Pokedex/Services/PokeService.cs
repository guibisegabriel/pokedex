using System.Text.Json;
using Pokedex.Models;

namespace Pokedex.Services;

public class PokeService : IPokeService
{
    
     private readonly IHttpContextAccessor _session;
    private readonly string pokemonFile = @"Data\pokemons.Json";
    private readonly string tiposFile = @"Data\tipos.Json";

    public DetailsDto GetDetailedPokemon(int Numero)
    {
        throw new NotImplementedException();
    }

    public PokedexDto GetPokedexDto()
    {
        throw new NotImplementedException();
    }

    public Pokemon GetPokemon(int Numero)
    {
        throw new NotImplementedException();
    }

    public List<Pokemon> GetPokemons()
    {
        throw new NotImplementedException();
    }

    public Tipo GetTipo(string Nome)
    {
        throw new NotImplementedException();
    }

    public List<Tipo> GetTipos()
    {
        throw new NotImplementedException();
    }
}
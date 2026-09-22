using DioPokedex.DTOs;
using DioPokedex.Models;

namespace DioPokedex.Services;

public interface IPokemonService
{
    PokemonDTO CreatePkmn(CreatePokemonDTO pokemon);
    
    IEnumerable<PokemonDTO> GetPkmnByName(string name);
    
    PokemonDTO GetPkmnById(int id);
    
    IEnumerable<PokemonDTO> ListPokemons();
    
    void DeletePkmn(int id);
}
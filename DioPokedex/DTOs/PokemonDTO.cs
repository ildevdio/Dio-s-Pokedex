using DioPokedex.Models;
using System.Collections.Generic;

namespace DioPokedex.DTOs;

public class CreatePokemonDTO
{
    public string Name { get; set; }
    public string Description { get; set; } = "";
    public string SpriteURL { get; set; } = "";
    public PokemonType PrimaryType { get; set; }
    public PokemonType SecondaryType { get; set; }
    public bool IsLegendary { get; set; }
}

public class EditPokemonDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? SpriteURL { get; set; }
}

public class DeletePokemonDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
}

public class PokemonDTO
{
    public int id  { get; set; } 
    public string name  { get; set; }
    public PokemonType primaryType  { get; set; }
    public PokemonType secondaryType  { get; set; }
    public bool isLegendary  { get; set; } = false;
    public string spriteUrl { get; set; } = "";
    public string description { get; set; } = "";
}


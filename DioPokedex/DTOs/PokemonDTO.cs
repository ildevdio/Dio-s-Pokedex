using DioPokedex.Models;

namespace DioPokedex.DTOs;

public class CreatePokemonDTO
{
    public required string Name { get; set; }
    public string Description { get; set; } = "";
    public string SpriteUrl { get; set; } = "";
    public PokemonType PrimaryType { get; set; }
    public PokemonType SecondaryType { get; set; }
    public bool IsLegendary { get; set; }
}

public class EditPokemonDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? SpriteUrl { get; set; }
}

public class DeletePokemonDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
}

public class PokemonDTO
{
    public int Id  { get; set; } 
    public string Name  { get; set; }
    public PokemonType PrimaryType  { get; set; }
    public PokemonType SecondaryType  { get; set; }
    public bool IsLegendary  { get; set; } = false;
    public string SpriteUrl { get; set; } = "";
    public string Description { get; set; } = "";
}


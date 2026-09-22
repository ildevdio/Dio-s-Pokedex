namespace DioPokedex.Models;

public enum PokemonType
{
    None,
    Normal,
    Fogo,
    Agua,
    Grama,
    Eletrico,
    Gelo,
    Lutador,
    Venenoso,
    Terrestre,
    Voador,
    Psiquico,
    Inseto,
    Pedra,
    Fantasma,
    Dragao,
    Sombrio,
    Aco,
    Fada
}
public class Pokemon
{
    private static int _idCounter = 0;
    private int _id; 
    private string _name;
    private PokemonType _primaryType;
    private PokemonType _secondaryType;
    private bool _isLegendary = false;
    private string _spriteUrl = string.Empty;
    private string _description = string.Empty;

    public int Id => _id;
    public string Name
    {
        get => _name;

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Nome não pode estar vazio...");
            }
            _name = value;
        }
    }

    public PokemonType PrimaryType
    {
        get => _primaryType;
        
        set
        {
            if (!Enum.IsDefined(typeof(PokemonType), value) ||  value == PokemonType.None)
            {
                throw new ArgumentException(nameof(PrimaryType), "Tipo inválido ou vazio. Escolha novamente...");
            }
            _primaryType = value;
        }
    }

    public PokemonType SecondaryType
    {
        get => _secondaryType;

        set
        {
            if (!Enum.IsDefined(typeof(PokemonType), value))
            {
                throw new ArgumentException(nameof(SecondaryType), "Tipo inválido. Escolha novamente...");
            }
            _secondaryType = value;
        }
    }

    public bool IsLegendary
    {
        get => _isLegendary;
        
        set => _isLegendary = value;
    }
    
    public string SpriteUrl
    {
        get => _spriteUrl;
        
        set => _spriteUrl = value;
    }

    public string Description
    {
        get => _description;
        
        set => _description = value;
    }

    public Pokemon(string name, PokemonType primaryType, PokemonType secondaryType, bool isLegendary, string spriteUrl, string description)
    {
        _id = _idCounter++;
        
        this.Name = name;
        this.PrimaryType = primaryType;
        this.SecondaryType = secondaryType;
        this.IsLegendary = isLegendary;
        this.SpriteUrl = spriteUrl;
        this.Description = description;
    }
}

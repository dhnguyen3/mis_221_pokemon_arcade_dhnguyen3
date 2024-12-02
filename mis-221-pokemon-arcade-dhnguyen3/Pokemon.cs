
public class Pokemon
{
    public string Name { get; set; }
    public string Habitat { get; set; }
    public bool IsLegendary { get; set; }
    public bool IsShiny { get; set; }
    public int Rarity { get; set; } // 1: Common, 2: Uncommon, 3: Rare

    public Pokemon(string name, string habitat, bool isLegendary, bool isShiny, int rarity)
    {
        Name = name;
        Habitat = habitat;
        IsLegendary = isLegendary;
        IsShiny = isShiny;
        Rarity = rarity;
    }
}

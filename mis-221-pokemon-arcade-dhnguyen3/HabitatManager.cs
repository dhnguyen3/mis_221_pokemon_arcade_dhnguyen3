using System;
using System.Collections.Generic;
using System.Linq;

public class HabitatManager
{
    private static List<Pokemon> pokemonList = new List<Pokemon>();

    static HabitatManager()
    {
        Initialize();
    }

    // Initialize the Pokemon data (e.g., from a file or hard-coded list)
    private static void Initialize()
    {
        // Adding Pokémon examples with their respective habitats, rarity, and catch difficulty
        pokemonList.Add(new Pokemon("Bulbasaur", "Tall Grass", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Ivysaur", "Tall Grass", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Venusaur", "Tall Grass", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Charmander", "Forest", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Charmeleon", "Forest", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Charizard", "Mountain", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Squirtle", "Lake", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Wartortle", "Lake", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Blastoise", "Ocean", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Caterpie", "Tall Grass", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Metapod", "Tall Grass", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Butterfree", "Forest", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Weedle", "Tall Grass", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Kakuna", "Tall Grass", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Beedrill", "Forest", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Pidgey", "Tall Grass", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Pidgeotto", "Tall Grass", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Pidgeot", "Sky", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Rattata", "Road", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Raticate", "Road", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Spearow", "Road", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Fearow", "Sky", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Ekans", "Swamp", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Arbok", "Swamp", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Pikachu", "Urban", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Raichu", "Urban", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Sandshrew", "Desert", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Sandslash", "Desert", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Nidoran♀", "Tall Grass", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Nidorina", "Tall Grass", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Nidoqueen", "Cave", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Nidoran♂", "Tall Grass", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Nidorino", "Tall Grass", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Nidoking", "Cave", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Clefairy", "Forest", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Clefable", "Forest", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Vulpix", "Mountain", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Ninetales", "Mountain", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Jigglypuff", "Urban", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Wigglytuff", "Urban", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Zubat", "Cave", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Golbat", "Cave", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Oddish", "Forest", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Gloom", "Forest", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Vileplume", "Forest", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Paras", "Forest", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Parasect", "Forest", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Venonat", "Tall Grass", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Venomoth", "Tall Grass", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Diglett", "Tunnel", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Dugtrio", "Tunnel", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Meowth", "Urban", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Persian", "Urban", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Psyduck", "Lake", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Golduck", "Lake", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Mankey", "Urban", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Primeape", "Urban", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Growlithe", "Urban", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Arcanine", "Urban", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Poliwag", "Lake", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Poliwhirl", "Lake", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Poliwrath", "Lake", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Abra", "Urban", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Kadabra", "Urban", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Alakazam", "Urban", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Machop", "Urban", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Machoke", "Urban", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Machamp", "Urban", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Bellsprout", "Forest", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Weepinbell", "Forest", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Victreebel", "Forest", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Tentacool", "Ocean", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Tentacruel", "Ocean", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Geodude", "Cave", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Graveler", "Cave", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Golem", "Cave", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Ponyta", "Mountain", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Rapidash", "Mountain", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Slowpoke", "Lake", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Slowbro", "Lake", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Magnemite", "Urban", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Magneton", "Urban", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Farfetch’d", "Urban", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Doduo", "Road", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Dodrio", "Road", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Seel", "Ocean", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Dewgong", "Ocean", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Grimer", "Swamp", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Muk", "Swamp", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Shellder", "Ocean", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Cloyster", "Ocean", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Gastly", "Cave", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Haunter", "Cave", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Gengar", "Cave", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Onix", "Cave", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Drowzee", "Urban", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Hypno", "Urban", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Krabby", "Ocean", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Kingler", "Ocean", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Voltorb", "Urban", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Electrode", "Urban", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Exeggcute", "Forest", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Exeggutor", "Forest", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Cubone", "Desert", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Marowak", "Desert", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Hitmonlee", "Urban", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Hitmonchan", "Urban", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Lickitung", "Urban", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Koffing", "Swamp", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Weezing", "Swamp", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Rhyhorn", "Desert", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Rhydon", "Desert", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Chansey", "Forest", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Tangela", "Forest", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Kangaskhan", "Road", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Horsea", "Ocean", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Seadra", "Ocean", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Goldeen", "Lake", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Seaking", "Lake", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Staryu", "Ocean", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Starmie", "Ocean", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Mr. Mime", "Urban", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Scyther", "Forest", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Jynx", "Urban", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Electabuzz", "Urban", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Magmar", "Volcano", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Pinsir", "Forest", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Tauros", "Road", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Magikarp", "Ocean", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Gyarados", "Ocean", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Lapras", "Lake", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Ditto", "Urban", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Eevee", "Urban", false, false, 1)); // Common
        pokemonList.Add(new Pokemon("Vaporeon", "Lake", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Jolteon", "Urban", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Flareon", "Forest", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Porygon", "Urban", false, false, 2)); // Uncommon
        pokemonList.Add(new Pokemon("Omanyte", "Desert", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Omastar", "Desert", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Kabuto", "Desert", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Kabutops", "Desert", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Aerodactyl", "Cave", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Snorlax", "Road", false, false, 3)); // Rare
        pokemonList.Add(new Pokemon("Articuno", "Polar", true, false, 4)); // Legendary
        pokemonList.Add(new Pokemon("Zapdos", "Urban", true, false, 4)); // Legendary
        pokemonList.Add(new Pokemon("Moltres", "Volcano", true, false, 4)); // Legendary
        pokemonList.Add(new Pokemon("Mewtwo", "Cave", true, false, 4)); // Legendary
        pokemonList.Add(new Pokemon("Mew", "Urban", true, true, 4)); // Mythical
        // Add more Pokémon data as needed...
    }

    // Get a list of Pokémon based on the habitat
    public static List<string> GetPokemonByHabitat(string habitat)
    {
        var pokemonInHabitat = pokemonList
            .Where(p => p.Habitat.Equals(habitat, StringComparison.OrdinalIgnoreCase))
            .Select(p => p.Name)
            .ToList();

        return pokemonInHabitat;
    }
}

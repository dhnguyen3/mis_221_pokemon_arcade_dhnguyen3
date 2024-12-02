namespace PokemonArcade
{
    public static class PokedexManager
    {
        public static List<PokedexEntry> Pokedex { get; private set; } = new(); // Pokémon Entries

        // Add a Pokémon to the Pokédex, ensuring it's added by National Pokédex order
        public static void AddPokemonToPokedex(PokemonData pokemonData)
        {
            // Ensure the Pokémon is not already in the Pokédex
            if (Pokedex.Any(entry => entry.PokemonData.Name.Equals(pokemonData.Name, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine($"{pokemonData.Name} is already in your Pokédex!");
                return;
            }

            // Insert the new Pokémon in order based on National Pokédex number
            Pokedex.Add(new PokedexEntry(pokemonData));
            Pokedex = Pokedex.OrderBy(entry => int.Parse(entry.PokemonData.Number.TrimStart('#'))).ToList();
        }

        // Display the list of caught Pokémon in the Pokédex
        public static void DisplayPokedex()
        {
            Console.Clear();
            Console.WriteLine("Pokédex - Your Caught Pokémon:");

            if (Pokedex.Count == 0)
            {
                Console.WriteLine("Your Pokédex is empty! Go out and catch some Pokémon!");
                Console.ReadKey();
                return;
            }

            int index = 1;
            foreach (var entry in Pokedex)
            {
                Console.WriteLine($"{index}. {entry.PokemonData.Name} ({entry.PokemonData.Number})");
                index++;
            }

            Console.WriteLine("\nSelect a Pokémon by its number to view its entry:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice > 0 && choice <= Pokedex.Count)
            {
                DisplayPokedexEntry(Pokedex[choice - 1].PokemonData);
            }
            else
            {
                Console.WriteLine("Invalid selection. Returning to the menu...");
                Console.ReadKey();
            }
        }

        // Display a detailed entry of a specific Pokémon (make this public to be accessible from other classes like SeekNCatch)
        public static void DisplayPokedexEntry(PokemonData pokemon)
        {
            Console.Clear();
            Console.WriteLine("Pokédex Entry:");
            pokemon.DisplayInfo();
            Console.WriteLine("\nPress any key to return to the Pokédex...");
            Console.ReadKey();
        }
    }
}

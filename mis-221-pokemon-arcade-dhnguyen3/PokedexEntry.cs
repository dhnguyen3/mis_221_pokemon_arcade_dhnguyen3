namespace PokemonArcade
{
    public class PokedexEntry
    {
        public PokemonData PokemonData { get; set; }

        public PokedexEntry(PokemonData pokemonData)
        {
            PokemonData = pokemonData;
        }

        // Display the information of the Pokémon in the Pokédex
        public void DisplayPokedexEntry()
        {
            Console.WriteLine($"Name: {PokemonData.Name}");
            Console.WriteLine($"No: {PokemonData.Number}");
            Console.WriteLine($"Type: {PokemonData.Type}");
            Console.WriteLine($"Species: {PokemonData.Species}");
            Console.WriteLine($"Height: {PokemonData.Height}");
            Console.WriteLine($"Weight: {PokemonData.Weight}");
            Console.WriteLine($"Fun Fact: {PokemonData.FunFact}");
            Console.WriteLine();
        }
    }
}

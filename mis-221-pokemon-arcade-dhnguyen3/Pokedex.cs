using System;
using System.Collections.Generic;

namespace PokemonArcade
{
    public static class Pokedex
    {
        // Display the list of Pokémon the trainer has caught
        public static void DisplayCaughtPokemon()
        {
            Console.Clear();
            Console.WriteLine("Pokédex - Your Caught Pokémon:");

            if (PokedexManager.Pokedex.Count == 0)
            {
                Console.WriteLine("Your Pokédex is empty! Go out and catch some Pokémon!");
                
                Console.ReadKey();
                return;
            }

            // Display Pokémon names and numbers
            int index = 1;
            foreach (var entry in PokedexManager.Pokedex)
            {
                Console.WriteLine($"{index}. {entry.PokemonData.Name} ({entry.PokemonData.Number})");
                index++;
            }

            Console.WriteLine("\nSelect a Pokémon by its number to view its entry:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice > 0 && choice <= PokedexManager.Pokedex.Count)
            {
                DisplayPokedexEntry(PokedexManager.Pokedex[choice - 1].PokemonData);
            }
            else
            {
                Console.WriteLine("Invalid selection. Returning to the menu...");
                Console.ReadKey();
            }
        }

        // Display the detailed entry for a selected Pokémon
        private static void DisplayPokedexEntry(PokemonData pokemon)
        {
            Console.Clear();
            Console.WriteLine("Pokédex Entry:");
            pokemon.DisplayInfo();
            Console.WriteLine("\nPress any key to return to the Pokédex...");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;

namespace PokemonArcade
{
    public class SeekNCatch
    {
        // Main Play method to handle the game's logic
        public static void Play()
        {
            if (!GameManager.IsLicensed)
            {
                PlayForCoins(); // Standard gameplay to earn coins before the license is obtained
            }
            else
            {
                PlayWithCatching(); // Gameplay with Pokémon catching after the trainer gets their license
            }
        }

        // Gameplay logic before obtaining the trainer license (earning coins)
        private static void PlayForCoins()
        {
            string[] locations = { "Poké Ball", "Tall Grass", "Cave", "Gym", "Tree", "House", "Lake" }; // Pre-license locations
            string hidingSpot = GetRandomLocation(locations); // Random location where Pokémon hides
            int attempts = 3; // Number of attempts before the Pokémon escapes

            Console.Clear();
            Console.WriteLine("Try to guess where the Pokémon is hiding:");
            Console.WriteLine(string.Join(", ", locations)); // Show the player where to guess

            // Loop to allow player to guess the hiding spot of the Pokémon
            while (attempts > 0)
            {
                Console.Write("Your guess: ");
                string guess = Console.ReadLine();

                // Searching animation before result
                Console.Write("Searching");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("...");
                    System.Threading.Thread.Sleep(500); // Pause for the dots to show up
                }
                Console.WriteLine(); // Move to the next line after the animation

                if (guess.Equals(hidingSpot, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You found the Pokémon and earned 5 Poké Coins!");
                    GameManager.AddCoins(5); // Add coins for finding the Pokémon
                    return; // End the game if the Pokémon is found
                }
                else
                {
                    attempts--; // Decrease attempts if the guess is incorrect
                    Console.WriteLine(attempts > 0 ? "Try again!" : "The Pokémon escaped.");
                }
            }
        }

        // Gameplay logic after obtaining the trainer license (catching Pokémon)
        private static void PlayWithCatching()
        {
            string[] locations = { "Sky", "Tall Grass", "Cave", "Lake", "Ocean", "Tunnel", "Road", "Urban", "Swamp", "Forest", "Mountain", "Desert", "Volcano", "Polar" };
            string hidingSpot = GetRandomLocation(locations); // Random location where Pokémon hides

            Console.Clear();
            Console.WriteLine("Try to guess where the Pokémon is hiding:");
            Console.WriteLine(string.Join(", ", locations)); // Show the player where to guess

            // Infinite attempts until the Pokémon is found
            while (true)
            {
                Console.Write("Your guess: ");
                string guess = Console.ReadLine();

                // Searching animation before result
                Console.Write("Searching");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("...");
                    System.Threading.Thread.Sleep(500); // Pause for the dots to show up
                }
                Console.WriteLine(); // Move to the next line after the animation

                if (guess.Equals(hidingSpot, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"You found the Pokémon in the {guess}!");
                    EncounterPokemon(guess); // Proceed to encounter and possibly catch the Pokémon
                    return; // End the guessing phase
                }
                else
                {
                    Console.WriteLine("Not there! Try again!");
                }
            }
        }

        // Method to handle Pokémon encounter based on the habitat
        private static void EncounterPokemon(string habitat)
        {
            List<string> availablePokemon = HabitatManager.GetPokemonByHabitat(habitat);
            Random rand = new Random();
            string encounteredPokemon = availablePokemon[rand.Next(availablePokemon.Count)];

            Console.WriteLine($"You encountered a {encounteredPokemon}!");  // Display the encountered Pokémon

            // Ask if the player wants to try and catch the Pokémon
            Console.WriteLine("Do you want to try to catch it? (Yes/No): ");
            string response = Console.ReadLine();

            if (response.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                RandomCatch(encounteredPokemon); // Call the method to handle catch attempt
            }
            else
            {
                Console.WriteLine($"The {encounteredPokemon} ran away!"); // If player declines
            }
        }

        // Method to handle randomized catch rate and Poké Ball deduction
        private static void RandomCatch(string encounteredPokemon)
        {
            if (GameManager.Bag.ContainsKey("Poké Ball") && GameManager.Bag["Poké Ball"] > 0)
            {
                Random rand = new Random();
                int catchRate = rand.Next(1, 101); // Random number between 1 and 100
                int catchChance = 60; // Base catch chance (60%)

                if (catchRate <= catchChance)
                {
                    // Add Pokémon to the team or storage
                    if (GameManager.Team.Count < 6)
                    {
                        GameManager.Team.Add(encounteredPokemon);
                        Console.WriteLine($"You caught {encounteredPokemon}!");
                    }
                    else
                    {
                        GameManager.Storage.Add(encounteredPokemon);
                        Console.WriteLine($"Your team is full. {encounteredPokemon} has been transferred to your storage.");
                    }

                    // Deduct one Poké Ball
                    GameManager.Bag["Poké Ball"]--;
                    GameManager.AddCoins(10); // Award coins for a successful catch

                    // Add Pokémon to the Pokédex
                    PokemonData pokemonData = PokedexData.GetPokemonByName(encounteredPokemon); // You should fetch the PokemonData by number
                    GameManager.AddPokemonToPokedex(pokemonData);

                    // Show the Pokémon's Pokédex entry
                    PokedexManager.DisplayPokedexEntry(pokemonData);
                }
                else
                {
                    Console.WriteLine($"The {encounteredPokemon} broke free!");
                    GameManager.Bag["Poké Ball"]--;
                }
            }
            else
            {
                Console.WriteLine("You don't have any Poké Balls to catch the Pokémon!");
            }
        }

        // Helper method to get a random location where the Pokémon is hiding
        private static string GetRandomLocation(string[] locations)
        {
            Random rand = new Random();
            return locations[rand.Next(locations.Length)];
        }
    }
}

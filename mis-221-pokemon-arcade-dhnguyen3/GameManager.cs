using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace PokemonArcade
{
    public static class GameManager
    {
        // Core game properties
        public static int PokeCoins { get; private set; } = 10; // Starting Poké Coins
        public static string Avatar { get; private set; } = "Trainer"; // Default Trainer Name
        public static string RivalName { get; set; } = "Rival"; // Default Rival Name
        public static bool IsLicensed { get; set; } = false; // Whether the Trainer License is obtained
        public static bool HasPokedex { get; set; } = false; // Whether the Trainer has obtained the Pokédex
        public static List<string> Team { get; private set; } = new(); // Pokémon Team
        public static List<string> Storage { get; private set; } = new(); // Pokémon Storage
        public static Dictionary<string, int> Bag { get; private set; } = new(); // Item Bag
        private static Dictionary<string, int> leaderboard = new(); // Leaderboard data

        // Initialize the game
        public static void Initialize()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Pokémon Trainer Arcade!");
            Console.Write("Enter your name: ");
            Avatar = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(Avatar))
            {
                Avatar = "Trainer";
            }

            Console.WriteLine($"Welcome, {Avatar}!");
            AddItemToBag("Poké Ball", 10); // Starting items
            AddItemToBag("Potion", 5);
            LoadLeaderboard();
        }

        // Add coins to the player's total
        public static void AddCoins(int amount)
        {
            PokeCoins += amount;
        }

        // Deduct coins from the player's total
        public static void DeductCoins(int amount)
        {
            PokeCoins -= amount;
        }

        // Add an item to the player's bag
        public static void AddItemToBag(string item, int quantity)
        {
            if (Bag.ContainsKey(item))
            {
                Bag[item] += quantity;
            }
            else
            {
                Bag[item] = quantity;
            }
        }

        // Display the player's bag contents
        public static void DisplayBag()
        {
            Console.Clear();
            Console.WriteLine("Your Bag:");
            if (Bag.Count == 0)
            {
                Console.WriteLine("Your bag is empty!");
            }
            else
            {
                foreach (var item in Bag)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }

        // Load leaderboard data from a file
        private static void LoadLeaderboard()
        {
            if (File.Exists("leaderboard.txt"))
            {
                foreach (var line in File.ReadAllLines("leaderboard.txt"))
                {
                    var parts = line.Split(':');
                    leaderboard[parts[0]] = int.Parse(parts[1]);
                }
            }
        }

        // Save leaderboard data to a file
        public static void SaveLeaderboard()
        {
            using (var writer = new StreamWriter("leaderboard.txt"))
            {
                foreach (var entry in leaderboard)
                {
                    writer.WriteLine($"{entry.Key}:{entry.Value}");
                }
            }
        }

        // Display the leaderboard
        public static void DisplayLeaderboard()
        {
            Console.Clear();
            Console.WriteLine("Leaderboard:");
            if (leaderboard.Count == 0)
            {
                Console.WriteLine("No leaderboard data available.");
            }
            else
            {
                foreach (var entry in leaderboard)
                {
                    Console.WriteLine($"{entry.Key}: {entry.Value} Poké Coins");
                }
            }
        }

        // Pause before returning to the main menu
        public static void PauseBeforeMenu()
        {
            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }

        // Grant the trainer their Trainer License and bonus PokéCoins
        public static void GrantTrainerLicense()
        {
            if (!IsLicensed)
            {
                IsLicensed = true;
                AddCoins(300); // Award the trainer 300 PokéCoins for getting their license
                Console.WriteLine("Congratulations! You've obtained your Trainer License and received 300 PokéCoins as a bonus!");
                HasPokedex = true; // Trainer now has the Pokédex
            }
            else
            {
                Console.WriteLine("You already have your Trainer License.");
            }
        }

        // Add a Pokémon to the Pokédex
        public static void AddPokemonToPokedex(PokemonData pokemonData)
        {
            if (!PokedexManager.Pokedex.Exists(entry => entry.PokemonData.Name == pokemonData.Name))
            {
                PokedexManager.AddPokemonToPokedex(pokemonData); // Delegate to PokedexManager
            }
        }
    }
}
using System;
using System.IO;

namespace PokemonArcade
{
    public class WhosThatPokemon
    {
        private static string lastChosenPokemon = null; // Tracks the last chosen Pokémon

        public static void Play()
        {
            Console.Clear();

            // Check if pokemonNames.txt exists, otherwise use default Pokémon names
            string[] pokemonNames = File.Exists("pokemonNames.txt")
                ? File.ReadAllLines("pokemonNames.txt")
                : new[] { "Pikachu", "Charmander", "Squirtle", "Bulbasaur", "Eevee", "Meowth" };

            if (pokemonNames.Length == 1)
            {
                Console.WriteLine("There is only one Pokémon in the list. Unable to randomize.");
                GameManager.PauseBeforeMenu();  // Use GameManager's pause method instead of in this class
                return;
            }

            Random random = new Random();
            string chosenPokemon;

            // Randomize Pokémon ensuring it is not the same as the last chosen Pokémon
            do
            {
                chosenPokemon = pokemonNames[random.Next(pokemonNames.Length)];
            } while (chosenPokemon == lastChosenPokemon);

            lastChosenPokemon = chosenPokemon; // Update the last chosen Pokémon

            char[] guessedWord = new string('_', chosenPokemon.Length).ToCharArray();
            int attemptsLeft = 6;

            Console.WriteLine("Welcome to Who's That Pokémon! You have 6 attempts.");
            while (attemptsLeft > 0)
            {
                Console.WriteLine($"Word: {new string(guessedWord)}");
                Console.Write("Enter a letter: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input) || input.Length > 1)
                {
                    Console.WriteLine("Invalid input! Please enter a single letter.");
                    continue;
                }

                char guess = input.ToLower()[0];
                bool correctGuess = false;

                // Check if the guess is correct
                for (int i = 0; i < chosenPokemon.Length; i++)
                {
                    if (char.ToLower(chosenPokemon[i]) == guess)
                    {
                        guessedWord[i] = chosenPokemon[i];
                        correctGuess = true;
                    }
                }

                // If the guess is incorrect, reveal one of the correct letters
                if (!correctGuess)
                {
                    attemptsLeft--;
                    Console.WriteLine($"Wrong guess! Attempts left: {attemptsLeft}");

                    // Reveal one of the hidden letters
                    RevealCorrectLetter(ref guessedWord, chosenPokemon);
                }

                // Check if the player has guessed all the letters
                if (!new string(guessedWord).Contains('_'))
                {
                    Console.WriteLine($"Congratulations! It's {chosenPokemon}!");
                    GameManager.AddCoins(10);  // Add coins to the player
                    
                    return;
                }
            }

            Console.WriteLine($"Game over! It was {chosenPokemon}.");
            
        }

        // Function to reveal one correct letter when the player guesses incorrectly
        private static void RevealCorrectLetter(ref char[] guessedWord, string chosenPokemon)
        {
            // Find all positions of hidden letters (denoted by '_')
            List<int> hiddenPositions = new List<int>();

            for (int i = 0; i < guessedWord.Length; i++)
            {
                if (guessedWord[i] == '_')
                {
                    hiddenPositions.Add(i);
                }
            }

            // Randomly pick one of the hidden positions
            if (hiddenPositions.Count > 0)
            {
                Random random = new Random();
                int revealIndex = hiddenPositions[random.Next(hiddenPositions.Count)];

                // Reveal a correct letter at that position
                guessedWord[revealIndex] = chosenPokemon[revealIndex];
                Console.WriteLine($"One of the correct letters is now revealed: {new string(guessedWord)}");
            }
        }
    }
}

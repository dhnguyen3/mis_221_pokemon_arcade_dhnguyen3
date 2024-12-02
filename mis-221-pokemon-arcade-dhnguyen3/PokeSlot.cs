using System;

namespace PokemonArcade
{
    public class PokeSlot
    {
        public static void Play()
        {
            // List of possible symbols for the slot machine
            string[] symbols = { "Pikachu", "Charmander", "Bulbasaur", "Squirtle", "Eevee", "Meowth" };
            Random random = new Random();

            // Clear the console and prompt the user for the wager amount
            Console.Clear();
            Console.Write("Enter the number of Poké Coins to wager: ");
            
            // Validate if the wager is a valid number and within the available PokéCoins
            if (int.TryParse(Console.ReadLine(), out int wager) && wager > 0 && wager <= GameManager.PokeCoins)
            {
                // Deduct the wagered amount from the player's PokéCoins
                GameManager.DeductCoins(wager);

                // Simulate rolling the slot machine
                Console.Write("Rolling");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("...");
                    System.Threading.Thread.Sleep(500);
                }
                Console.WriteLine();

                // Simulate the slot machine result by selecting three random symbols
                string[] roll = {
                    symbols[random.Next(symbols.Length)],
                    symbols[random.Next(symbols.Length)],
                    symbols[random.Next(symbols.Length)]
                };

                // Display the result of the slot machine roll
                Console.WriteLine($"You rolled: {roll[0]}, {roll[1]}, {roll[2]}");

                int winnings = 0;

                // Check if the player won based on the result of the roll
                if (roll[0] == roll[1] && roll[1] == roll[2])
                {
                    winnings = wager * 3;  // All three symbols match, triple the wager
                }
                else if (roll[0] == roll[1] || roll[1] == roll[2] || roll[0] == roll[2])
                {
                    winnings = wager * 2;  // Two symbols match, double the wager
                }
                else if (Array.Exists(roll, symbol => symbol == "Pikachu"))
                {
                    winnings = wager;  // One Pikachu symbol, win the wager amount
                }

                // Add the winnings to the player's PokéCoins
                GameManager.AddCoins(winnings);

                // Inform the player of the result
                Console.WriteLine(winnings > 0 ? $"You won {winnings} Poké Coins!" : "No luck this time.");
            }
            else
            {
                Console.WriteLine("Invalid wager. Returning to menu.");
            }

            // Pause before returning to the main menu
            
        }
    }
}

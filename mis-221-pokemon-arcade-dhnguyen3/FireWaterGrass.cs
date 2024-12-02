using System;

namespace PokemonArcade
{
    public class FireWaterGrass
    {
        public static void Play()
        {
            string[] choices = { "Fire", "Water", "Grass" };
            Random random = new Random();
            int playerWins = 0, rounds = 3;

            Console.Clear();
            Console.WriteLine("Welcome to Fire, Water, Grass! Best of three rounds.");
            Console.WriteLine("Grass beats Water, Water beats Fire, Fire beats Grass.");

            for (int i = 0; i < rounds; i++)
            {
                Console.Write("Choose Fire, Water, or Grass: ");
                string playerChoice = Console.ReadLine();
                string computerChoice = choices[random.Next(choices.Length)];

                Console.WriteLine($"Computer chose: {computerChoice}");

                if (playerChoice.Equals(computerChoice, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("It's a draw!");
                }
                else if (
                    (playerChoice.Equals("Fire", StringComparison.OrdinalIgnoreCase) && computerChoice == "Grass") ||
                    (playerChoice.Equals("Water", StringComparison.OrdinalIgnoreCase) && computerChoice == "Fire") ||
                    (playerChoice.Equals("Grass", StringComparison.OrdinalIgnoreCase) && computerChoice == "Water"))
                {
                    Console.WriteLine("You win this round!");
                    playerWins++;
                }
                else
                {
                    Console.WriteLine("You lose this round.");
                }
            }

            int coinsEarned = playerWins * 5;
            GameManager.AddCoins(coinsEarned);  // Add coins to the player
            Console.WriteLine($"You won {playerWins} rounds and earned {coinsEarned} Poké Coins!");

            
        }
    }
}

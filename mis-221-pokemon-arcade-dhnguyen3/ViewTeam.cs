using System;

namespace PokemonArcade
{
    public class ViewTeam
    {
        public static void Display()
        {
            Console.Clear();
            Console.WriteLine("Your Pokémon Team:");

            // Check if the team is empty
            if (GameManager.Team.Count == 0)
            {
                Console.WriteLine("Your team is empty!");
            }
            else
            {
                // Display all Pokémon in the team
                for (int i = 0; i < GameManager.Team.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {GameManager.Team[i]}");
                }
            }
            // No need for PauseBeforeMenu() here, it will be handled centrally in Program.cs
        }
    }
}

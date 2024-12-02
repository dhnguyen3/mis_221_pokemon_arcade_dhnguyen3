using System;

namespace PokemonArcade
{
    public class ViewStorage
    {
        public static void Display()
        {
            Console.Clear();
            Console.WriteLine("Pokémon Storage:");

            // Check if the storage is empty
            if (GameManager.Storage.Count == 0)
            {
                Console.WriteLine("Your storage is empty!");
            }
            else
            {
                // Display all Pokémon in storage
                for (int i = 0; i < GameManager.Storage.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {GameManager.Storage[i]}");
                }
            }
            // No need for PauseBeforeMenu() here, it will be handled centrally in Program.cs
        }
    }
}

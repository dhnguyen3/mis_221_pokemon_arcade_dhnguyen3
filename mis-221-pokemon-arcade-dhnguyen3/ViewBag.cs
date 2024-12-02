using System;

namespace PokemonArcade
{
    public class ViewBag
    {
        public static void Display()
        {
            Console.Clear();
            Console.WriteLine("Your Bag:");

            // Check if the bag is empty
            if (GameManager.Bag.Count == 0)
            {
                Console.WriteLine("Your bag is empty!");
            }
            else
            {
                // Display all items in the bag with their quantities
                foreach (var item in GameManager.Bag)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }
    }
}

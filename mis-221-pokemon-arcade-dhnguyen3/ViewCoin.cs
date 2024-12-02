using System;

namespace PokemonArcade
{
    public static class ViewCoins
    {
        public static void Display()
        {
            Console.Clear();
            Console.WriteLine($"You currently have {GameManager.PokeCoins} Poké Coins.");
        }
    }
}

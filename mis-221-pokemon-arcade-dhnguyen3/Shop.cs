namespace PokemonArcade
{
    public static class Shop
    {
        // Prices for the items
        private static readonly Dictionary<string, int> ItemPrices = new Dictionary<string, int>
        {
            { "Poké Ball", 10 },
            { "Potion", 15 },
            { "Revive", 30 }
        };

        // Allow the player to buy items from the shop
        public static void OpenShop()
        {
            bool isShopping = true;

            while (isShopping)
            {
                Console.Clear();
                Console.WriteLine($"Welcome to the Shop! You have {GameManager.PokeCoins} Poké Coins.\n");
                Console.WriteLine("Available items for sale:");
                foreach (var item in ItemPrices)
                {
                    Console.WriteLine($"{item.Key}: {item.Value} Poké Coins");
                }
                Console.WriteLine("\nEnter the name of the item you'd like to buy, or type 'exit' to leave the shop.");
                Console.Write("Your choice: ");
                string itemName = Console.ReadLine()?.Trim();

                if (string.Equals(itemName, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Thank you for visiting the shop!");
                    isShopping = false;
                }
                else if (ItemPrices.ContainsKey(itemName))
                {
                    int price = ItemPrices[itemName];
                    if (GameManager.PokeCoins >= price)
                    {
                        GameManager.DeductCoins(price);
                        GameManager.AddItemToBag(itemName, 1); // Add 1 item to the bag
                        Console.WriteLine($"You bought a {itemName} for {price} Poké Coins.");
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough Poké Coins for that item!");
                    }
                }
                else
                {
                    Console.WriteLine("Item not available.");
                }

                // Shop loop exits without pause; Program.cs handles centralized pause
            }
        }
    }
}

using System;

namespace PokemonArcade
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager.Initialize();
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine($"Trainer {GameManager.Avatar}, you have {GameManager.PokeCoins} Poké Coins.");
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Play Poké Slot");
                Console.WriteLine("2. Play Seek n' Catch");
                Console.WriteLine("3. Play Fire, Water, Grass");
                Console.WriteLine("4. Play Who's That Pokémon");
                Console.WriteLine("5. View Leaderboard");
                Console.WriteLine("6. Exit Game");

                // Show advanced options if the player is licensed
                if (GameManager.IsLicensed)
                {
                    Console.WriteLine("7. View Coins");

                    if (GameManager.Team.Count == 0) // Show "Choose Starter" only if no starter is chosen
                    {
                        Console.WriteLine("8. Choose Starter");
                    }

                    Console.WriteLine("9. View Team");
                    Console.WriteLine("10. View Storage");
                    Console.WriteLine("11. View Bag");
                    Console.WriteLine("12. Visit Shop");

                    // Show Pokédex option if the Trainer has received their license and starter
                    if (GameManager.HasPokedex)
                    {
                        Console.WriteLine("13. View Pokédex");
                    }
                }

                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PokeSlot.Play();
                        break;
                    case "2":
                        SeekNCatch.Play();
                        break;
                    case "3":
                        FireWaterGrass.Play();
                        break;
                    case "4":
                        WhosThatPokemon.Play();
                        break;
                    case "5":
                        GameManager.DisplayLeaderboard();
                        break;
                    case "6":
                        isRunning = false;
                        Console.WriteLine("Thank you for playing! Goodbye!");
                        break;
                    case "7":
                        if (GameManager.IsLicensed)
                            ViewCoins.Display();
                        else
                            Console.WriteLine("You need a Trainer License to access this feature!");
                        break;
                    case "8":
                        if (GameManager.IsLicensed && GameManager.Team.Count == 0)
                        {
                            ChooseStarter.Choose();
                        }
                        else
                        {
                            Console.WriteLine("You need a Trainer License and have not yet chosen a starter!");
                        }
                        break;
                    case "9":
                        if (GameManager.IsLicensed)
                            ViewTeam.Display();
                        else
                            Console.WriteLine("You need a Trainer License to access this feature!");
                        break;
                    case "10":
                        if (GameManager.IsLicensed)
                            ViewStorage.Display();
                        else
                            Console.WriteLine("You need a Trainer License to access this feature!");
                        break;
                    case "11":
                        if (GameManager.IsLicensed)
                            GameManager.DisplayBag();
                        else
                            Console.WriteLine("You need a Trainer License to access this feature!");
                        break;
                    case "12":
                        if (GameManager.IsLicensed)
                            Shop.OpenShop();
                        else
                            Console.WriteLine("You need a Trainer License to access the Shop!");
                        break;
                    case "13":
                        if (GameManager.HasPokedex)
                        {
                            PokedexManager.DisplayPokedex();
                        }
                        else
                        {
                            Console.WriteLine("Pokédex is locked! You need to choose your starter Pokémon and obtain a Trainer License.");
                            Console.ReadKey();
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option! Please try again.");
                        break;
                }

                // Grant Trainer License after reaching 50 Poké Coins
                if (GameManager.PokeCoins >= 50 && !GameManager.IsLicensed)
                {
                    GameManager.GrantTrainerLicense(); // Call to grant license and bonus coins
                    GameManager.IsLicensed = true;
                }

                // Pause after each action, controlled centrally here
                if (isRunning)
                    GameManager.PauseBeforeMenu();
            }
        }
    }
}

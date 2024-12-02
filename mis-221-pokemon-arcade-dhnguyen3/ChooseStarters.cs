namespace PokemonArcade
{
    public class ChooseStarter
    {
        public static void Choose()
        {
            // Professor Lucas Introduction
            DisplayDialogue("Professor Lucas: Hello there! Welcome to the world of Pokémon!");
            DisplayDialogue("Professor Lucas: My name is Professor Jeff Lucas, but everyone calls me Professor Lucas!");
            DisplayDialogue("Professor Lucas: This world is inhabited by creatures called Pokémon.");
            DisplayDialogue("Professor Lucas: For some people, Pokémon are pets. Others use them for battles.");
            DisplayDialogue("Professor Lucas: As for myself, I study Pokémon as my profession.");

            // Ask for rival's name
            DisplayDialogue("Professor Lucas: But before we begin, I have a question for you.");
            DisplayDialogue("Professor Lucas: Do you remember your rival? What was their name again?");

            Console.WriteLine("Enter your rival's name: ");
            string rivalName = Console.ReadLine();
            if (string.IsNullOrEmpty(rivalName))
            {
                rivalName = "Rival"; // Default name if none provided
            }

            GameManager.RivalName = rivalName;
            DisplayDialogue($"Professor Lucas: Ah, yes! Your rival’s name is {GameManager.RivalName}. How could I forget?");

            // Transition to choosing a starter Pokémon
            DisplayDialogue("Professor Lucas: Now, you're about to begin your journey as a Pokémon Trainer.");
            DisplayDialogue("Professor Lucas: To start your journey, you need your very first Pokémon!");

            // Display starter Pokémon options directly in the dialogue
            List<string> starters = new List<string> { "1. Bulbasaur", "2. Charmander", "3. Squirtle" };
            DisplayDialogueWithOptions(
                "Professor Lucas: I have three wonderful Pokémon for you to choose from.\nPlease choose your starter Pokémon:",
                starters
            );

            Console.Write("\nEnter the number of the Pokémon you'd like to choose: ");
            string input = Console.ReadLine();
            int choice;

            if (int.TryParse(input, out choice) && choice > 0 && choice <= starters.Count)
            {
                string chosenStarter = starters[choice - 1].Split(". ")[1]; // Extract Pokémon name
                GameManager.Team.Add(chosenStarter); // Add the chosen Pokémon to the player's team
                DisplayDialogue($"Professor Lucas: Congratulations! You chose {chosenStarter} as your starter Pokémon!");

                // Display and add the chosen starter's Pokédex entry
                AddPokedexEntry(chosenStarter);
            }
            else
            {
                DisplayDialogue("Professor Lucas: Hmm, it seems you didn’t make a choice. No Pokémon was selected.");
            }
        }

        // Helper method for displaying dialogue with a clear console
        private static void DisplayDialogue(string message)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0); // Reset cursor to the top
            Console.WriteLine(message);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        // Helper method for displaying dialogue with options and a clear console
        private static void DisplayDialogueWithOptions(string message, List<string> options)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0); // Reset cursor to the top
            Console.WriteLine(message);
            foreach (var option in options)
            {
                Console.WriteLine(option);
            }
            Console.WriteLine();
        }

        // Add the selected Pokémon's entry to the Pokédex
        private static void AddPokedexEntry(string chosenStarter)
        {
            if (chosenStarter == "Bulbasaur")
            {
                // Add Bulbasaur's entry
                PokemonData bulbasaur = new PokemonData(
                    "Bulbasaur",
                    "#001",
                    "Grass/Poison",
                    "Seed Pokémon",
                    "0.7 m (2' 4\")",
                    "6.9 kg (15.2 lbs)",
                    "Bulbasaur uses its plant-based bulb to absorb sunlight and grow."
                );
                GameManager.AddPokemonToPokedex(bulbasaur);
                DisplayPokedexEntry(bulbasaur);
            }
            else if (chosenStarter == "Charmander")
            {
                // Add Charmander's entry
                PokemonData charmander = new PokemonData(
                    "Charmander",
                    "#004",
                    "Fire",
                    "Lizard Pokémon",
                    "0.6 m (2' 1\")",
                    "8.5 kg (18.7 lbs)",
                    "The flame on its tail shows the strength of its life force. If it is weak, the flame also burns weakly."
                );
                GameManager.AddPokemonToPokedex(charmander);
                DisplayPokedexEntry(charmander);
            }
            else if (chosenStarter == "Squirtle")
            {
                // Add Squirtle's entry
                PokemonData squirtle = new PokemonData(
                    "Squirtle",
                    "#007",
                    "Water",
                    "Tiny Turtle Pokémon",
                    "0.5 m (1' 8\")",
                    "9.0 kg (19.8 lbs)",
                    "Squirtle uses its shell to protect itself. It can shoot water from its mouth."
                );
                GameManager.AddPokemonToPokedex(squirtle);
                DisplayPokedexEntry(squirtle);
            }
        }

        // Display the Pokédex entry for the chosen starter Pokémon
        private static void DisplayPokedexEntry(PokemonData pokemon)
        {
            Console.Clear();
            Console.WriteLine("Pokédex Entry:");
            pokemon.DisplayInfo();
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}

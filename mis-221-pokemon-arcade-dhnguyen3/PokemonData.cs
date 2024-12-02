namespace PokemonArcade
{
    public class PokemonData
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }
        public string Species { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string FunFact { get; set; }

        public PokemonData(string name, string number, string type, string species, string height, string weight, string funFact)
        {
            Name = name;
            Number = number;
            Type = type;
            Species = species;
            Height = height;
            Weight = weight;
            FunFact = funFact;
        }

        // Display the Pokémon data
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Number: {Number}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Fun Fact: {FunFact}");
        }
    }
}

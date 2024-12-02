namespace PokemonArcade
{
    public static class PokedexData
    {
        public static List<PokemonData> PokemonList { get; private set; } = new();

        static PokedexData()
        {
            // Prepopulate the Pokémon list with data for the first 151 Pokémon

            // Generation 1 Pokémon
            PokemonList.Add(new PokemonData("Bulbasaur", "#001", "Grass/Poison", "Seed Pokémon", "0.7 m (2' 4\")", "6.9 kg (15.2 lbs)", "Bulbasaur uses its plant-based bulb to absorb sunlight and grow."));
            PokemonList.Add(new PokemonData("Ivysaur", "#002", "Grass/Poison", "Seed Pokémon", "1.0 m (3' 3\")", "13.0 kg (28.7 lbs)", "Ivysaur is the evolved form of Bulbasaur and has a blooming flower on its back."));
            PokemonList.Add(new PokemonData("Venusaur", "#003", "Grass/Poison", "Flower Pokémon", "2.0 m (6' 7\")", "100.0 kg (220.5 lbs)", "Venusaur has a massive flower that can release toxic pollen."));

            PokemonList.Add(new PokemonData("Charmander", "#004", "Fire", "Lizard Pokémon", "0.6 m (2' 1\")", "8.5 kg (18.7 lbs)", "The flame on its tail shows the strength of its life force. If it is weak, the flame also burns weakly."));
            PokemonList.Add(new PokemonData("Charmeleon", "#005", "Fire", "Flame Pokémon", "1.1 m (3' 7\")", "19.0 kg (41.9 lbs)", "Charmeleon is the evolved form of Charmander, known for its fiery temperament."));
            PokemonList.Add(new PokemonData("Charizard", "#006", "Fire/Flying", "Flame Pokémon", "1.7 m (5' 7\")", "90.5 kg (199.5 lbs)", "Charizard is a powerful and fierce fire-breathing dragon-like Pokémon."));

            PokemonList.Add(new PokemonData("Squirtle", "#007", "Water", "Tiny Turtle Pokémon", "0.5 m (1' 8\")", "9.0 kg (19.8 lbs)", "Squirtle uses its shell to protect itself. It can shoot water from its mouth."));
            PokemonList.Add(new PokemonData("Wartortle", "#008", "Water", "Turtle Pokémon", "1.0 m (3' 3\")", "22.5 kg (49.6 lbs)", "Wartortle has a long tail, and it fights fiercely when protecting itself."));
            PokemonList.Add(new PokemonData("Blastoise", "#009", "Water", "Shellfish Pokémon", "1.6 m (5' 3\")", "85.5 kg (188.5 lbs)", "Blastoise is known for the massive water cannons on its back."));

            // Generation 1 Bug Pokémon
            PokemonList.Add(new PokemonData("Caterpie", "#010", "Bug", "Worm Pokémon", "0.3 m (1' 0\")", "2.9 kg (6.4 lbs)", "Caterpie is the first Bug-type Pokémon in the National Pokédex."));
            PokemonList.Add(new PokemonData("Metapod", "#011", "Bug", "Cocoon Pokémon", "0.7 m (2' 4\")", "9.9 kg (21.8 lbs)", "Metapod is the cocoon stage of Caterpie, preparing to evolve into Butterfree."));
            PokemonList.Add(new PokemonData("Butterfree", "#012", "Bug/Flying", "Butterfly Pokémon", "1.1 m (3' 7\")", "32.0 kg (70.5 lbs)", "Butterfree evolves from Metapod and can fly gracefully with its large wings."));

            // Generation 1 Regional Bird Pokemon
            PokemonList.Add(new PokemonData("Pidgey", "#016", "Normal/Flying", "Tiny Bird Pokémon", "0.3 m (1' 0\")", "1.8 kg (4.0 lbs)", "Pidgey is a small, bird Pokémon that can be found in forests."));
            PokemonList.Add(new PokemonData("Pidgeotto", "#017", "Normal/Flying", "Bird Pokémon", "0.9 m (3' 0\")", "30.0 kg (66.1 lbs)", "Pidgeotto evolves from Pidgey and has a stronger build."));
            PokemonList.Add(new PokemonData("Pidgeot", "#018", "Normal/Flying", "Bird Pokémon", "1.5 m (4' 11\")", "39.5 kg (87.1 lbs)", "Pidgeot is the final evolution of Pidgey, known for its swift flying speed."));

            // Generation 1 Early Game Pokémon
            PokemonList.Add(new PokemonData("Rattata", "#019", "Normal", "Mouse Pokémon", "0.3 m (1' 0\")", "3.5 kg (7.7 lbs)", "Rattata is a common Pokémon known for its speed."));
            PokemonList.Add(new PokemonData("Raticate", "#020", "Normal", "Mouse Pokémon", "0.7 m (2' 4\")", "18.5 kg (40.8 lbs)", "Raticate evolves from Rattata and is known for its sharp teeth."));
            PokemonList.Add(new PokemonData("Spearow", "#021", "Normal/Flying", "Tiny Bird Pokémon", "0.3 m (1' 0\")", "2.0 kg (4.4 lbs)", "Spearow is a small, aggressive bird Pokémon."));
            PokemonList.Add(new PokemonData("Fearow", "#022", "Normal/Flying", "Beak Pokémon", "1.2 m (3' 11\")", "38.0 kg (83.8 lbs)", "Fearow is the evolved form of Spearow, with a long, sharp beak."));
            PokemonList.Add(new PokemonData("Ekans", "#023", "Poison", "Snake Pokémon", "2.0 m (6' 7\")", "6.9 kg (15.2 lbs)", "Ekans slithers and strikes with its venomous bite, known to surprise unsuspecting victims."));
            PokemonList.Add(new PokemonData("Arbok", "#024", "Poison", "Cobra Pokémon", "3.5 m (11' 6\")", "65.0 kg (143.3 lbs)", "Arbok's hood can expand to intimidate its foes and make them retreat."));
            PokemonList.Add(new PokemonData("Pikachu", "#025", "Electric", "Mouse Pokémon", "0.4 m (1' 4\")", "6.0 kg (13.2 lbs)", "Pikachu generates electricity in its cheeks and releases it in powerful electric blasts."));
            PokemonList.Add(new PokemonData("Raichu", "#026", "Electric", "Mouse Pokémon", "0.8 m (2' 7\")", "30.0 kg (66.1 lbs)", "Raichu evolves from Pikachu and is capable of delivering intense electric shocks."));
            PokemonList.Add(new PokemonData("Sandshrew", "#027", "Ground", "Mouse Pokémon", "0.6 m (2' 0\")", "12.0 kg (26.5 lbs)", "Sandshrew burrows underground to avoid the heat and predators."));
            PokemonList.Add(new PokemonData("Sandslash", "#028", "Ground", "Mouse Pokémon", "1.0 m (3' 3\")", "29.5 kg (65.0 lbs)", "Sandslash uses its sharp claws to dig through the ground and find food."));
            PokemonList.Add(new PokemonData("Nidoran♀", "#029", "Poison", "Poison Pin Pokémon", "0.4 m (1' 4\")", "7.0 kg (15.4 lbs)", "Nidoran♀ has sharp spines on its back that can be used to defend itself against threats."));
            PokemonList.Add(new PokemonData("Nidorina", "#030", "Poison", "Poison Pin Pokémon", "0.8 m (2' 7\")", "20.0 kg (44.1 lbs)", "Nidorina is stronger and more aggressive than its earlier form, Nidoran♀."));
            PokemonList.Add(new PokemonData("Nidoqueen", "#031", "Poison/Ground", "Mother Pokémon", "1.3 m (4' 3\")", "60.0 kg (132.3 lbs)", "Nidoqueen is known for its defensive strength and maternal instincts to protect its young."));
            PokemonList.Add(new PokemonData("Nidoran♂", "#032", "Poison", "Poison Pin Pokémon", "0.5 m (1' 8\")", "9.0 kg (19.8 lbs)", "Nidoran♂ is quick and agile, often seen defending its territory fiercely."));
            PokemonList.Add(new PokemonData("Nidorino", "#033", "Poison", "Poison Pin Pokémon", "0.9 m (3' 0\")", "19.5 kg (43.0 lbs)", "Nidorino is often seen in battles, utilizing its strong horns to defeat opponents."));
            PokemonList.Add(new PokemonData("Nidoking", "#034", "Poison/Ground", "Drill Pokémon", "1.4 m (4' 7\")", "62.0 kg (136.7 lbs)", "Nidoking is a powerful Pokémon that uses its horns and brute strength in combat."));
            PokemonList.Add(new PokemonData("Clefairy", "#035", "Fairy", "Fairy Pokémon", "0.6 m (2' 0\")", "7.5 kg (16.5 lbs)", "Clefairy is known for its quiet and gentle nature, often seen in the moonlight."));
            PokemonList.Add(new PokemonData("Clefable", "#036", "Fairy", "Fairy Pokémon", "1.3 m (4' 3\")", "40.0 kg (88.2 lbs)", "Clefable is able to use the moonlight to heal and replenish its energy."));
            PokemonList.Add(new PokemonData("Vulpix", "#037", "Fire", "Fox Pokémon", "0.6 m (2' 0\")", "9.9 kg (21.8 lbs)", "Vulpix uses its flame to fend off predators and warm its surroundings."));
            PokemonList.Add(new PokemonData("Ninetales", "#038", "Fire", "Fox Pokémon", "1.1 m (3' 7\")", "19.9 kg (43.9 lbs)", "Ninetales uses its mystical powers to manipulate fire and deceive its enemies."));
            PokemonList.Add(new PokemonData("Jigglypuff", "#039", "Fairy", "Balloon Pokémon", "0.5 m (1' 8\")", "5.5 kg (12.1 lbs)", "Jigglypuff uses its song to put others to sleep and inflate its body to float."));
            PokemonList.Add(new PokemonData("Wigglytuff", "#040", "Fairy", "Balloon Pokémon", "1.0 m (3' 3\")", "12.0 kg (26.5 lbs)", "Wigglytuff can use its powerful song to lull opponents into a deep sleep."));
            PokemonList.Add(new PokemonData("Zubat", "#041", "Poison/Flying", "Bat Pokémon", "0.8 m (2' 7\")", "7.5 kg (16.5 lbs)", "Zubat uses its strong wings to fly and its ultrasonic cries to find prey."));
            PokemonList.Add(new PokemonData("Golbat", "#042", "Poison/Flying", "Bat Pokémon", "1.6 m (5' 3\")", "55.0 kg (121.3 lbs)", "Golbat is known for its aggressive behavior and its large mouth, which it uses to feed."));
            PokemonList.Add(new PokemonData("Oddish", "#043", "Grass/Poison", "Weed Pokémon", "0.5 m (1' 8\")", "5.4 kg (11.9 lbs)", "Oddish blooms at night and has a calming scent that lulls opponents to sleep."));
            PokemonList.Add(new PokemonData("Gloom", "#044", "Grass/Poison", "Weed Pokémon", "0.8 m (2' 7\")", "8.6 kg (19.0 lbs)", "Gloom releases a strong, foul odor to repel threats and predators."));
            PokemonList.Add(new PokemonData("Vileplume", "#045", "Grass/Poison", "Flower Pokémon", "1.2 m (3' 11\")", "18.6 kg (41.0 lbs)", "Vileplume can release an odor so powerful that it causes dizziness in opponents."));
            PokemonList.Add(new PokemonData("Paras", "#046", "Bug/Grass", "Mushroom Pokémon", "0.3 m (1' 0\")", "5.4 kg (11.9 lbs)", "Paras has mushrooms growing on its back that are used to attack or defend itself."));
            PokemonList.Add(new PokemonData("Parasect", "#047", "Bug/Grass", "Mushroom Pokémon", "1.0 m (3' 3\")", "29.5 kg (65.0 lbs)", "Parasect is known for its ability to use the mushrooms on its back for offensive and defensive purposes."));
            PokemonList.Add(new PokemonData("Venonat", "#048", "Bug/Poison", "Insect Pokémon", "0.6 m (2' 0\")", "30.0 kg (66.1 lbs)", "Venonat's large eyes are used to detect even the smallest movements in its surroundings."));
            PokemonList.Add(new PokemonData("Venomoth", "#049", "Bug/Poison", "Moth Pokémon", "1.5 m (4' 11\")", "12.5 kg (27.6 lbs)", "Venomoth's wings contain toxins that can paralyze its prey."));
            PokemonList.Add(new PokemonData("Diglett", "#050", "Ground", "Mole Pokémon", "0.2 m (0' 8\")", "0.8 kg (1.8 lbs)", "Diglett digs underground to avoid predators and find food."));
            PokemonList.Add(new PokemonData("Dugtrio", "#051", "Ground", "Mole Pokémon", "0.8 m (2' 7\")", "33.3 kg (73.4 lbs)", "Dugtrio is known for its ability to tunnel through the ground with great speed."));
            PokemonList.Add(new PokemonData("Meowth", "#052", "Normal", "Scratch Cat Pokémon", "0.4 m (1' 4\")", "4.2 kg (9.2 lbs)", "Meowth is a mischievous Pokémon that loves to steal things and is famous for its iconic 'Pay Day' move."));
            PokemonList.Add(new PokemonData("Persian", "#053", "Normal", "Classy Cat Pokémon", "1.0 m (3' 3\")", "32.0 kg (70.5 lbs)", "Persian is a proud and elegant Pokémon, known for its smooth, luxurious fur."));
            PokemonList.Add(new PokemonData("Psyduck", "#054", "Water", "Duck Pokémon", "0.8 m (2' 7\")", "19.6 kg (43.2 lbs)", "Psyduck suffers from constant headaches that cause it to occasionally unleash strong psychic powers."));
            PokemonList.Add(new PokemonData("Golduck", "#055", "Water", "Duck Pokémon", "1.7 m (5' 7\")", "76.6 kg (168.6 lbs)", "Golduck can swim at incredible speeds and use its psychic powers in combat."));
            PokemonList.Add(new PokemonData("Mankey", "#056", "Fighting", "Pig Monkey Pokémon", "0.5 m (1' 8\")", "28.0 kg (61.7 lbs)", "Mankey is highly territorial and becomes enraged easily, often attacking when provoked."));
            PokemonList.Add(new PokemonData("Primeape", "#057", "Fighting", "Pig Monkey Pokémon", "1.0 m (3' 3\")", "32.0 kg (70.5 lbs)", "Primeape is a violent Pokémon that is quick to attack when angered."));
            PokemonList.Add(new PokemonData("Growlithe", "#058", "Fire", "Puppy Pokémon", "0.6 m (2' 0\")", "19.0 kg (41.9 lbs)", "Growlithe is loyal and brave, and is often seen guarding its trainer."));
            PokemonList.Add(new PokemonData("Arcanine", "#059", "Fire", "Legendary Pokémon", "1.9 m (6' 3\")", "155.0 kg (341.7 lbs)", "Arcanine is known for its speed and courage, often seen as a symbol of strength."));
            PokemonList.Add(new PokemonData("Poliwag", "#060", "Water", "Tadpole Pokémon", "0.6 m (2' 0\")", "12.4 kg (27.4 lbs)", "Poliwag's tail is a powerful tool for swimming in water."));
            PokemonList.Add(new PokemonData("Poliwhirl", "#061", "Water", "Tadpole Pokémon", "1.0 m (3' 3\")", "20.0 kg (44.1 lbs)", "Poliwhirl's body is filled with water, which it uses to maintain its strong swimming ability."));
            PokemonList.Add(new PokemonData("Poliwrath", "#062", "Water/Fighting", "Tadpole Pokémon", "1.3 m (4' 3\")", "54.0 kg (119.1 lbs)", "Poliwrath is a powerful Pokémon that can fight using its muscular arms and high agility in water."));
            PokemonList.Add(new PokemonData("Abra", "#063", "Psychic", "Psi Pokémon", "0.9 m (3' 0\")", "19.5 kg (43.0 lbs)", "Abra is known for its ability to teleport and evade almost any attack with ease."));
            PokemonList.Add(new PokemonData("Kadabra", "#064", "Psychic", "Psi Pokémon", "1.3 m (4' 3\")", "56.5 kg (124.6 lbs)", "Kadabra is capable of powerful psychic moves and is known for its spoon manipulation."));
            PokemonList.Add(new PokemonData("Alakazam", "#065", "Psychic", "Psi Pokémon", "1.5 m (4' 11\")", "48.0 kg (105.8 lbs)", "Alakazam is a master of psychic power, able to perform feats of great mental strength."));
            PokemonList.Add(new PokemonData("Machop", "#066", "Fighting", "Superpower Pokémon", "0.8 m (2' 7\")", "19.5 kg (43.0 lbs)", "Machop is incredibly strong and uses its muscles to perform powerful physical attacks."));
            PokemonList.Add(new PokemonData("Machoke", "#067", "Fighting", "Superpower Pokémon", "1.3 m (4' 3\")", "70.5 kg (155.5 lbs)", "Machoke is known for its impressive strength and its ability to battle through sheer muscle power."));
            PokemonList.Add(new PokemonData("Machamp", "#068", "Fighting", "Superpower Pokémon", "1.6 m (5' 3\")", "130.0 kg (286.6 lbs)", "Machamp is a powerhouse, with unmatched physical strength and battle prowess."));
            PokemonList.Add(new PokemonData("Bellsprout", "#069", "Grass/Poison", "Flower Pokémon", "0.7 m (2' 4\")", "4.0 kg (8.8 lbs)", "Bellsprout's vines are used to capture prey and fight off attackers."));
            PokemonList.Add(new PokemonData("Weepinbell", "#070", "Grass/Poison", "Flycatcher Pokémon", "1.0 m (3' 3\")", "6.4 kg (14.1 lbs)", "Weepinbell uses its vine-like body to catch prey and protect itself from danger."));
            PokemonList.Add(new PokemonData("Victreebel", "#071", "Grass/Poison", "Flycatcher Pokémon", "1.7 m (5' 7\")", "15.5 kg (34.2 lbs)", "Victreebel uses its bell-shaped body to trap and digest prey."));
            PokemonList.Add(new PokemonData("Tentacool", "#072", "Water/Poison", "Jellyfish Pokémon", "0.9 m (3' 0\")", "35.0 kg (77.2 lbs)", "Tentacool's jelly-like body allows it to glide through the water effortlessly."));
            PokemonList.Add(new PokemonData("Tentacruel", "#073", "Water/Poison", "Jellyfish Pokémon", "1.6 m (5' 3\")", "55.0 kg (121.3 lbs)", "Tentacruel's tentacles are capable of paralyzing opponents and can cause extreme pain."));
            PokemonList.Add(new PokemonData("Geodude", "#074", "Rock/Ground", "Rock Pokémon", "0.4 m (1' 4\")", "20.0 kg (44.1 lbs)", "Geodude uses its body to smash through obstacles and defend itself from predators."));
            PokemonList.Add(new PokemonData("Graveler", "#075", "Rock/Ground", "Rock Pokémon", "1.0 m (3' 3\")", "105.0 kg (231.5 lbs)", "Graveler is strong and durable, using its rocky body to overpower foes."));
            PokemonList.Add(new PokemonData("Golem", "#076", "Rock/Ground", "Megaton Pokémon", "1.4 m (4' 7\")", "300.0 kg (661.4 lbs)", "Golem is powerful, capable of causing tremors and avalanches with its massive body."));
            PokemonList.Add(new PokemonData("Ponyta", "#077", "Fire", "Fire Horse Pokémon", "1.0 m (3' 3\")", "30.0 kg (66.1 lbs)", "Ponyta's mane and tail are made of flames that it can control at will."));
            PokemonList.Add(new PokemonData("Rapidash", "#078", "Fire", "Fire Horse Pokémon", "1.7 m (5' 7\")", "95.0 kg (209.4 lbs)", "Rapidash's blazing speed allows it to outrun almost anything in its path."));
            PokemonList.Add(new PokemonData("Slowpoke", "#079", "Water/Psychic", "Dopey Pokémon", "1.2 m (3' 11\")", "36.0 kg (79.4 lbs)", "Slowpoke's relaxed nature makes it one of the slowest Pokémon, though it can unleash powerful psychic attacks."));
            PokemonList.Add(new PokemonData("Slowbro", "#080", "Water/Psychic", "Hermit Crab Pokémon", "1.6 m (5' 3\")", "78.5 kg (173.6 lbs)", "Slowbro's shell acts as a defensive barrier and helps it use powerful psychic abilities."));
            PokemonList.Add(new PokemonData("Magnemite", "#081", "Electric/Steel", "Magnet Pokémon", "0.3 m (1' 0\")", "6.0 kg (13.2 lbs)", "Magnemite is drawn to metal and often clings to steel objects to stay grounded."));
            PokemonList.Add(new PokemonData("Magneton", "#082", "Electric/Steel", "Magnet Pokémon", "1.0 m (3' 3\")", "60.0 kg (132.3 lbs)", "Magneton uses its magnetic powers to attract and repel other metal objects."));
            PokemonList.Add(new PokemonData("Farfetch’d", "#083", "Normal/Flying", "Wild Duck Pokémon", "0.6 m (2' 0\")", "5.0 kg (11.0 lbs)", "Farfetch’d carries a leek and uses it to attack its foes with quick slashes."));
            PokemonList.Add(new PokemonData("Doduo", "#084", "Normal/Flying", "Twin Bird Pokémon", "1.4 m (4' 7\")", "39.2 kg (86.4 lbs)", "Doduo is a two-headed bird that can run at speeds up to 60 mph."));
            PokemonList.Add(new PokemonData("Dodrio", "#085", "Normal/Flying", "Tri Bird Pokémon", "1.8 m (5' 11\")", "85.2 kg (187.7 lbs)", "Dodrio's three heads can communicate and coordinate attacks effortlessly."));
            PokemonList.Add(new PokemonData("Seel", "#086", "Water", "Sea Lion Pokémon", "1.1 m (3' 7\")", "90.0 kg (198.4 lbs)", "Seel is known for its ability to swim at great depths and its playful nature."));
            PokemonList.Add(new PokemonData("Dewgong", "#087", "Water/Ice", "Sea Lion Pokémon", "1.7 m (5' 7\")", "120.0 kg (264.5 lbs)", "Dewgong uses its sleek body to glide effortlessly through icy waters."));
            PokemonList.Add(new PokemonData("Grimer", "#088", "Poison", "Sludge Pokémon", "0.9 m (3' 0\")", "30.0 kg (66.1 lbs)", "Grimer is a sticky, smelly creature that thrives in polluted areas."));
            PokemonList.Add(new PokemonData("Muk", "#089", "Poison", "Sludge Pokémon", "1.2 m (3' 11\")", "30.0 kg (66.1 lbs)", "Muk can dissolve almost anything with its powerful acidic body."));
            PokemonList.Add(new PokemonData("Shellder", "#090", "Water", "Bivalve Pokémon", "0.3 m (1' 0\")", "4.0 kg (8.8 lbs)", "Shellder’s hard shell helps protect it from predators and environmental hazards."));
            PokemonList.Add(new PokemonData("Cloyster", "#091", "Water/Ice", "Bivalve Pokémon", "1.5 m (4' 11\")", "55.0 kg (121.3 lbs)", "Cloyster can shoot ice-cold water to freeze anything in its path."));
           
           // Generation 1 Ghost Pokémon
            PokemonList.Add(new PokemonData("Gastly", "#092", "Ghost/Poison", "Gas Pokémon", "1.3 m (4' 3\")", "0.1 kg (0.2 lbs)", "Gastly is a ghostly Pokémon that can pass through walls and slip away unnoticed."));
            PokemonList.Add(new PokemonData("Haunter", "#093", "Ghost/Poison", "Gas Pokémon", "1.6 m (5' 3\")", "0.1 kg (0.2 lbs)", "Haunter is known for its mischievous nature and ability to haunt and scare people."));
            PokemonList.Add(new PokemonData("Gengar", "#094", "Ghost/Poison", "Shadow Pokémon", "1.5 m (4' 11\")", "40.5 kg (89.5 lbs)", "Gengar is a playful, yet dangerous ghost Pokémon that loves to prank its foes."));
            
            PokemonList.Add(new PokemonData("Onix", "#095", "Rock/Ground", "Rock Snake Pokémon", "8.8 m (28' 10\")", "210.0 kg (463.0 lbs)", "Onix is known for its massive size and powerful strength, using its body to crush opponents."));
            PokemonList.Add(new PokemonData("Drowzee", "#096", "Psychic", "Hypnosis Pokémon", "0.9 m (3' 0\")", "32.4 kg (71.4 lbs)", "Drowzee uses its psychic powers to hypnotize its prey and put them into a trance."));
            PokemonList.Add(new PokemonData("Hypno", "#097", "Psychic", "Hypnosis Pokémon", "1.6 m (5' 3\")", "75.6 kg (166.7 lbs)", "Hypno is known for its ability to hypnotize others and control their minds."));
            PokemonList.Add(new PokemonData("Krabby", "#098", "Water", "Tiny Crab Pokémon", "0.4 m (1' 4\")", "6.5 kg (14.3 lbs)", "Krabby uses its powerful claws to catch food and defend itself."));
            PokemonList.Add(new PokemonData("Kingler", "#099", "Water", "King Crab Pokémon", "1.3 m (4' 3\")", "60.0 kg (132.3 lbs)", "Kingler is known for its large, powerful claws that can crush anything it holds."));
            PokemonList.Add(new PokemonData("Voltorb", "#100", "Electric", "Ball Pokémon", "0.5 m (1' 8\")", "10.4 kg (22.9 lbs)", "Voltorb is capable of generating electricity and exploding on contact."));
            PokemonList.Add(new PokemonData("Electrode", "#101", "Electric", "Ball Pokémon", "1.2 m (3' 11\")", "66.0 kg (145.5 lbs)", "Electrode can roll at high speeds and discharge electricity when threatened."));
            PokemonList.Add(new PokemonData("Exeggcute", "#102", "Grass/Psychic", "Egg Pokémon", "0.4 m (1' 4\")", "2.5 kg (5.5 lbs)", "Exeggcute has psychic abilities and can communicate telepathically."));
            PokemonList.Add(new PokemonData("Exeggutor", "#103", "Grass/Psychic", "Coconut Pokémon", "2.0 m (6' 7\")", "120.0 kg (264.5 lbs)", "Exeggutor can use psychic powers to manipulate the environment around it."));
            PokemonList.Add(new PokemonData("Cubone", "#104", "Ground", "Lonely Pokémon", "0.4 m (1' 4\")", "6.5 kg (14.3 lbs)", "Cubone wears its deceased mother's skull to protect itself from predators."));
            PokemonList.Add(new PokemonData("Marowak", "#105", "Ground", "Bone Keeper Pokémon", "1.0 m (3' 3\")", "45.0 kg (99.2 lbs)", "Marowak is a skilled fighter that uses its bone as a weapon to defeat opponents."));
            PokemonList.Add(new PokemonData("Hitmonlee", "#106", "Fighting", "Kicking Pokémon", "1.5 m (4' 11\")", "49.6 kg (109.7 lbs)", "Hitmonlee specializes in powerful kicking techniques and can stretch its legs to extreme lengths."));
            PokemonList.Add(new PokemonData("Hitmonchan", "#107", "Fighting", "Punching Pokémon", "1.4 m (4' 7\")", "50.2 kg (110.2 lbs)", "Hitmonchan is known for its boxing expertise and can throw powerful punches."));
            PokemonList.Add(new PokemonData("Lickitung", "#108", "Normal", "Licking Pokémon", "1.2 m (3' 11\")", "65.5 kg (144.4 lbs)", "Lickitung uses its long tongue to grab food and attack its opponents."));
            PokemonList.Add(new PokemonData("Koffing", "#109", "Poison", "Poison Gas Pokémon", "0.6 m (2' 0\")", "1.0 kg (2.2 lbs)", "Koffing releases toxic gas to defend itself and can cause sickness in its enemies."));
            PokemonList.Add(new PokemonData("Weezing", "#110", "Poison", "Poison Gas Pokémon", "1.2 m (3' 11\")", "9.5 kg (20.9 lbs)", "Weezing's body releases toxic fumes, and its gas clouds can paralyze its foes."));
            PokemonList.Add(new PokemonData("Rhyhorn", "#111", "Ground/Rock", "Spikes Pokémon", "0.8 m (2' 7\")", "10.0 kg (22.0 lbs)", "Rhyhorn is known for its toughness and its ability to break through solid obstacles with its horns."));
            PokemonList.Add(new PokemonData("Rhydon", "#112", "Ground/Rock", "Drill Pokémon", "1.0 m (3' 3\")", "120.0 kg (264.5 lbs)", "Rhydon is the first Pokémon to be discovered and is powerful enough to dig through mountains."));
            PokemonList.Add(new PokemonData("Chansey", "#113", "Normal", "Egg Pokémon", "1.1 m (3' 7\")", "34.6 kg (76.3 lbs)", "Chansey is a compassionate Pokémon that carries eggs for its allies and heals them with care."));
            PokemonList.Add(new PokemonData("Tangela", "#114", "Grass", "Vine Pokémon", "1.0 m (3' 3\")", "35.0 kg (77.2 lbs)", "Tangela's body is wrapped in thick vines that it uses to defend itself and entangle opponents."));
            PokemonList.Add(new PokemonData("Kangaskhan", "#115", "Normal", "Parent Pokémon", "2.2 m (7' 3\")", "80.0 kg (176.4 lbs)", "Kangaskhan is a protective parent, carrying its child in a pouch to keep it safe."));
            PokemonList.Add(new PokemonData("Horsea", "#116", "Water", "Dragon Pokémon", "0.4 m (1' 4\")", "8.0 kg (17.6 lbs)", "Horsea swims by twisting its body and can spray water from its snout."));
            PokemonList.Add(new PokemonData("Seadra", "#117", "Water", "Dragon Pokémon", "1.2 m (3' 11\")", "25.0 kg (55.1 lbs)", "Seadra is an elegant swimmer and is capable of releasing powerful jets of water."));
            PokemonList.Add(new PokemonData("Goldeen", "#118", "Water", "Fish Pokémon", "0.6 m (2' 0\")", "15.0 kg (33.1 lbs)", "Goldeen uses its fins to swim gracefully through the water."));
            PokemonList.Add(new PokemonData("Seaking", "#119", "Water", "Fish Pokémon", "1.3 m (4' 3\")", "39.0 kg (86.0 lbs)", "Seaking is known for its speed and agility, often found swimming in lakes and rivers."));
            PokemonList.Add(new PokemonData("Staryu", "#120", "Water", "Star Shape Pokémon", "0.8 m (2' 7\")", "34.5 kg (76.1 lbs)", "Staryu can regenerate its limbs and shines brightly at night."));
            PokemonList.Add(new PokemonData("Starmie", "#121", "Water/Psychic", "Mysterious Pokémon", "1.1 m (3' 7\")", "80.0 kg (176.4 lbs)", "Starmie has the ability to control the stars in the sky, and is known for its psychic powers."));
            PokemonList.Add(new PokemonData("Mr. Mime", "#122", "Psychic/Fairy", "Barrier Pokémon", "1.2 m (3' 11\")", "54.5 kg (120.2 lbs)", "Mr. Mime can create psychic barriers to protect itself and others from attacks."));
            PokemonList.Add(new PokemonData("Scyther", "#123", "Bug/Flying", "Mantis Pokémon", "1.5 m (4' 11\")", "56.0 kg (123.5 lbs)", "Scyther is a highly agile Pokémon known for its swift, sharp blades and flying skills."));
            PokemonList.Add(new PokemonData("Jynx", "#124", "Ice/Psychic", "Human Shape Pokémon", "1.4 m (4' 7\")", "40.5 kg (89.5 lbs)", "Jynx is known for its ability to freeze opponents with its icy touch and its hypnotic dance."));
            PokemonList.Add(new PokemonData("Electabuzz", "#125", "Electric", "Electric Pokémon", "1.1 m (3' 7\")", "30.0 kg (66.1 lbs)", "Electabuzz can generate and discharge high voltage electricity with its hands."));
            PokemonList.Add(new PokemonData("Magmar", "#126", "Fire", "Flame Pokémon", "1.3 m (4' 3\")", "44.5 kg (98.0 lbs)", "Magmar is known for its fiery body, capable of generating intense heat and flames."));
            PokemonList.Add(new PokemonData("Pinsir", "#127", "Bug", "Stag Beetle Pokémon", "1.5 m (4' 11\")", "55.0 kg (121.3 lbs)", "Pinsir is a fearsome Pokémon with powerful pincers that can crush anything in its path."));
            PokemonList.Add(new PokemonData("Tauros", "#128", "Normal", "Wild Bull Pokémon", "1.4 m (4' 7\")", "88.4 kg (194.1 lbs)", "Tauros is a wild, aggressive Pokémon that can charge at speeds over 30 mph."));
            PokemonList.Add(new PokemonData("Magikarp", "#129", "Water", "Fish Pokémon", "0.9 m (3' 0\")", "10.0 kg (22.0 lbs)", "Magikarp is weak and useless, but can evolve into the powerful Gyarados."));
            PokemonList.Add(new PokemonData("Gyarados", "#130", "Water/Flying", "Atrocious Pokémon", "6.5 m (21' 4\")", "235.0 kg (518.1 lbs)", "Gyarados is an incredibly powerful and destructive Pokémon known for its wrath."));
            PokemonList.Add(new PokemonData("Lapras", "#131", "Water/Ice", "Transport Pokémon", "2.5 m (8' 2\")", "220.0 kg (485.0 lbs)", "Lapras is a friendly Pokémon that is known for its ability to carry people across bodies of water."));
            PokemonList.Add(new PokemonData("Ditto", "#132", "Normal", "Transform Pokémon", "0.3 m (1' 0\")", "4.0 kg (8.8 lbs)", "Ditto can transform into any Pokémon it sees, mimicking their appearance and abilities."));
            
            // Generation 1 Eeveelution Pokémon
            PokemonList.Add(new PokemonData("Eevee", "#133", "Normal", "Evolution Pokémon", "0.3 m (1' 0\")", "6.5 kg (14.3 lbs)", "Eevee can evolve into multiple different forms depending on the conditions it faces."));
            PokemonList.Add(new PokemonData("Vaporeon", "#134", "Water", "Bubble Jet Pokémon", "1.0 m (3' 3\")", "29.0 kg (63.9 lbs)", "Vaporeon evolves from Eevee when exposed to a Water Stone, and has the ability to control water."));
            PokemonList.Add(new PokemonData("Jolteon", "#135", "Electric", "Lightning Pokémon", "0.8 m (2' 7\")", "24.5 kg (54.0 lbs)", "Jolteon evolves from Eevee when exposed to a Thunder Stone and can unleash powerful electric shocks."));
            PokemonList.Add(new PokemonData("Flareon", "#136", "Fire", "Flame Pokémon", "0.9 m (2' 11\")", "25.0 kg (55.1 lbs)", "Flareon evolves from Eevee when exposed to a Fire Stone, gaining immense heat in its body."));
            
            PokemonList.Add(new PokemonData("Porygon", "#137", "Normal", "Virtual Pokémon", "0.8 m (2' 7\")", "36.5 kg (80.5 lbs)", "Porygon is the first Pokémon created digitally, capable of switching between different forms."));
            
            // Generation 1 Fossil Pokémon
            PokemonList.Add(new PokemonData("Omanyte", "#138", "Rock/Water", "Spiral Pokémon", "0.4 m (1' 4\")", "7.5 kg (16.5 lbs)", "Omanyte has a spiral-shaped shell that it uses to swim through the ocean."));
            PokemonList.Add(new PokemonData("Omastar", "#139", "Rock/Water", "Spiral Pokémon", "1.0 m (3' 3\")", "35.0 kg (77.2 lbs)", "Omastar uses its shell for protection and can fire powerful jets of water at its foes."));
            PokemonList.Add(new PokemonData("Kabuto", "#140", "Rock/Water", "Shellfish Pokémon", "0.5 m (1' 8\")", "11.5 kg (25.4 lbs)", "Kabuto is a prehistoric Pokémon that hides in its shell for protection."));
            PokemonList.Add(new PokemonData("Kabutops", "#141", "Rock/Water", "Shellfish Pokémon", "1.3 m (4' 3\")", "40.5 kg (89.5 lbs)", "Kabutops is a fierce hunter, using its sharp claws to hunt down its prey."));
            PokemonList.Add(new PokemonData("Aerodactyl", "#142", "Rock/Flying", "Fossil Pokémon", "2.1 m (6' 11\")", "59.0 kg (130.1 lbs)", "Aerodactyl is a prehistoric flying Pokémon, capable of reaching high speeds while soaring."));
            
            PokemonList.Add(new PokemonData("Snorlax", "#143", "Normal", "Sleeping Pokémon", "2.1 m (6' 11\")", "460.0 kg (1014.0 lbs)", "Snorlax is a large Pokémon that sleeps for long periods of time and can be very difficult to wake up."));
            
            // Generation 1 Dragon Pokémon
            PokemonList.Add(new PokemonData("Dratini", "#147", "Dragon", "Dragon Pokémon", "1.8 m (5' 11\")", "3.3 kg (7.3 lbs)", "Dratini is a rare Dragon-type Pokémon that lives in clear, shallow rivers."));
            PokemonList.Add(new PokemonData("Dragonair", "#148", "Dragon", "Dragon Pokémon", "4.0 m (13' 1\")", "16.5 kg (36.4 lbs)", "Dragonair is a powerful Dragon-type Pokémon that can control the weather with its wings."));
            PokemonList.Add(new PokemonData("Dragonite", "#149", "Dragon/Flying", "Dragon Pokémon", "2.2 m (7' 3\")", "210.0 kg (463.0 lbs)", "Dragonite is a legendary Dragon Pokémon, known for its strength and ability to fly at high speeds."));
            
            // Generation 1 Legendary Pokémon
            PokemonList.Add(new PokemonData("Articuno", "#144", "Ice/Flying", "Freeze Pokémon", "1.7 m (5' 7\")", "55.4 kg (122.1 lbs)", "Articuno is one of the Legendary Birds, known for its freezing powers."));
            PokemonList.Add(new PokemonData("Zapdos", "#145", "Electric/Flying", "Electric Pokémon", "1.6 m (5' 3\")", "52.6 kg (116.8 lbs)", "Zapdos is one of the Legendary Birds, known for its electric abilities."));
            PokemonList.Add(new PokemonData("Moltres", "#146", "Fire/Flying", "Flame Pokémon", "1.6 m (5' 3\")", "60.0 kg (132.3 lbs)", "Moltres is one of the Legendary Birds, known for its fire abilities."));

            // Generation 1 Mythical Pokémon
            PokemonList.Add(new PokemonData("Mewtwo", "#150", "Psychic", "Genetic Pokémon", "2.0 m (6' 7\")", "122.0 kg (269.0 lbs)", "Mewtwo is a genetically engineered Pokémon created from Mew's DNA."));
            PokemonList.Add(new PokemonData("Mew", "#151", "Psychic", "New Species Pokémon", "0.4 m (1' 4\")", "4.0 kg (8.8 lbs)", "Mew is a rare and powerful Pokémon that contains the DNA of all other Pokémon."));
        }

        // Method to get Pokémon by their National Pokédex number
        public static PokemonData GetPokemonByName(string name)
        {
            return PokemonList.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        // Method to get Pokémon by their name
        public static PokemonData GetPokemonData(string name)
        {
            return PokemonList.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}

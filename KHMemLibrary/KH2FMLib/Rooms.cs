namespace KHMemLibrary.KH2FMLib
{
    public class Rooms
    {
        public static async Task<string[]> GetRoom(string world)
        {
            List<string> getroom = new List<string>();

            switch (world)
            {
                case "World Map":
                    getroom.Add("World Map");
                    break;

                case "Twilight Town":
                    getroom.Add("The Empty Realm");
                    getroom.Add("Roxas' Room");
                    getroom.Add("The Usual Spot");
                    getroom.Add("Back Alley");
                    getroom.Add("Sandlot");
                    getroom.Add("Sandlot");
                    getroom.Add("Market Street: Station Heights");
                    getroom.Add("Market Street: Tram Common");
                    getroom.Add("Station Plaza");
                    getroom.Add("Central Station");
                    getroom.Add("Sunset Terrace");
                    getroom.Add("Sunset Station");
                    getroom.Add("Sunset Hill");
                    getroom.Add("The Woods");
                    getroom.Add("The Old Mansion");
                    getroom.Add("Mansion: Foyer");
                    getroom.Add("Mansion: Dining Room");
                    getroom.Add("Mansion: Library");
                    getroom.Add("Mansion: The White Room");
                    getroom.Add("Mansion: Basement Hall");
                    getroom.Add("Mansion: Basement Hall");
                    getroom.Add("Mansion: Computer Room");
                    getroom.Add("Mansion: Basement Corridor");
                    getroom.Add("Mansion: Pod Room");
                    getroom.Add("On the Train");
                    getroom.Add("The Tower");
                    getroom.Add("Tower: Entryway");
                    getroom.Add("Tower: Sorcerer's Loft");
                    getroom.Add("Tower: Wardrobe");
                    getroom.Add("Tower: Star Chamber");
                    getroom.Add("Tower: Moon Chamber");
                    getroom.Add("Tower: Wayward Stairs");
                    getroom.Add("Station of Serenity");
                    getroom.Add("Station of Calling");
                    getroom.Add("Station of Awakening");
                    getroom.Add("The Mysterial Train");
                    getroom.Add("Tunnelway");
                    getroom.Add("Underground Concouse");
                    getroom.Add("Tower: Wayward Stairs");
                    getroom.Add("Tower: Wayward Stairs");
                    getroom.Add("Betwixt and Between");
                    getroom.Add("The Old Mansion");
                    break;

                case "Hollow Bastion":
                    getroom.Add("Villain's Vale");
                    getroom.Add("The Dark Depths");
                    getroom.Add("The Great Maw");
                    getroom.Add("Crystal Fissure");
                    getroom.Add("Castle Gate");
                    getroom.Add("Ansem's Study");
                    getroom.Add("Postern");
                    getroom.Add("Restoration Site");
                    getroom.Add("Bailey");
                    getroom.Add("Borough");
                    getroom.Add("Marketplace");
                    getroom.Add("Corridors");
                    getroom.Add("Heartless Manufactory");
                    getroom.Add("Merlin's House");
                    getroom.Add("Castle Oblivion");
                    getroom.Add("Ansem's Study");
                    getroom.Add("Ravine Trail");
                    getroom.Add("The Great Maw");
                    getroom.Add("Restoration Site");
                    getroom.Add("Bailey");
                    getroom.Add("Corridors");
                    getroom.Add("Cavern of Remembrance: Depths");
                    getroom.Add("Cavern of Remembrance: Mining Area");
                    getroom.Add("Cavern of Remembrance: Engine Chamber");
                    getroom.Add("Cavern of Remembrance: Mineshaft");
                    getroom.Add("Transport to Remembrance");
                    getroom.Add("Garden of Assemblage");
                    getroom.Add("Underground Facility");
                    getroom.Add("Memory's Contortion");
                    getroom.Add("The World of Nothing");
                    getroom.Add("Hall of Empty Melodies");
                    getroom.Add("The Great Maw");
                    getroom.Add("Front Mansion");
                    getroom.Add("Station of Remembrance");
                    getroom.Add("Destiny Islands");
                    getroom.Add("Addled Impasse");
                    getroom.Add("Mansion: Basement Hall");
                    getroom.Add("Havoc's Divide");
                    getroom.Add("Station of Oblivion");
                    break;

                case "Beast's Castle":
                    getroom.Add("Entrance Hall");
                    getroom.Add("Parlor");
                    getroom.Add("Belle's Room");
                    getroom.Add("The Beast's Room");
                    getroom.Add("Ballroom");
                    getroom.Add("Ballroom");
                    getroom.Add("Courtyard");
                    getroom.Add("The East Wing");
                    getroom.Add("The West Hall");
                    getroom.Add("The West Wing");
                    getroom.Add("Dungeon");
                    getroom.Add("Undercroft");
                    getroom.Add("Secret Passage");
                    getroom.Add("Bridge");
                    getroom.Add("Ballroom");
                    getroom.Add("Bridge");
                    break;

                case "The Land of Dragon's":
                    getroom.Add("Bamboo Grove");
                    getroom.Add("Encampment");
                    getroom.Add("Checkpoint");
                    getroom.Add("Mountain Trail");
                    getroom.Add("Village");
                    getroom.Add("Village Cave");
                    getroom.Add("Ridge");
                    getroom.Add("Summit");
                    getroom.Add("Imperial Square");
                    getroom.Add("Palace Gate");
                    getroom.Add("Antechamber");
                    getroom.Add("Throne Room");
                    getroom.Add("Village");
                    break;

                case "Olympus Coliseum":
                    getroom.Add("The Coliseum");
                    getroom.Add("Coliseum Gates");
                    getroom.Add("Coliseum Gates");
                    getroom.Add("Underworld Entrance");
                    getroom.Add("Coliseum Foyer");
                    getroom.Add("Valley of the Dead");
                    getroom.Add("Hades' Chamber");
                    getroom.Add("Cave of the Dead: Entrance");
                    getroom.Add("Well of Captivity");
                    getroom.Add("The Underdrome");
                    getroom.Add("Cave of the Dead: Inner Chamber");
                    getroom.Add("Underworld Caverns: Entrance");
                    getroom.Add("The Lock");
                    getroom.Add("The Underdrome");
                    getroom.Add("Coliseum Gates");
                    getroom.Add("Cave of the Dead: Passage");
                    getroom.Add("Underworld Caverns: The Lost Road");
                    getroom.Add("Underworld Caverns: Atrium");
                    getroom.Add("Coliseum Gates");
                    getroom.Add("The Underdrome");
                    break;

                case "Port Royal":
                    getroom.Add("Rampart");
                    getroom.Add("Harbor");
                    getroom.Add("Town");
                    getroom.Add("The Interceptor");
                    getroom.Add("The Interceptor: Ship's Hold");
                    getroom.Add("The Black Pearl");
                    getroom.Add("The Black Pearl: Captain's Stateroom");
                    getroom.Add("The Interceptor");
                    getroom.Add("Isla de Muerta: Rock Face");
                    getroom.Add("Isla de Muerta: Cave Mouth");
                    getroom.Add("Isla de Muerta: Treasure Heap");
                    getroom.Add("Ship Graveyard: The Interceptor's Hold");
                    getroom.Add("Isla de Muerta: Powder Store");
                    getroom.Add("Isla de Muerta: Moonlight Nook");
                    getroom.Add("Ship Graveyard: Seadrift Keep");
                    getroom.Add("Ship Graveyard: Seadrift Row");
                    getroom.Add("Isla de Muerta: Rock Face");
                    getroom.Add("Isla de Muerta: Treasure Heap");
                    getroom.Add("The Black Pearl");
                    getroom.Add("The Black Pearl");
                    getroom.Add("The Black Pearl");
                    getroom.Add("The Interceptor");
                    getroom.Add("The Interceptor");
                    getroom.Add("The Black Pearl: Captain's Stateroom");
                    getroom.Add("Harbor");
                    getroom.Add("Isla de Muerta: Rock Face");
                    break;

                case "Disney Castle":
                    getroom.Add("Audience Chamber");
                    getroom.Add("Library");
                    getroom.Add("Colonnade");
                    getroom.Add("Courtyard");
                    getroom.Add("The Hall of the Cornerstone");
                    getroom.Add("The Hall of the Cornerstone");
                    getroom.Add("Gummi Hangar");
                    getroom.Add("The Wilderness");
                    break;

                case "Halloween Town":
                    getroom.Add("Halloween Town Square");
                    getroom.Add("Dr. Finklestein's Lab");
                    getroom.Add("Graveyard");
                    getroom.Add("Curly Hill");
                    getroom.Add("Hinterlands");
                    getroom.Add("Yuletide Hill");
                    getroom.Add("Candy Cane Lane");
                    getroom.Add("Christmas Tree Plaza");
                    getroom.Add("Santa's House");
                    getroom.Add("Toy Factory: Shipping and Receiving");
                    getroom.Add("Toy Factory: The Wrapping Room");
                    break;

                case "Agrabah":
                    getroom.Add("Agrabah");
                    getroom.Add("Bazaar");
                    getroom.Add("The Peddler's Shop");
                    getroom.Add("The Palace");
                    getroom.Add("Vault");
                    getroom.Add("Above Agrabah");
                    getroom.Add("Palace Walls");
                    getroom.Add("The Cavern of Wonders: Entrance");
                    getroom.Add("???");
                    getroom.Add("The Cavern of Wonders: Stone Guardians");
                    getroom.Add("The Cavern of Wonders: Treasure Room");
                    getroom.Add("Ruined Chamber");
                    getroom.Add("The Cavern of Wonders: Valley of Stone");
                    getroom.Add("The Cavern of Wonders: Chasm of Challenges");
                    getroom.Add("Sandswept Ruins");
                    getroom.Add("The Peddler's Shop");
                    break;

                case "Space Paranoids":
                    getroom.Add("Pit Cell");
                    getroom.Add("Canyon");
                    getroom.Add("Game Grid");
                    getroom.Add("Dataspace");
                    getroom.Add("I/O Tower: Hallway");
                    getroom.Add("I/O Tower: Communications Room");
                    getroom.Add("Simulation Hangar");
                    getroom.Add("Solar Sailer Simulation");
                    getroom.Add("Central Computer Mesa");
                    getroom.Add("Central Computer Core");
                    getroom.Add("Solar Sailer Simulation");
                    getroom.Add("Solar Sailer Simulation");
                    break;

                case "Pride Lands":
                    getroom.Add("Pride Rock");
                    getroom.Add("Stone Hollow");
                    getroom.Add("The King's Den");
                    getroom.Add("Wildebeest Valley");
                    getroom.Add("The Savannah");
                    getroom.Add("Elephant Graveyard");
                    getroom.Add("Gorge");
                    getroom.Add("Wastelands");
                    getroom.Add("Jungle");
                    getroom.Add("Oasis");
                    getroom.Add("Pride Rock");
                    getroom.Add("Oasis");
                    getroom.Add("Overlook");
                    getroom.Add("Peak");
                    getroom.Add("Scar's Darkness");
                    getroom.Add("The Savannah");
                    getroom.Add("Wildebeest Valley");
                    break;

                case "Atlantica":
                    getroom.Add("Triton's Throne");
                    getroom.Add("Ariel's Grotto");
                    getroom.Add("Undersea Courtyard");
                    getroom.Add("Undersea Courtyard");
                    getroom.Add("The Palace: Performance Hall");
                    getroom.Add("Sunken Ship");
                    getroom.Add("The Shore");
                    getroom.Add("The Shore");
                    getroom.Add("The Shore");
                    getroom.Add("Wrath of the Sea");
                    getroom.Add("Wedding Ship");
                    break;

                case "100 Acre Wood":
                    getroom.Add("The Hundred Acre Wood");
                    getroom.Add("Starry Hill");
                    getroom.Add("Pooh Bear's House");
                    getroom.Add("Rabbit's House");
                    getroom.Add("Piglet's House");
                    getroom.Add("Kanga's House");
                    getroom.Add("A Windsday Tale");
                    getroom.Add("The Honey Hunt");
                    getroom.Add("Blossom Valley");
                    getroom.Add("The Spooky Cave");
                    break;

                case "Timeless River":
                    getroom.Add("Cornerstone Hill");
                    getroom.Add("Pier");
                    getroom.Add("Waterway");
                    getroom.Add("Wharf");
                    getroom.Add("Lilliput");
                    getroom.Add("Building Site");
                    getroom.Add("Scene of the Fire");
                    getroom.Add("Mickey's House");
                    break;

                case "The World That Never Was":
                    getroom.Add("Where Nothing Gathers");
                    getroom.Add("Alley to Between");
                    getroom.Add("Fragment Crossing");
                    getroom.Add("Memory's Skyscraper");
                    getroom.Add("The Brink of Despair");
                    getroom.Add("The Soundless Prison");
                    getroom.Add("Nothing's Call");
                    getroom.Add("Crooked Ascension (Bottom)");
                    getroom.Add("Crooked Ascension (Top)");
                    getroom.Add("Twilight's View");
                    getroom.Add("Hall of Empty Melodies (Bottom)");
                    getroom.Add("Hall of Empty Melodies (Top)");
                    getroom.Add("Naught's Skyway");
                    getroom.Add("Proof of Existence");
                    getroom.Add("Havoc's Divide");
                    getroom.Add("Addled Impasse");
                    getroom.Add("Naught's Approach");
                    getroom.Add("Ruin and Creation's Passage");
                    getroom.Add("The Altar of Naught");
                    getroom.Add("Memory's Contortion");
                    getroom.Add("The World of Nothing");
                    getroom.Add("Station of Awakening");
                    getroom.Add("The World of Nothing");
                    getroom.Add("The World of Nothing");
                    getroom.Add("The World of Nothing");
                    getroom.Add("The World of Nothing");
                    getroom.Add("The World of Nothing");
                    getroom.Add("The World of Nothing");
                    getroom.Add("The World of Nothing");
                    getroom.Add("The Dark Margin");
                    break;

                case "Title screen":
                    getroom.Add("Title screen");
                    getroom.Add("Title screen");
                    break;
            }
            return getroom.ToArray();
        }
    }
}

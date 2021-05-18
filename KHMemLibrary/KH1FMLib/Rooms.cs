using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHMemLibrary.KH1FMLib
{
    public class Rooms
    {
        public static async Task<string[]> GetRoom(string world)
        {
            List<string> getroom = new List<string>();

            switch (world)
            {
                case "Dive into the Heart":
                    getroom.Add("Disembark"); //0
                    getroom.Add("Cinderella Platform"); //1
                    getroom.Add("Alice Platform"); //2
                    getroom.Add("Awakening"); //3
                    getroom.Add("Awakening"); //4
                    getroom.Add("Destiny Islands"); //5
                    getroom.Add("Destiny Islands"); //6
                    break;

                case "Destiny Islands":
                    getroom.Add("Seashore"); //0
                    getroom.Add("Seaside Shack"); //1
                    getroom.Add("Cove"); //2
                    getroom.Add("Seashore"); //3
                    getroom.Add("Seaside Shack"); //4
                    getroom.Add("Seashore"); //5
                    getroom.Add("Seaside Shack"); //6
                    getroom.Add("Secret Place"); //7
                    getroom.Add("Island Remains"); //8
                    getroom.Add("Sora's Room"); //9
                    getroom.Add("Secret Place"); //10
                    getroom.Add("Secret Place"); //11
                    break;

                case "Wonderland":
                    getroom.Add("Rabbit's Hole"); //0
                    getroom.Add("Bizarre Room"); //1
                    getroom.Add("Bizarre Room"); //2
                    getroom.Add("Queen's Castle"); //3
                    getroom.Add("Lotus Forest"); //4
                    getroom.Add("Lotus Forest"); //5
                    getroom.Add("Bizarre Room"); //6
                    getroom.Add("Bizarre Room"); //7
                    getroom.Add("Bizarre Room"); //8
                    getroom.Add("Tea Party Garden"); //9
                    break;

                case "Traverse Town":
                    getroom.Add("First District"); //0
                    getroom.Add("Second District"); //1
                    getroom.Add("Third District"); //2
                    getroom.Add("Vacant House"); //3
                    getroom.Add("Alleyback"); //4
                    getroom.Add("Green Room"); //5
                    getroom.Add("Red Room"); //6
                    getroom.Add("Hallway"); //7
                    getroom.Add("Mystical House"); //8
                    getroom.Add("Item Shop"); //9
                    getroom.Add("Accessory Shop"); //10
                    getroom.Add("Item Workshop"); //11
                    getroom.Add("Geppetto's House"); //12
                    getroom.Add("Dalmatian's Den"); //13
                    getroom.Add("Dining Room"); //14
                    getroom.Add("Living Room"); //15
                    getroom.Add("Piano Room"); //16
                    getroom.Add("Gizmo Room"); //17
                    getroom.Add("Merlin's House"); //18
                    getroom.Add("Magician's Study"); //19
                    getroom.Add("Magician's Lab"); //20
                    getroom.Add("???"); //21
                    getroom.Add("Secret Waterway"); //22
                    break;

                case "Deep Jungle":
                    getroom.Add("Tree House"); //0
                    getroom.Add("Camp"); //1
                    getroom.Add("Bamboo Thicket"); //2
                    getroom.Add("Jungle: Vines"); //3
                    getroom.Add("Jungle: Vines"); //4
                    getroom.Add("Hippos' Lagoon"); //5
                    getroom.Add("Climbing Trees"); //6
                    getroom.Add("Treetop"); //7
                    getroom.Add("Jungle: Tunnel"); //8
                    getroom.Add("Waterfall Cavern"); //9
                    getroom.Add("Cavern of Hearts"); //10
                    getroom.Add("Jungle: Cliff"); //11
                    getroom.Add("Camp"); //12
                    getroom.Add("Bamboo Thicket"); //13
                    getroom.Add("Camp: Tent"); //14
                    getroom.Add("Mini Game: Green Serpent"); //15
                    getroom.Add("Mini Game: Splash Tunnel"); //16
                    getroom.Add("Mini Game: Jade Spiral"); //17
                    getroom.Add("Mini Game: Panic Fall"); //18
                    getroom.Add("Mini Game: Shadow Cavern"); //19
                    break;

                case "100 Acre Wood":
                    getroom.Add("Pooh's House"); //0
                    getroom.Add("Pooh's Room"); //1
                    getroom.Add("Rabbit's House"); //2
                    getroom.Add("Rabbit's Room"); //3
                    getroom.Add("Hunny Tree"); //4
                    getroom.Add("Wood: Hill"); //5
                    getroom.Add("Wood: Meadow"); //6
                    getroom.Add("Bouncing Spot"); //7
                    getroom.Add("Muddy Path"); //8
                    getroom.Add("Wood: Hill"); //9
                    getroom.Add("100 Acre Wood"); //10
                    break;

                case "Agrabah":
                    getroom.Add("Desert"); //0
                    getroom.Add("Desert: Cave"); //1
                    getroom.Add("Agrabah: Plaza"); //2
                    getroom.Add("Agrabah: Alley"); //3
                    getroom.Add("Agrabah: Bazaar"); //4
                    getroom.Add("Agrabah: Main Street"); //5
                    getroom.Add("Palace Gates"); //6
                    getroom.Add("Agrabah: Storage"); //7
                    getroom.Add("Cave: Entrance"); //8
                    getroom.Add("Cave: Hall"); //9
                    getroom.Add("Bottomless Hall"); //10
                    getroom.Add("Treasure Room"); //11
                    getroom.Add("Relic Chamber"); //12
                    getroom.Add("Dark Chamber"); //13
                    getroom.Add("Silent Chamber"); //14
                    getroom.Add("Hidden Room"); //15
                    getroom.Add("Lamp Chamber"); //16
                    getroom.Add("Cave: Core"); //17
                    getroom.Add("Aladdin's House"); //18
                    getroom.Add("Agrabah"); //19
                    break;

                case "Atlantica":
                    getroom.Add("Atlantica"); //0
                    getroom.Add("Tranquil Grotto"); //1
                    getroom.Add("Calm Depths"); //2
                    getroom.Add("Undersea Gorge"); //3
                    getroom.Add("Undersea Cave"); //4
                    getroom.Add("Undersea Garden"); //5
                    getroom.Add("Sunken Ship"); //6
                    getroom.Add("Below Deck"); //7
                    getroom.Add("Sunken Ship"); //8
                    getroom.Add("Den of Tides"); //9
                    getroom.Add("Cavern Nook"); //10
                    getroom.Add("Tidal Abyss"); //11
                    getroom.Add("Ursula's Lair"); //12
                    getroom.Add("Ariel's Grotto"); //13
                    getroom.Add("Triton's Palace"); //14
                    getroom.Add("Triton's Throne"); //15
                    getroom.Add("Ursula Battle"); //16
                    break;

                case "Halloween Town":
                    getroom.Add("Guillotine Square"); //0
                    getroom.Add("Lab Entryway"); //1
                    getroom.Add("Graveyard"); //2
                    getroom.Add("Moonlight Hill"); //3
                    getroom.Add("Bridge"); //4
                    getroom.Add("Boneyard"); //5
                    getroom.Add("Oogie's Manor"); //6
                    getroom.Add("Torture Chamber"); //7
                    getroom.Add("Manor Ruins"); //8
                    getroom.Add("Evil Playroom"); //9
                    getroom.Add("Research Lab"); //10
                    getroom.Add("Guillotine Gate"); //10
                    getroom.Add("Cemetary"); //10
                    break;

                case "Olympus Coliseum":
                    getroom.Add("Coliseum Gates"); //0
                    getroom.Add("Coliseum: Lobby"); //1
                    getroom.Add("Coliseum: Arena"); //2
                    getroom.Add("Coliseum Gates"); //3
                    getroom.Add("Coliseum Gates"); //4
                    getroom.Add("Coliseum: Arena"); //5
                    getroom.Add("Coliseum: Arena"); //6
                    break;

                case "Monstro":
                    getroom.Add("Monstro: Mouth"); //0
                    getroom.Add("Monstro: Mouth"); //1
                    getroom.Add("Monstro: Stomach"); //2
                    getroom.Add("Monstro: Throat"); //3
                    getroom.Add("Monstro: Bowels"); //4
                    getroom.Add("Monstro: Chamber 1"); //5
                    getroom.Add("Monstro: Chamber 2"); //6
                    getroom.Add("Monstro: Chamber 3"); //7
                    getroom.Add("Monstro: Chamber 4"); //8
                    getroom.Add("Monstro: Chamber 5"); //9
                    getroom.Add("Monstro: Chamber 6"); //10
                    break;

                case "Neverland":
                    getroom.Add("Ship: Hold"); //0
                    getroom.Add("Ship: Hold"); //1
                    getroom.Add("Ship: Hold"); //2
                    getroom.Add("Ship: Freezer"); //3
                    getroom.Add("Ship: Gallery"); //4
                    getroom.Add("Ship: Cabin"); //5
                    getroom.Add("Captain's Cabin"); //6
                    getroom.Add("Ship: Hold"); //7
                    getroom.Add("Pirate Ship"); //8
                    getroom.Add("Clock Tower"); //9
                    break;

                case "Hollow Bastion":
                    getroom.Add("Rising Falls"); //0
                    getroom.Add("Castle Gates"); //1
                    getroom.Add("Great Crest"); //2
                    getroom.Add("High Tower"); //3
                    getroom.Add("Entrance Hall"); //4
                    getroom.Add("Library"); //5
                    getroom.Add("Lift Shop"); //6
                    getroom.Add("Base Level"); //7
                    getroom.Add("Waterway"); //8
                    getroom.Add("Waterway"); //9
                    getroom.Add("Dungeon"); //10
                    getroom.Add("Castle Chapel"); //11
                    getroom.Add("Castle Chapel"); //12
                    getroom.Add("Castle Chapel"); //13
                    getroom.Add("Grand Hall"); //14
                    getroom.Add("Dark Depths"); //15
                    getroom.Add("Castle Chapel"); //16
                    break;

                case "End of the World":
                    getroom.Add("Gate to the Dark"); //0
                    getroom.Add("Final Dimension"); //1
                    getroom.Add("Final Dimension"); //2
                    getroom.Add("Final Dimension"); //3
                    getroom.Add("Final Dimension"); //4
                    getroom.Add("Final Dimension"); //5
                    getroom.Add("Final Dimension"); //6
                    getroom.Add("Final Dimension"); //7
                    getroom.Add("Final Dimension"); //8
                    getroom.Add("Final Dimension"); //9
                    getroom.Add("Final Dimension"); //10
                    getroom.Add("Final Dimension"); //11
                    getroom.Add("Final Dimension"); //12
                    getroom.Add("Dark Sphere"); //13
                    getroom.Add("Giant Crevasse"); //14
                    getroom.Add("World Terminals"); //15
                    getroom.Add("World Terminals (Traverse Town)"); //16
                    getroom.Add("World Terminals (Wonderland)"); //17
                    getroom.Add("World Terminals (Olympus Coliseum)"); //18
                    getroom.Add("World Terminals (Deep Jungle)"); //19
                    getroom.Add("World Terminals (Agrabah)"); //20
                    getroom.Add("World Terminals (Atlantica)"); //21
                    getroom.Add("World Terminals (Halloween Town)"); //22
                    getroom.Add("World Terminals (Neverland)"); //23
                    getroom.Add("World Terminals (100 Acre Wood)"); //24
                    getroom.Add("World Terminals (Hollow Bastion)"); //25
                    getroom.Add("Evil Grounds"); //26
                    getroom.Add("Volcanic Crater"); //27
                    getroom.Add("Linked Worlds"); //28
                    getroom.Add("Final Rest"); //29
                    getroom.Add("Homecoming"); //30
                    getroom.Add("Crumbling Island"); //31
                    getroom.Add("Final Door"); //32
                    getroom.Add("The Void (Final Battle)"); //33
                    getroom.Add("Crater"); //34
                    getroom.Add("Homecoming"); //35
                    getroom.Add("The Void"); //36
                    getroom.Add("The Void"); //37
                    getroom.Add("The Void"); //38
                    break;
            }
            return getroom.ToArray();
        }
    }
}

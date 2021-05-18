using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHMemLibrary.KH1FMLib
{
    public class Worlds
    {
        public static async Task<string[]> GetWorld(int world)
        {
            List<string> getworld = new List<string>();

            //Order:
            //String to show on discord
            //String to use as imagekey

            switch (world)
            {
                case 0:
                    getworld.Add("Dive into the Heart");
                    getworld.Add("dive");
                    break;
                case 1:
                    getworld.Add("Destiny Islands");
                    getworld.Add("destiny");
                    break;
                case 2:
                    getworld.Add("Disney Castle");
                    getworld.Add("Disney");
                    break;
                case 3:
                    getworld.Add("Traverse Town");
                    getworld.Add("traversetown");
                    break;
                case 4:
                    getworld.Add("Wonderland");
                    getworld.Add("wonderland");
                    break;
                case 5:
                    getworld.Add("Deep Jungle");
                    getworld.Add("deepjungle");
                    break;
                case 6:
                    getworld.Add("100 Acre Wood");
                    getworld.Add("100acre");
                    break;
                case 8:
                    getworld.Add("Agrabah");
                    getworld.Add("agrabah");
                    break;
                case 9:
                    getworld.Add("Atlantica");
                    getworld.Add("atlantica");
                    break;
                case 10:
                    getworld.Add("Halloween Town");
                    getworld.Add("halloweentown");
                    break;
                case 11:
                    getworld.Add("Olympus Coliseum");
                    getworld.Add("olymp");
                    break;
                case 12:
                    getworld.Add("Monstro");
                    getworld.Add("monstro");
                    break;
                case 13:
                    getworld.Add("Neverland");
                    getworld.Add("neverland");
                    break;
                case 15:
                    getworld.Add("Hollow Bastion");
                    getworld.Add("hollowbastion");
                    break;
                case 16:
                    getworld.Add("End of the World");
                    getworld.Add("endoftheworld");
                    break;
                case 255:
                    getworld.Add("Main Menu");
                    getworld.Add("logo");
                    break;
                default:
                    getworld.Add("Undefined location");
                    getworld.Add("logo");
                    break;
            }
            return getworld.ToArray();
        }
    }
}

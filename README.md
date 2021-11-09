

# KHMemLibrary
 A memory library for various Kingdom Hearts games on PC.

## First words
Please note that this project is still in it's early stage and far from being done.</br>
I try to make this library as userfriendly as possible, so even a newbie can work with it!</br>
For a complete library breakdown, don't mind to look at the [Wiki](https://github.com/Dekirai/KHMemLibrary/wiki).

## Requirements

 - Kingdom Hearts 1 or Kingdom Hearts 2 on your PC
 - Visual Studio 2022 (Recommended)
 - [.NET 6](https://dotnet.microsoft.com/download/dotnet) or greater

## How to install the library

 1. Grab the latest release from here: [Releases](https://github.com/Dekirai/KHMemLibrary/releases)
 2. In Visual Studio, add a new Package Source in the Package Manager that includes the .nupkg file.
 3. From the Browser, select KHMemLibrary and install it.
 
## How to use the library

    using System;
    using System.Windows.Forms;
    using KHMemLibrary;
    using KHMemLibrary.KH2FMLib;
    
    namespace KH2MemLibraryTest
    {
        public partial class Form1 : Form
        {
            KH2FM KH2 = new KH2FM();
    
            private void button1_Click(object sender, EventArgs e)
            {
                KH2.AddWeaponSora(Keyblade.UltimaWeapon); //Adds the Ultima Keyblade for Sora.
                KH2.Level(55); //Sets Sora to Level 55 after defeating an enemy.
            }
        }
    }

## Credits
Huge thanks to anyone that contributed to the Library in any way or I took advantage of.</br>

 - Denho (denho#3759)
 - TopazTK (TopazTK#5514, [GitHub](https://github.com/Topaz-Reality))
 - 1234567890num (1234567890num#6827, [GitHub](https://github.com/1234567890num))

## Packages used to make it work

 - [memory.dll](https://github.com/erfg12/memory.dll)
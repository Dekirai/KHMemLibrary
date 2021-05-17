
# KHMemLibrary
 A memory library for various Kingdom Hearts games on PC.

## First words
Please note that this project is still in it's early stage and far from being done.</br>
I try to make this library as userfriendly as possible, so even a newbie can work with it!</br>
For a complete library breakdown, don't mind look at the [Wiki](https://github.com/Dekirai/KHMemLibrary/wiki/Functions)

## Requirements

 - Kingdom Hearts of your choice on your PC
 - [.NET 5](https://dotnet.microsoft.com/download/dotnet) or higher

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

## Packages used to make it work

 - [memory.dll](https://github.com/erfg12/memory.dll)

## To-Do List

For now the library is focused only on Kingdom Hearts II.</br>
But my plan is to also add support for Kingdom Hearts I and Kingdom Hearts: Birth by Sleep.
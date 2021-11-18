using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHMemLibrary.KH1FMLib
{
    /// <summary>
    /// Set the FPS from the PC exclusive settings menu from anywhere.
    /// </summary>
    public enum FPSValue
    {
        /// <summary>
        /// Unlocks the FPS.
        /// </summary>
        Unlimited = 0,
        /// <summary>
        /// Limits the FPS to 30 FPS.
        /// </summary>
        FPS30 = 30,
        /// <summary>
        /// Limits the FPS to 60 FPS.
        /// </summary>
        FPS60 = 60,
        /// <summary>
        /// Limits the FPS to 120 FPS.
        /// </summary>
        FPS120 = 120
    }

    public enum Keyblade
    {
        KingdomKey = 0x2DE5EBA,
        DreamSword = 0x2DE5EBB,
        DreamShield = 0x2DE5EBC,
        DreamRod = 0x2DE5EBD,
        WoodenSword = 0x2DE5EBE,
        JungleKing = 0x2DE5EBF,
        ThreeWishes = 0x2DE5EC0,
        Crabclaw = 0x2DE5EC1,
        Pumpkinhead = 0x2DE5EC2,
        FairyHarp = 0x2DE5EC3,
        WishingStar = 0x2DE5ECC,
        Spellbinder = 0x2DE5EC5,
        MetalChocobo = 0x2DE5EC8,
        Olympia = 0x2DE5EC6,
        Lionheart = 0x2DE5EC7,
        LadyLuck = 0x2DE5ECB,
        DivineRose = 0x2DE5EC4,
        Oathkeeper = 0x2DE5EC9,
        Oblivion = 0x2DE5ECA,
        DiamondRust = 0x2DE5ECE,
        OneWingedAngel = 0x2DE5ECF,
        UltimaWeapon = 0x2DE5ECD
    }

    public enum WorldID
    {
        DiveIntoTheHeart = 0,
        DestinyIslands = 1,
        DisneyCastle = 2,
        TraverseTown = 3,
        Wonderland = 4,
        DeepJungle = 5,
        HundredAcreWood = 6,
        Agrabah = 8,
        Atlantica = 9,
        HalloweenTown = 10,
        OlympusColiseum = 11,
        Monstro = 12,
        Neverland = 13,
        HollowBastion = 15,
        EndOfTheWorld = 16
    }

    public enum Consumable
    {
        Potion = 0x2DE5E6A,
        HiPotion = 0x2DE5E6B,
        Ether = 0x2DE5E6C,
        Elixir = 0x2DE5E6D,
        MegaPotion = 0x2DE5E6F,
        MegaEther = 0x2DE5E70,
        MegaElixir = 0x2DE5E71,
        Tent = 0x2DE5EF7,
        CampingSet = 0x2DE5EF8,
        Cottage = 0x2DE5EF9,
        PowerUp = 0x2DE5F01,
        DefenseUp = 0x2DE5F02,
        APUp = 0x2DE5F03
    }
}

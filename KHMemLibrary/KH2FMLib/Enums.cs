﻿namespace KHMemLibrary.KH2FMLib
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

    public enum AbilitySlot
    {
        Slot01 = 0x9A95B4,
        Slot02 = 0x9A95B6,
        Slot03 = 0x9A95B8,
        Slot04 = 0x9A95BA,
        Slot05 = 0x9A95BC,
        Slot06 = 0x9A95BE,
        Slot07 = 0x9A95C0,
        Slot08 = 0x9A95C2,
        Slot09 = 0x9A95C4,
        Slot10 = 0x9A95C6,
        Slot11 = 0x9A95C8,
        Slot12 = 0x9A95CA,
        Slot13 = 0x9A95CC,
        Slot14 = 0x9A95CE,
        Slot15 = 0x9A95D0,
        Slot16 = 0x9A95D2,
        Slot17 = 0x9A95D4,
        Slot18 = 0x9A95D6,
        Slot19 = 0x9A95D8,
        Slot20 = 0x9A95DA,
        Slot21 = 0x9A95DC,
        Slot22 = 0x9A95DE,
        Slot23 = 0x9A95E0,
        Slot24 = 0x9A95E2,
        Slot25 = 0x9A95E4,
        Slot26 = 0x9A95E6,
        Slot27 = 0x9A95E8,
        Slot28 = 0x9A95EA,
        Slot29 = 0x9A95EC,
        Slot30 = 0x9A95EE,
        Slot31 = 0x9A95F0,
        Slot32 = 0x9A95F2,
        Slot33 = 0x9A95F4,
        Slot34 = 0x9A95F6,
        Slot35 = 0x9A95F8,
        Slot36 = 0x9A95FA,
        Slot37 = 0x9A95FC,
        Slot38 = 0x9A95FE,
        Slot39 = 0x9A9600,
        Slot40 = 0x9A9602,
        Slot41 = 0x9A9604,
        Slot42 = 0x9A9606,
        Slot43 = 0x9A9608,
        Slot44 = 0x9A960A,
        Slot45 = 0x9A960C,
        Slot46 = 0x9A960E,
        Slot47 = 0x9A9610,
        Slot48 = 0x9A9612,
        Slot49 = 0x9A9614,
        Slot50 = 0x9A9616,
        Slot51 = 0x9A9618,
        Slot52 = 0x9A961A,
        Slot53 = 0x9A961C,
        Slot54 = 0x9A961E,
        Slot55 = 0x9A9620,
        Slot56 = 0x9A9622,
        Slot57 = 0x9A9624,
        Slot58 = 0x9A9626,
        Slot59 = 0x9A9628,
        Slot60 = 0x9A962A,
        Slot61 = 0x9A962C,
        Slot62 = 0x9A962E,
        Slot63 = 0x9A9630,
        Slot64 = 0x9A9632,
        Slot65 = 0x9A9634,
        Slot66 = 0x9A9636,
        Slot67 = 0x9A9638,
        Slot68 = 0x9A963A,
        Slot69 = 0x9A963C,
        Slot70 = 0x9A963E,
        Slot71 = 0x9A9640,
        Slot72 = 0x9A9642,
        Slot73 = 0x9A9644,
        Slot74 = 0x9A9646,
        Slot75 = 0x9A9648,
        Slot76 = 0x9A964A,
        Slot77 = 0x9A964C,
        Slot78 = 0x9A964E,
        Slot79 = 0x9A9650,
    }

    public enum Ability
    {
        None = 0x0000,
        HighJumpLV1 = 0x5E00,
        HighJumpLV2 = 0x5F00,
        HighJumpLV3 = 0x6000,
        HighJumpMAX = 0x6100,
        QuickRunLV1 = 0x6200,
        QuickRunLV2 = 0x6300,
        QuickRunLV3 = 0x6400,
        QuickRunMAX = 0x6500,
        AerialDodgeLV1 = 0x6600,
        AerialDodgeLV2 = 0x6700,
        AerialDodgeLV3 = 0x6800,
        AerialDodgeMAX = 0x6900,
        GlideLV1 = 0x6A00,
        GlideLV2 = 0x6B00,
        GlideLV3 = 0x6C00,
        GlideMAX = 0x6D00,
        DodgeRollLV1 = 0x3402,
        DodgeRollLV2 = 0x3502,
        DodgeRollLV3 = 0x3602,
        DodgeRollMAX = 0x3702,
        SonicRave = 0x3902,
        ArsArcanum = 0x3A02,
        StrikeRaid = 0x3B02,
        Ragnarok = 0x3C02,
        Zantetsuken = 0x3D02,
        RippleDrive = 0x3E02,
        HurricanePeriod = 0x3F02,
        ZantetsuCounter = 0x4B02,
        ReflectCombo = 0x4C02,
        HPGain = 0x4D02,
        FinalArcana = 0x0F02,
        FinalStrike = 0x1002,
        FinalArts = 0x1102,
        AutoAssault = 0x0702,
        CrimeAndPunishment = 0x1202,
        BraveShot = 0xD800,
        BraveBeat = 0xD900,
        SonicStrike = 0xDA00,
        SonicEnd = 0xDB00,
        OverTheHorizon = 0xF600,
        OmegaFinale = 0xF700,
        SynchBlade = 0xDF00,
        WisdomShot = 0xDC00,
        MobileAction = 0xDD00,
        MagicHaste = 0xE000,
        MagicSpice = 0xE100,
        MasterStrike = 0x0101,
        Disaster = 0x0201,
        MasterMagic = 0x0501,
        EndlessMagic = 0x0301,
        AntiGlideDummy = 0xF800,
        SideSpinDummy = 0xF900,
        ComboUpper = 0x0902,
        AerialImpulse = 0x0A02,
        FinishingBlast = 0x0802,
        RetaliatingSmash = 0x0B02,
        RunningTackle = 0x0D02,
        Dash = 0x0E02,
        Guard = 0x5200,
        UpperSlash = 0x8900,
        HorizontalSlash = 0x0F01,
        FinishingLeap = 0x0B01,
        RetaliatingSlash = 0x1101,
        Slapshot = 0x0601,
        DodgeSlash = 0x0701,
        FlashStep = 0x2F02,
        SlideDash = 0x0801,
        VicinityBreak = 0x3202,
        GuardBreak = 0x0901,
        Explosion = 0x0A01,
        AerialSweep = 0x0D01,
        AerialDive = 0x3002,
        AerialSpiral = 0x0E01,
        AerialFinish = 0x1001,
        MagnetBurst = 0x3102,
        Counterguard = 0x0C01,
        AutoValor = 0x8101,
        AutoWisdom = 0x8201,
        AutoLimit = 0x3802,
        AutoMaster = 0x8301,
        AutoFinal = 0x8401,
        AutoSummon = 0x8501,
        DonaldFire = 0xA500,
        DonaldBlizzard = 0xA600,
        DonaldThunder = 0xA700,
        DonaldCure = 0xA800,
        GoofyTornado = 0xA701,
        GoofyBash = 0xAD01,
        GoofyTurbo = 0xA901,
        SlashFrenzy = 0xAA01,
        Quickplay = 0xAB01,
        Divider = 0xAC01,
        HealingWater = 0xB000,
        FuriousShout = 0xB100,
        FerociousRush = 0xAE01,
        BlazingFury = 0xAF01,
        IcyTerror = 0xB001,
        BoltsOfSorrow = 0xB101,
        MushuFire = 0xB201,
        Flametongue = 0xB301,
        DarkAura = 0xB601,
        DarkShield = 0xB401,
        CurePotion = 0xBB00,
        FierceClaw = 0xB701,
        Groundshaker = 0xB801,
        HealingHerb = 0xBE00,
        NoMercy = 0xBE01,
        RainStorm = 0xBF01,
        BoneSmash = 0xC001,
        ScoutingDisk = 0xBC01,
        Slow2 = 0xBD01,
        Slow3 = 0xC300,
        PulsingThunder = 0xD700,
        TrinityLimit = 0xC600,
        Fantasia = 0xC700,
        FlareForce = 0xC800,
        TornadoFusion = 0xC900,
        Teamwork = 0xCA00,
        TrickFantasy = 0xCB00,
        Overdrive = 0xCC00,
        HowlingMoon = 0xCD00,
        ApplauseApplause = 0xCE00,
        Dragonblaze = 0xCF00,
        EternalSession = 0xD000,
        KingsPride = 0xD100,
        TreasureIsle = 0xD200,
        CompleteCompilement = 0xD300,
        Scan = 0x8A00,
        AerialRecovery = 0x9E00,
        ComboMaster = 0x1B02,
        ComboPlus = 0xA200,
        AirComboPlus = 0xA300,
        ComboBoost = 0x8601,
        AirComboBoost = 0x8701,
        ReactionBoost = 0x8801,
        FinishingPlus = 0x8901,
        NegativeCombo = 0x8A01,
        BerserkCharge = 0x8B01,
        DamageDrive = 0x8C01,
        DriveBoost = 0x8D01,
        FormBoost = 0x8E01,
        SummonBoost = 0x8F01,
        CombinationBoost = 0x9001,
        ExperienceBoost = 0x9101,
        LeafBracer = 0x9201,
        MagicLockOn = 0x9301,
        LightAndDarkness = 0x1D02,
        Draw = 0x9501,
        Jackpot = 0x9601,
        LuckyLucky = 0x9701,
        DriveConverter = 0x1C02,
        FireBoost = 0x9801,
        BlizzardBoost = 0x9901,
        ThunderBoost = 0x9A01,
        ItemBoost = 0x9B01,
        MPRage = 0x9C01,
        MPHaste = 0x9D01,
        MPHastera = 0xA601,
        Defender = 0x9E01,
        DamageControl = 0x1E02,
        SecondChance = 0x9F01,
        OnceMore = 0xA001,
        NoExperience = 0x9401,
        AutoLimit2 = 0xA101,
        AutoChange = 0xA201,
        HyperHealing = 0xA301,
        AutoHealing = 0xA401,
        Protect = 0x5402,
        Protectra = 0x5502,
        Protectga = 0x5602
    }

    public enum BGM
    {
        DiveIntoTheHeart = 0x32,
        FragmentsOfSorrow = 0x33,
        TheAfternoonStreets = 0x34,
        WorkingTogether = 0x35,
        SacredMoon = 0x36,
        DeepDive = 0x37,
        NightsOfTheCursed = 0x38,
        HesAPirate = 0x39,
        AFightToTheDeath = 0x3B,
        DarknessOfTheUnknown = 0x3C,
        DarknessOfTheUnknown2 = 0x3D,
        DarknessOfTheUnknown3 = 0x3E,
        The13thReflection = 0x3F,
        WhatASurprise = 0x40,
        HappyHolidays = 0x41,
        TheOtherPromise = 0x42,
        RageAwakened = 0x43,
        CavernOfRemembrance = 0x44,
        DeepAnxiety = 0x45,
        BeneathTheGround = 0x51,
        TheEscapade = 0x52,
        ArabianDaydream = 0x54,
        ByteStriking = 0x55,
        Disappeared = 0x57,
        Sora = 0x58,
        FriendsInMyHeart = 0x59,
        Riku = 0x5A,
        Kairi = 0x5B,
        AWalkInAndante = 0x5C,
        VillainsOfASort = 0x5D,
        OrganizationXIII = 0x5E,
        Apprehension = 0x5F,
        Courage = 0x60,
        LaughterAndMerriment = 0x61,
        Hesitation = 0x62,
        MissinGyou = 0x63,
        TheUnderworld = 0x64,
        WaltzOfTheDamned = 0x65,
        WhatLiesBeneath = 0x66,
        OlympusColiseumTheme = 0x67,
        DanceOfTheDaring = 0x68,
        UnderTheSea = 0x6A,
        UrsulasRevenge = 0x6B,
        PartOfYourWorld = 0x6C,
        ANewDayIsDawning = 0x6D,
        TheEncounter = 0x6E,
        SinisterShadows = 0x6F,
        FieldsOfHonor = 0x70,
        SwimThisWay = 0x71,
        TensionRising = 0x72,
        TheCorrupted = 0x73,
        TheHomeOfDragons = 0x74,
        RowdyRumble = 0x75,
        LazyAfternoons = 0x76,
        SinisterSundowns = 0x77,
        BeneathTheGround2 = 0x78,
        DesireForAllThatIsLost = 0x79,
        LetsSingAndDance = 0x7A,
        LetsSingAndDance2 = 0x7B,
        LetsSingAndDance3 = 0x7C,
        LetsSingAndDance4 = 0x7D,
        ADayInAgrabah = 0x7F,
        ArabianDream = 0x80,
        IsntItLovely = 0x81,
        NeverlandSky = 0x82,
        DanceToTheDeath = 0x83,
        BeautyAndTheBeast = 0x84,
        MagicalMystery = 0x85,
        WorkingTogether2 = 0x86,
        SpaceParanoids = 0x87,
        ByteBashing = 0x88,
        ATwinkleInTheSky = 0x89,
        ShipmeistersShanty = 0x8A,
        GearingUp = 0x8B,
        UnderTheSea2 = 0x8C,
        WinnieThePooh = 0x8D,
        CrossingTheFinishLine = 0x8E,
        MickeyMouseClubMarch = 0x8F,
        ThisIsHalloween = 0x90,
        VimAndVigor = 0x91,
        Roxas = 0x92,
        AnAdventureInAtlantica = 0x93,
        BlastOff = 0x94,
        SpooksOfHalloweenTown = 0x95,
        SquirmingEvil = 0x96,
        The13thStruggle = 0x97,
        RevivingHollowBastion = 0x98,
        ScherzoDiNotte = 0x99,
        NightsOfTheCursed2 = 0x9A,
        HesAPirate2 = 0x9B,
        GuardandoNelBuio = 0x9C,
        BounceORama = 0x9E,
        BounceORama2 = 0x9F,
        VillainsOfASort2 = 0xA2,
        VillainsOfASort3 = 0xA3,
        RoadToAHero = 0xA4,
        BadOmen = 0xA6,
        BadOmen2 = 0xA7,
        BadOmen3 = 0xA8,
        BadOmen4 = 0xA9,
        ShockerMusic = 0xAF,
        The13thDilemma = 0xB9,
        SavannahPride = 0xBB,
        OneWingedAngel = 0xBC,
        MonochromeDreams = 0xBD,
        OldFriendsOldRivals = 0xBE
    }

    /// <summary>
    /// Retrieve a world for modifying a party.
    /// </summary>
    public enum PartyWorld
    {
        TwilightTown = 0x9AA5AC,
        HollowBastion = 0x9AA5B4,
        DisneyCastle = 0x9AA5D4,
        TheLandOfDragons = 0x9AA5C4,
        BeastsCastle = 0x9AA5B8,
        OlympusColiseum = 0x9AA5BC,
        PortRoyal = 0x9AA5E4,
        HalloweenTown = 0x9AA5DC,
        Agrabah = 0x9AA5C0,
        PrideLands = 0x9AA5CC,
        TimelessRiver = 0x9AA5D8,
        SpaceParanoids = 0x9AA5E8,
        TheWorldThatNeverWas = 0x9AA5EC
    }

    public enum PartyMember
    {
        SoraOrRoxas = 0,
        Donald = 1,
        Goofy = 2,
        World = 3,
        ValorOrDualRoxas = 4,
        Wisdom = 5,
        Limit = 6,
        Master = 7,
        Final = 8,
        Anti = 9,
        Mickey = 10,
        None = 18
    }

    public enum KeybladeID
    {
        KingdomKey = 41,
        Oathkeeper = 42,
        Oblivion = 43,
        DetectionSaber = 44,
        FrontierOfUltima = 45,
        AntiformDummy = 71,
        FAKE = 81,
        StruggleSword = 384,
        StarSeeker = 480,
        HiddenDragon = 481,
        HerosCrest = 484,
        Monochrome = 485,
        FolloTheWind = 486,
        CircleOfLife = 487,
        PhotonDebugger = 488,
        GullWing = 489,
        RumblingRose = 490,
        GuardianSoul = 491,
        WishingLamp = 492,
        DecisivePumpkin = 493,
        SleepingLion = 493,
        SweetMemories = 495,
        MysteriousAbyss = 496,
        FatalCrest = 497,
        BondOfFlame = 498,
        Fenrir = 499,
        UltimaWeapon = 500,
        StruggleWand = 501,
        StruggleHammer = 502,
        TwoBecomeOne = 543,
        WinnersProof = 544
    }

    public enum StaffID
    {
        MagesStaff = 75,
        HammerStaff = 148,
        VictoryBell = 149,
        MeteorStaff = 150,
        CometStaff = 151,
        LordsBroom = 152,
        WisdomWand = 153,
        RisingDragon = 154,
        NobodyLance = 155,
        ShamansRelic = 156,
        StaffOfDetection = 161,
        SaveTheQueen = 482,
        SaveTheQueenPlus = 503,
        Centurion = 545,
        CenturionPlus = 546,
        PlainMushroom = 547,
        PlainMushroomPlus = 548,
        PreciousMushroom = 549,
        PreciousMushroomPlus = 550,
        PremiumMushroom = 551,
        ShamansRelicPlus = 600
    }

    public enum ShieldID
    {
        KnightsShield = 49,
        DetectionShield = 50,
        TestTheKing = 51,
        AdamantShield = 139,
        ChainGear = 140,
        OgreShield = 141,
        FallingStar = 142,
        Dreamcloud = 143,
        KnightDefender = 144,
        GenjiShield = 145,
        AkashicRecord = 146,
        NobodyGuard = 147,
        SaveTheKing = 483,
        SaveTheKingPlus = 504,
        FrozenPride = 552,
        FrozenPridePlus = 553,
        JoyousMushroom = 554,
        JoyousMushroomPlus = 555,
        MajesticMushroom = 556,
        MajesticMushroomPlus = 557,
        UltimateMushroom = 558,
        AkashicRecordPlus = 601
    }

    public enum Keyblade
    {
        KingdomKey = 0x9AA611,
        Oathkeeper = 0x9AA612,
        Oblivion = 0x9AA613,
        DetectionSaber = 0x9AA614,
        FrontierOfUltima = 0x9AA615,
        StarSeeker = 0x9AA6EB,
        HiddenDragon = 0x9AA6EC,
        HerosCrest = 0x9AA6EF,
        Monochrome = 0x9AA6F0,
        FollowTheWind = 0x9AA6F1,
        CircleOfLife = 0x9AA6F2,
        PhotonDebugger = 0x9AA6F3,
        GullWing = 0x9AA6F4,
        RumblingRose = 0x9AA6F5,
        GuardianSoul = 0x9AA6F6,
        WishingLamp = 0x9AA6F7,
        DecisivePumpkin = 0x9AA6F8,
        SleepingLion = 0x9AA6F9,
        SweetMemories = 0x9AA6FA,
        MysteriousAbyss = 0x9AA6FB,
        FatalCrest = 0x9AA6FC,
        BondOfFlame = 0x9AA6FD,
        Fenrir = 0x9AA6FE,
        UltimaWeapon = 0x9AA6FF,
        StruggleWand = 0x9AA700,
        StruggleHammer = 0x9AA701,
        TwoBecomeOne = 0x9AA708,
        WinnersProof = 0x9AA709,
        StruggleSword = 0x9AA6C1
    }

    public enum Staff
    {
        MagesStaff = 0x9AA633,
        HammerStaff = 0x9AA65F,
        VictoryBell = 0x9AA660,
        MeteorStaff = 0x9AA661,
        CometStaff = 0x9AA662,
        LordsBroom = 0x9AA663,
        WisdomWand = 0x9AA664,
        RisingDragon = 0x9AA665,
        NobodyLance = 0x9AA666,
        ShamansRelic = 0x9AA667,
        ShamansRelicPlus = 0x9AA726,
        StaffOfDetection = 0x9AA66A,
        SaveTheQueen = 0x9AA6ED,
        SaveTheQueenPlus = 0x9AA702,
        Centurion = 0x9AA70A,
        CentrurionPlus = 0x9AA70B,
        PlainMushroom = 0x9AA70C,
        PlainMushroomPlus = 0x9AA70D,
        PreciousMushroom = 0x9AA70E,
        PreciousMushroomPlus = 0x9AA70F,
        PremiumMushroom = 0x9AA710
    }

    public enum Shield
    {
        KnightsShield = 0x9AA619,
        DetectionShield = 0x9AA61A,
        TestTheKing = 0x9AA61B,
        AdamantShield = 0x9AA656,
        ChainGear = 0x9AA657,
        OgreShield = 0x9AA658,
        FallingStar = 0x9AA659,
        Dreamcloud = 0x9AA65A,
        KnightDefender = 0x9AA65B,
        GenjiShield = 0x9AA65C,
        AkashicRecord = 0x9AA65D,
        NobodyGuard = 0x9AA65E,
        SaveTheKing = 0x9AA6EE,
        SaveTheKingPlus = 0x9AA703,
        FrozenPride = 0x9AA711,
        FrozenPridePlus = 0x9AA712,
        JoyousMushroom = 0x9AA713,
        JoyousMushroomPlus = 0x9AA714,
        MajesticMushroom = 0x9AA715,
        MajesticMushroomPlus = 0x9AA716,
        UltimateMushroom = 0x9AA717,
        AkashicRecordPlus = 0x9AA727
    }

    public enum Consumable
    {
        Potion = 0x9AA5F0,
        HiPotion = 0x9AA5F1,
        Ether = 0x9AA5F2,
        Elixir = 0x9AA5F3,
        MegaPotion = 0x9AA5F4,
        MegaEther = 0x9AA5F5,
        MegaElixir = 0x9AA5F6,
        Tent = 0x9AA651,
        DriveRecovery = 0x9AA6D4,
        HighDriveRecovery = 0x9AA6D5,
        PowerBoost = 0x9AA6D6,
        MagicBoost = 0x9AA6D7,
        DefenseBoost = 0x9AA6D8,
        APBoost = 0x9AA6D9
    }

    public enum KeyItem
    {
        TornPage = 0x9AA608,
        MegaRecipe = 0x9AA6C0,
        StarRecipe = 0x9AA6C2,
        RecoveryRecipe = 0x9AA6C3,
        SkillRecipe = 0x9AA6C4,
        GuardRecipe = 0x9AA6C5,
        Dummy06 = 0x9AA6C6,
        Dummy07 = 0x9AA6C7,
        Dummy08 = 0x9AA6C8,
        Dummy09 = 0x9AA6C9,
        Dummy10 = 0x9AA6CA,
        Dummy11 = 0x9AA6CB,
        Dummy12 = 0x9AA6FC,
        Dummy13 = 0x9AA6CD,
        Dummy14 = 0x9AA6CE,
        Dummy15 = 0x9AA6CF,
        Dummy16 = 0x9AA6D0,
        BookOfShadows = 0x9AA6D3,
        RoadToDiscovery = 0x9AA6D1,
        StrengthBeyondStrength = 0x9AA6D2,
        CloakedThunder = 0x9AA6DE,
        EternalBlossom = 0x9AA6DF,
        RareDocument = 0x9AA6E0,
        Dummy23 = 0x9AA6E1,
        Dummy24 = 0x9AA6E2,
        Dummy25 = 0x9AA6E3,
        Dummy26 = 0x9AA6E4,
        Dummy27 = 0x9AA6E5,
        StyleRecipe = 0x9AA6E6,
        MoonRecipe = 0x9AA6E7,
        QueenRecipe = 0x9AA6E8,
        KingRecipe = 0x9AA6E9,
        UltimateRecipe = 0x9AA6EA,
        PromiseCharm = 0x9AA704,
        MunnyPouchOlette = 0x9AA6AC,
        MunnyPouchMickey = 0x9AA705,
        HadesCupTrophy = 0x9AA706,
        TheStruggleTrophy = 0x9AA707,
        ProofOfConnection = 0x9AA722,
        ProofOfNonexistence = 0x9AA723,
        ProofOfPeace = 0x9AA724,
        CrystalOrb = 0x9AA6AD,
        SeifersTrophy = 0x9AA6AE,
        TournamentPoster = 0x9AA6AF,
        Poster = 0x9AA6B0,
        Letter = 0x9AA6B1,
        NaminesSketches = 0x9AA6B2,
        MembershipCard = 0x9AA6B3,
        OlympusStone = 0x9AA6B4,
        AuronsStatue = 0x9AA6B5,
        CursedMedallion = 0x9AA6B6,
        Present = 0x9AA6B7,
        DecoyPresents = 0x9AA6B8,
        IceCream = 0x9AA6B9,
        Picture = 0x9AA6BA
    }

    public enum Material
    {
        BlazingShard = 0x9AA67F,
        BlazingStone = 0x9AA680,
        BlazingGem = 0x9AA681,
        BlazingCrystal = 0x9AA682,
        LightningShard = 0x9AA687,
        LightningStone = 0x9AA688,
        LightningGem = 0x9AA689,
        LightningCrystal = 0x9AA68A,
        PowerShard = 0x9AA68B,
        PowerStone = 0x9AA68C,
        PowerGem = 0x9AA68D,
        PowerCrystal = 0x9AA68E,
        LucidShard = 0x9AA68F,
        LucidStone = 0x9AA690,
        LucidGem = 0x9AA691,
        LucidCrystal = 0x9AA692,
        DenseShard = 0x9AA693,
        DenseStone = 0x9AA694,
        DenseGem = 0x9AA695,
        DenseCrystal = 0x9AA696,
        TwilightShard = 0x9AA697,
        TwilightStone = 0x9AA698,
        TwilightGem = 0x9AA699,
        TwilightCrystal = 0x9AA69A,
        MythrilShard = 0x9AA69B,
        MythrilStone = 0x9AA69C,
        MytrilGem = 0x9AA69D,
        MythrilCrystal = 0x9AA69E,
        BrightShard = 0x9AA69F,
        BrightStone = 0x9AA6A0,
        BrightGem = 0x9AA6A1,
        BrightCrystal = 0x9AA6A2,
        EnergyShard = 0x9AA6A3,
        EnergyStone = 0x9AA6A4,
        EnergyGem = 0x9AA6A5,
        EnergyCrystal = 0x9AA6A6,
        SerenityShard = 0x9AA6A7,
        SerenityStone = 0x9AA6A8,
        SerenityGem = 0x9AA6A9,
        SerenityCrystal = 0x9AA6AA,
        OrichalcumPlus = 0x9AA6AB,
        Orichalcum = 0x9AA6BB,
        FrostShard = 0x9AA6BC,
        FrostStone = 0x9AA6BD,
        FrostGem = 0x9AA6BE,
        FrostCrystal = 0x9AA6BF,
        DarkShard = 0x9AA6DA,
        DarkStone = 0x9AA6DB,
        DarkGem = 0x9AA6DC,
        DarkCrystal = 0x9AA6DD,
        RemembranceShard = 0x9AA718,
        RemembranceStone = 0x9AA719,
        RemembranceGem = 0x9AA71A,
        RemembranceCrystal = 0x9AA71B,
        TranquilityShard = 0x9AA71C,
        TranquilityStone = 0x9AA71D,
        TranquilityGem = 0x9AA71E,
        TranquilityCrystal = 0x9AA71F,
        LostIllusion = 0x9AA720,
        ManifestIllusion = 0x9AA721
    }

    public enum Armor
    {
        ElvenBandana = 0x9AA62C,
        DivineBandana = 0x9AA62D,
        PowerBand = 0x9AA62E,
        BusterBand = 0x9AA636,
        ProtectBelt = 0x9AA637,
        GaiaBelt = 0x9AA63A,
        CosmicBelt = 0x9AA641,
        ShockCharm = 0x9AA642,
        ShockCharmPlus = 0x9AA643,
        GrandRibbon = 0x9AA644,
        FireBangle = 0x9AA647,
        FiraBangle = 0x9AA648,
        FiragaBangle = 0x9AA649,
        FiragunBangle = 0x9AA64A,
        BlizzardArmlet = 0x9AA64C,
        BlizzaraArmlet = 0x9AA64D,
        BlizzagaArmlet = 0x9AA64E,
        BlizzagunArmlet = 0x9AA64F,
        ThunderTrinket = 0x9AA652,
        ThundaraTrinket = 0x9AA653,
        ThundagaTrinket = 0x9AA654,
        ThundagunTrinket = 0x9AA655,
        ShadowAnklet = 0x9AA669,
        DarkAnklet = 0x9AA66B,
        MidnightAnklet = 0x9AA66C,
        ChaosAnklet = 0x9AA66D,
        AbasChain = 0x9AA66F,
        AegisChain = 0x9AA670,
        Acrisius = 0x9AA671,
        Ribbon = 0x9AA672,
        ChampionBelt = 0x9AA673,
        PetiteRibbon = 0x9AA674,
        AcrisiusPlus = 0x9AA675,
        CosmicChain = 0x9AA676
    }

    public enum Accessory
    {
        AbililityRing = 0x9AA5F7,
        EngineerRing = 0x9AA5F8,
        TechnicianRing = 0x9AA5F9,
        ExpertRing = 0x9AA5FA,
        SardonyxRing = 0x9AA5FB,
        TourmalineRing = 0x9AA5FC,
        AquamarineRing = 0x9AA5FD,
        GarnetRing = 0x9AA5FE,
        DiamondRing = 0x9AA5FF,
        SilverRing = 0x9AA600,
        GoldRing = 0x9AA601,
        PlatinumRing = 0x9AA602,
        MythrilRing = 0x9AA603,
        OrichalcumRing = 0x9AA60A,
        MasterRing = 0x9AA60B,
        MoonAmulet = 0x9AA60C,
        StarCharm = 0x9AA60E,
        SkillRing = 0x9AA60F,
        SkillfulRing = 0x9AA610,
        SoldierEarring = 0x9AA616,
        FencerEarring = 0x9AA617,
        MageEarring = 0x9AA618,
        SlayerEarring = 0x9AA61C,
        CosmicRing = 0x9AA61D,
        Medal = 0x9AA620,
        CosmicArts = 0x9AA621,
        ShadowArchive = 0x9AA622,
        ShadowArchivePlus = 0x9AA627,
        LuckyRing = 0x9AA628,
        FullBloom = 0x9AA629,
        DrawRing = 0x9AA62A,
        FullBloomPlus = 0x9AA62B,
        ExecutivesRing = 0x9AA725
    }

    public enum Magic
    {
        Fire = 0x9AA604,
        Blizzard = 0x9AA605,
        Thunder = 0x9AA606,
        Cure = 0x9AA607,
        Magnet = 0x9AA63F,
        Reflect = 0x9AA640
    }

    public enum WeaponWorld
    {
        BattlefieldsOfWar = 0x9AA61E, //Auron
        SwordOfTheAncestors = 0x9AA61F, //Mulan   
        BeastsClaw = 0x9AA623, //Beast
        BoneFist = 0x9AA624, //Jack Skellington
        ProudFang = 0x9AA625, //Simba
        SkillAndCrossbones = 0x9AA626, //Jack Sparrow
        Scimitar = 0x9AA630, //Aladdin
        WayToTheDawn = 0x9AA631, //Riku
        IdentityDisk = 0x9AA632 //Tron
    }
}

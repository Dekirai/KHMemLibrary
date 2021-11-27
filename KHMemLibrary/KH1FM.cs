using KHMemLibrary.KH1FMLib;
using Memory;

namespace KHMemLibrary
{
    public class KH1FM
    {
        Mem memory = new Mem();
        string process = "KINGDOM HEARTS FINAL MIX.exe";

        private void GetPID()
        {
            int pid = memory.GetProcIdFromName("KINGDOM HEARTS FINAL MIX");
            bool openProc = false;

            if (pid > 0) openProc = memory.OpenProcess(pid);
        }

        #region Read/Write functions

        public void WriteInt(int address, int value)
        {
            GetPID();
            memory.WriteMemory($"{process}+{((int)address).ToString("X8")}", "int", $"{value}");
        }

        public void WriteFloat(int address, float value)
        {
            GetPID();
            memory.WriteMemory($"{process}+{((int)address).ToString("X8")}", "float", $"{value}");
        }

        public void WriteString(int address, string value)
        {
            GetPID();
            memory.WriteMemory($"{process}+{((int)address).ToString("X8")}", "string", $"{value}");
        }

        public void WriteByte(int address, byte value)
        {
            GetPID();
            memory.WriteMemory($"{process}+{((int)address).ToString("X8")}", "byte", $"0x{value:X2}");
        }

        public void Write2Bytes(int address, byte value1, byte value2)
        {
            GetPID();
            memory.WriteMemory($"{process}+{((int)address).ToString("X8")}", "bytes", $"0x{value1:X2} 0x{value2:X2}");
        }

        public int ReadInt(int address)
        {
            GetPID();
            int result = memory.ReadInt($"{process}+{((int)address).ToString("X8")}");
            return result;
        }

        public float ReadFloat(int address)
        {
            GetPID();
            float result = memory.ReadFloat($"{process}+{((int)address).ToString("X8")}");
            return result;
        }

        public string ReadString(int address)
        {
            GetPID();
            string result = memory.ReadString($"{process}+{((int)address).ToString("X8")}");
            return result;
        }

        public byte ReadByte(int address)
        {
            GetPID();
            byte result = (byte)memory.ReadByte($"{process}+{((int)address).ToString("X8")}");
            return result;
        }

        #endregion

        /// <summary>
        /// Refills Sora's HP to his current max HP.
        /// </summary>
        public void RefillHP()
        {
            WriteInt(0x2D592CC, ReadInt(0x2D592D0));
        }

        /// <summary>
        /// Refills Sora's MP to his current max MP.
        /// </summary>
        public void RefillMP()
        {
            WriteInt(0x2D592D4, ReadInt(0x2D592D8));
        }

        /// <summary>
        /// Opens the save menu.
        /// </summary>
        public void SaveMenu()
        {
            WriteByte(0x2350CD4, 0x03);
        }

        /// <summary>
        /// Opens the party menu.
        /// </summary>
        public void PartyMenu()
        {
            WriteByte(0x2350CD8, 0x01);
        }

        /// <summary>
        /// Change the speed of the game.
        /// </summary>
        /// <param name="value">Default is 1</param>
        public void GameSpeed(float value)
        {
            WriteFloat(0x233C24C, value);
        }

        /// <summary>
        /// Change the multiplier of experience you gain.
        /// </summary>
        /// <param name="value">Default is 1</param>
        public void EXPMultiplier(float value)
        {
            WriteFloat(0x2A1C28, value);
        }

        /// <summary>
        /// Enable warp for the current session.
        /// </summary>
        public void EnableWarp(bool value)
        {
            if (value == true)
                Write2Bytes(0x2082FF, 0x90, 0x90);
            else if (value == false)
                Write2Bytes(0x2082FF, 0x76, 0x0A);
            else Console.WriteLine("[KH1FM - EnableWarp] Invalid bool value");
        }

        /// <summary>
        /// Trigger a custom warp.
        /// </summary>
        /// <param name="world"></param>
        /// <param name="spawnpoint"></param>
        public void TriggerWarp(WorldID world, byte spawnpoint)
        {
            WriteByte(0x233CB70, (byte)world);
            WriteByte(0x233CB74, spawnpoint);
            WriteByte(0x22E86E0, 0x0A);
            WriteByte(0x233C240, 0x05);
            WriteByte(0x22E86DC, 0x02);
        }

        /// <summary>
        /// Checks wether you are in the Gummi Ship (World Map) or not.
        /// </summary>
        public bool isGummi()
        {
            bool isGummi = false;
            int check = ReadByte(0x50421D);
            if (check == 1)
                isGummi = true;
            return isGummi;
        }

        /// <summary>
        /// Returns the current ID of the World you are currently in as an int.
        /// </summary>
        public int FetchWorldID()
        {
            int result = ReadByte(0x233CADC);
            return result;
        }

        /// <summary>
        /// Returns the current ID of the Room you are currently in as an int.
        /// </summary>
        public int FetchRoomID()
        {
            int result = ReadByte(0x233CB44);
            return result;
        }

        /// <summary>
        /// Returns the current World as a plain text.
        /// </summary>
        public async Task<string> FetchWorldText()
        {
            int world_get = ReadByte(0x233CADC);
            var world_fetch = await Worlds.GetWorld(world_get);
            string world = world_fetch[0];
            return world;
        }

        /// <summary>
        /// Returns the current Room as a plain text.
        /// </summary>
        public async Task<string> FetchRoomText()
        {
            int world_get = ReadByte(0x233CADC);
            var world_fetch = await Worlds.GetWorld(world_get);
            int room_get = ReadByte(0x233CB44);
            var room_fetch = await Rooms.GetRoom(world_fetch[0]);
            string room = room_fetch[room_get];
            return room;
        }

        /// <summary>
        /// Returns the current difficulty as a plain text.
        /// </summary>
        /// <returns></returns>
        public async Task<string> FetchDifficultyText()
        {
            int difficulty_get = ReadByte(0x2DFBDFC);
            var difficulty_fetch = await Difficulties.GetDifficulty(difficulty_get);
            string difficulty = difficulty_fetch[0];
            return difficulty;
        }

        /// <summary>
        /// Returns the current ID of the difficulty you are playing as an int.
        /// </summary>
        /// <returns></returns>
        public int FetchDifficultyID()
        {
            int difficultyid = ReadByte(0x2DFBDFC);
            return difficultyid;
        }

        /// <summary>
        /// Returns the current amount of munny you have.
        /// </summary>
        public int FetchMunny()
        {
            GetPID();
            int munny = ReadInt(0x2DFBDEC);
            return munny;
        }

        /// <summary>
        /// Returns your current FPS from the PC exclusive settings menu.
        /// </summary>
        public float FetchFPS()
        {
            float FPS = memory.ReadFloat($"{process}+22B72B0");
            return FPS;
        }

        /// <summary>
        /// Change the amount of munny you currently have. Maximum is 99999.
        /// </summary>
        /// <param name="value"></param>
        public void Munny(int value)
        {
            if (value > 99999)
                value = 99999;
            if (value < 0)
                value = 0;
            WriteInt(0x2DFBDEC, value);
        }

        /// <summary>
        /// Change the FPS from the PC exclusive settings menu temporarily.
        /// </summary>
        /// <param name="value">Valid values are 0, 30, 60 and 120</param>
        public void FPS(FPSValue value)
        {
            WriteFloat(0x22B72B0, (float)value);
        }

        /// <summary>
        /// Obtain a weapon in your inventory for Sora.
        /// </summary>
        public void AddWeaponSora(Keyblade item)
        {
            GetPID();
            memory.WriteMemory($"{process}+{((int)item).ToString("X8")}", "byte", $"0x01");
        }

        /// <summary>
        /// Modifies the stock of consumables. Maximum is 255.
        /// </summary>
        public void ModifyConsumable(Consumable item, int value)
        {
            GetPID();
            if (value > 255)
                value = 255;
            if (value < 0)
                value = 0;
            memory.WriteMemory($"{process}+{(int)item:X8}", "byte", $"0x{value:X}");
        }

        /// <summary>
        /// Kicks you back to the title screen.
        /// </summary>
        public void SoftReset()
        {
            WriteByte(0x22E86E0, 0x01);
            WriteByte(0x22E86DC, 0x02);
            WriteByte(0x233C240, 0x01);
        }

        /// <summary>
        /// Change the coordinate of Sora's X position.
        /// </summary>
        public void CoordX(float value)
        {
            GetPID();
            memory.WriteMemory($"{process}+023ED050,0x10", "float", $"{value}");
        }

        /// <summary>
        /// Change the coordinate of Sora's Y position.
        /// </summary>
        public void CoordY(float value)
        {
            GetPID();
            memory.WriteMemory($"{process}+023ED050,0x14", "float", $"{value}");
        }

        /// <summary>
        /// Change the coordinate of Sora's Z position.
        /// </summary>
        public void CoordZ(float value)
        {
            GetPID();
            memory.WriteMemory($"{process}+023ED050,0x18", "float", $"{value}");
        }
    }
}

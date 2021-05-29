﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using KHMemLibrary.KH2FMLib;
using Memory;

namespace KHMemLibrary
{
    public class KH2FM
    {
        Mem memory = new Mem();
        string process = "KINGDOM HEARTS II FINAL MIX.exe";

        private void GetPID()
        {
            int pid = memory.GetProcIdFromName("KINGDOM HEARTS II FINAL MIX");
            bool openProc = false;

            if (pid > 0) openProc = memory.OpenProcess(pid);
        }

        #region Read/Write Functions

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

        #region Write to memory

        /// <summary>
        /// Automatically clears all the atlantica songs by doing nothing.
        /// </summary>
        public void ClearAtlanticaSong()
        {
            GetPID();
            var world = ReadByte(0x714DB8);
            var room = ReadByte(0x714DB9);
            var event1 = ReadByte(0x714DBC);
            var event2 = ReadByte(0x714DBE);
            var event3 = ReadByte(0x714DC0);
            if (world == 0x0B)
            {
                if (room == 0x02 && event1 == 0x3F && event2 == 0x3F && event3 == 0x3F)
                    WriteInt(0xB63534, 1);
                else if (room == 0x04)
                {
                    if (event1 == 0x40 && event2 == 0x40 && event3 == 0x40)
                        WriteInt(0xB63544, 0);
                    else if (event1 == 0x37 && event2 == 0x37 && event3 == 0x37)
                        WriteInt(0xB63534, 30000);
                }
                else if (room == 0x01 && event1 == 0x33 && event2 == 0x33 && event3 == 0x33)
                    WriteInt(0xB63538, 5);
                else if (room == 0x03 && event1 == 0x35 && event2 == 0x35 && event3 == 0x35)
                    WriteInt(0xB63538, 10000);
                else if (room == 0x09 && event1 == 0x41 && event2 == 0x41 && event3 == 0x41)
                    WriteInt(0xB63538, 10000);
            }
        }

        /// <summary>
        /// Change the amount of anti points you currently have.
        /// </summary>
        /// <param name="value"></param>
        public void AntiPoints(int value)
        {
            WriteInt(0x9AA480, value);
        }

        /// <summary>
        /// Change the amount of munny you currently have. Maximum is 999999.
        /// </summary>
        /// <param name="value"></param>
        public void Munny(int value)
        {
            if (value > 99)
                value = 999999;
            if (value < 0)
                value = 0;
            WriteInt(0x9A94B0, value);
        }

        /// <summary>
        /// Change the speed of the game. Also affects physics.
        /// </summary>
        /// <param name="value">Default is 1</param>
        public void GameSpeed(float value)
        {
            WriteFloat(0x7151D4, value);
        }

        /// <summary>
        /// Change the FPS from the PC exclusive settings menu temporarily.
        /// </summary>
        /// <param name="value">Valid values are 0, 30, 60 and 120</param>
        public void FPS(FPSValue value)
        {
            WriteFloat(0x89E9D0, (int)value);
        }

        /// <summary>
        /// Sora/Roxas won't get hurt by attacks if set to true.
        /// </summary>
        /// <param name="value"></param>
        public void Invincible(bool value)
        {
            if (value == true)
                WriteByte(0x3D37BB, 0xEB);
            else if (value == false)
                WriteByte(0x3D37BB, 0x75);
        }

        /// <summary>
        /// You won't be able to pause the game if set to true.
        /// </summary>
        /// <param name="value"></param>
        public void BlockPause(bool value)
        {
            if (value == true)
                WriteByte(0xAB9038, 0x01);
            else if (value == false)
                WriteByte(0xAB9038, 0x00);
        }

        /// <summary>
        /// Aims to end an Event immediately. May not work on every Event.
        /// </summary>
        public void EndEvent()
        {
            WriteByte(0x2A0D3A0, 0x04);
            WriteByte(0x2A0D3A4, 0x10);
        }

        /// <summary>
        /// Warp to a custom area. Works best when using a timer or similar to spam it while entering a new room.
        /// </summary>
        /// <param name="WorldID"></param>
        /// <param name="RoomID"></param>
        /// <param name="SpawnID"></param>
        /// <param name="Event1ID"></param>
        /// <param name="Event2ID"></param>
        /// <param name="Event3ID"></param>
        public void Warp(byte WorldID, byte RoomID, byte SpawnID, byte Event1ID, byte Event2ID, byte Event3ID)
        {
            WriteByte(0x714DB8, WorldID);
            WriteByte(0x714DB9, RoomID);
            WriteByte(0x714DBA, SpawnID);
            WriteByte(0x714DBC, Event1ID);
            WriteByte(0x714DBE, Event2ID);
            WriteByte(0x714DC0, Event3ID);
        }

        /// <summary>
        /// Warp to a specific Event. Works best when using a timer or similar to spam it while entering a new room.
        /// </summary>
        /// <param name="WorldID"></param>
        /// <param name="RoomID"></param>
        /// <param name="EventID"></param>
        public void Event(byte WorldID, byte RoomID, byte EventID)
        {
            WriteByte(0x714DB8, WorldID);
            WriteByte(0x714DB9, RoomID);
            WriteByte(0x714DBC, EventID);
            WriteByte(0x714DBE, EventID);
            WriteByte(0x714DC0, EventID);
        }

        /// <summary>
        /// Kicks you back to the Titlescreen.
        /// </summary>
        public void SoftReset()
        {
            WriteByte(0xAB841A, 0x01);
            WriteInt(0x751310, 1);
        }

        /// <summary>
        /// Modifies your current total EXP to the entered Level.
        /// </summary>
        /// <param name="value"></param>
        public void Level(int value)
        {
            GetPID();
            if (value > 99 || value < 0)
            {
                Console.WriteLine("[KHMemLibrary] Invalid level value.");
                return;
            }
            var EXPTable = new List<int> { 0, 40, 100, 184, 296, 440, 620, 840, 1128, 1492, 1940, 2480, 3120, 3902, 4838, 5940, 7260, 8814, 10618, 12688, 15088, 17838, 20949, 24433, 28302, 32622, 37407, 42671, 48485, 54865, 61886, 69566, 77984, 87160, 97177, 108057, 119887, 132691, 146560, 161520, 177666, 195026, 213699, 233715, 255177, 278117, 302642, 328786, 356660, 386378, 417978, 450378, 483578, 517578, 552378, 587978, 624378, 661578, 699578, 738378, 777978, 818378, 859578, 901578, 944378, 987987, 1032378, 1077578, 1123578, 1170378, 1217978, 1266378, 1315578, 1365578, 1416378, 1467978, 1520378, 1573578, 1627578, 1682378, 1737978, 1794378, 1851578, 1909578, 1968378, 2027978, 2088378, 2149578, 2211578, 2274378, 2337978, 2402378, 2467578, 2533578, 2600378, 2667978, 2736378, 2805578, 2875578 };
            WriteInt(0x9AA750, EXPTable[value]);
            string level = value.ToString("X");
            memory.WriteMemory($"{process}+9A956F", "byte", $"0x{level}");
        }

        /// <summary>
        /// Sets the current world map barrier. Minimum is 0 and maximum is 22.
        /// </summary>
        /// <param name="value"></param>
        public void WorldBarrier(int value)
        {
            if (value > 22)
                value = 22;
            if (value < 0)
                value = 0;
            WriteInt(0x9AB209, value);
        }

        public void ModifyWorldAvailability(WorldAvailability availability, WorldAvailability_Access access, int visits, WorldAvailability_Barrier barrier)
        {
            WriteByte((int)availability, (byte)access);
            WriteByte((int)availability + 1, (byte)visits);
            WriteByte((int)availability + 3, (byte)barrier);
        }

        /// <summary>
        /// Modifies the destination of available warp points from the world map.
        /// </summary>
        /// <param name="origin"></param>
        /// <param name="world"></param>
        /// <param name="room"></param>
        /// <param name="spawn"></param>
        public void ModifyDestination(Destination origin, byte world, byte room, byte spawn)
        {
            Write2Bytes((int)origin, world, room);
            Write2Bytes((int)origin + 2, spawn, 0x00);
        }

        /// <summary>
        /// Modifies the party in different worlds.
        /// </summary>
        public void ModifyParty(PartyWorld world, PartyMember main, PartyMember first, PartyMember second, PartyMember third)
        {
            Write2Bytes((int)world, (byte)main, (byte)first);
            Write2Bytes((int)world + 2, (byte)second, (byte)third);
        }

        #region Refills

        /// <summary>
        /// Refills Sora's/Roxas' HP to his current max HP
        /// </summary>
        public void RefillHP()
        {
            GetPID();
            memory.WriteMemory($"{process}+2A20C58", "int", $"{memory.ReadInt($"{process}+2A20C5C")}");
        }

        /// <summary>
        /// Refills Sora's MP to his current max MP. Also resets the MP gauge if it's on cooldown.
        /// </summary>
        public void RefillMP()
        {
            GetPID();
            memory.WriteMemory($"{process}+2A20DD8", "int", $"{memory.ReadInt($"{process}+2A20DDC")}");
            memory.WriteMemory($"{process}+2A20E14", "float", "0");
        }

        /// <summary>
        /// Refills Sora's Drive Bar to his current max Drive.
        /// </summary>
        public void RefillDrive()
        {
            GetPID();
            memory.WriteMemory($"{process}+2A20E09", "byte", $"{memory.ReadByte($"{process}+2A20E0A")}");
            memory.WriteMemory($"{process}+2A20E08", "byte", "0x63");
        }

        #endregion

        #region BGM

        /// <summary>
        /// Sets a new BGM for the fields. Takes effect after switching areas.
        /// </summary>
        /// <param name="bgm">BGM ID</param>
        public void FieldBGM(BGM bgm)
        {
            GetPID();
            memory.WriteMemory($"{process}+AB8504", "int", $"{(int)bgm}");
        }

        /// <summary>
        /// Sets a new BGM for the battles. Takes effect after switching areas.
        /// </summary>
        /// <param name="bgm">BGM ID</param>
        public void BattleBGM(BGM bgm)
        {
            GetPID();
            memory.WriteMemory($"{process}+AB8514", "int", $"{(int)bgm}");
        }

        /// <summary>
        /// Shuffles the BGM for fields.
        /// </summary>
        public void RandomizeFieldBGM()
        {
            var random = new Random();
            var list = new List<int> { 50, 51, 52, 53, 54, 55, 59, 60, 61, 62, 63, 65, 66, 67, 68, 69, 81, 82, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 148, 149, 151, 152, 153, 154, 155, 158, 159, 164, 185, 186, 187, 188, 189, 190 };
            int index = random.Next(list.Count);
            GetPID();
            memory.WriteMemory($"{process}+AB8504", "int", $"{index}");
        }

        /// <summary>
        /// Shuffles the BGM for battles.
        /// </summary>
        public void RandomizeBattleBGM()
        {
            var random = new Random();
            var list = new List<int> { 50, 51, 52, 53, 54, 55, 59, 60, 61, 62, 63, 65, 66, 67, 68, 69, 81, 82, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 148, 149, 151, 152, 153, 154, 155, 158, 159, 164, 185, 186, 187, 188, 189, 190 };
            int index = random.Next(list.Count);
            GetPID();
            memory.WriteMemory($"{process}+AB8514", "int", $"{index}");
        }

        #endregion

        #region Items

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
        /// Modifies the stock of key items. Maximum is 255.
        /// </summary>
        public void ModifyKeyItem(KeyItem item, int value)
        {
            GetPID();
            if (value > 255)
                value = 255;
            if (value < 0)
                value = 0;
            memory.WriteMemory($"{process}+{(int)item:X8}", "byte", $"0x{value:X}");
        }

        /// <summary>
        /// Modifies the stock of materials. Maximum is 255.
        /// </summary>
        public void ModifyMaterial(Material item, int value)
        {
            GetPID();
            if (value > 255)
                value = 255;
            if (value < 0)
                value = 0;
            memory.WriteMemory($"{process}+{(int)item:X8}", "byte", $"0x{value:X}");
        }

        #endregion

        #region Equipment

        /// <summary>
        /// Adds an ability to a slot of your choice.
        /// </summary>
        public void AddAbility(AbilitySlot slot, Ability ability)
        {
            GetPID();
            var byte1 = (byte)(((int)ability & 0xFF00) >> 8);
            var byte2 = (byte)(((int)ability & 0x00FF));
            memory.WriteMemory($"{process}+{(int)slot:X8}", "bytes", $"0x{byte1:X} 0x{byte2:X}");
        }

        #region Add weapon

        /// <summary>
        /// Obtain a weapon in your inventory for Sora.
        /// </summary>
        public void AddWeaponSora(Keyblade item)
        {
            GetPID();
            memory.WriteMemory($"{process}+{((int)item).ToString("X8")}", "byte", $"0x01");
        }

        /// <summary>
        /// Obtain a weapon in your inventory for Donald.
        /// </summary>
        public void AddWeaponDonald(Staff item)
        {
            GetPID();
            memory.WriteMemory($"{process}+{((int)item).ToString("X8")}", "byte", $"0x01");
        }

        /// <summary>
        /// Obtain a weapon in your inventory for Goofy.
        /// </summary>
        public void AddWeaponGoofy(Shield item)
        {
            GetPID();
            memory.WriteMemory($"{process}+{(int)item:X8}", "byte", $"0x01");
        }

        #endregion

        #region Remove weapon

        /// <summary>
        /// Removes a weapon from your inventory for Sora.
        /// </summary>
        public void RemoveWeaponSora(Keyblade item)
        {
            GetPID();
            memory.WriteMemory($"{process}+{(int)item:X8}", "byte", $"0x00");
        }

        /// <summary>
        /// Removes a weapon from your inventory for Donald.
        /// </summary>
        public void RemoveWeaponDonald(Staff item)
        {
            GetPID();
            memory.WriteMemory($"{process}+{(int)item:X8}", "byte", $"0x00");
        }

        /// <summary>
        /// Removes a weapon from your inventory for Goofy.
        /// </summary>
        public void RemoveWeaponGoofy(Shield item)
        {
            GetPID();
            memory.WriteMemory($"{process}+{(int)item:X8}", "byte", $"0x00");
        }

        #endregion

        #region Equip weapon

        /// <summary>
        /// Equip a weapon for Sora. Takes effect after switching areas.
        /// </summary>
        public void EquipWeaponSora(KeybladeID item)
        {
            GetPID();
            memory.WriteMemory($"{process}+9A9560", "int", $"{(int)item}");
        }

        /// <summary>
        /// Equip a weapon for Donald. Takes effect after switching areas.
        /// </summary>
        public void EquipWeaponDonald(StaffID item)
        {
            GetPID();
            memory.WriteMemory($"{process}+9A9674", "int", $"{(int)item}");
        }

        /// <summary>
        /// Equip a weapon for Goofy. Takes effect after switching areas.
        /// </summary>
        public void EquipWeaponGoofy(ShieldID item)
        {
            GetPID();
            memory.WriteMemory($"{process}+9A9788", "int", $"{(int)item}");
        }

        #endregion

        #region Equip armor

        /// <summary>
        /// Equip an armor to Sora in a slot of your choice.
        /// </summary>
        public void EquipArmorSora(ArmorSlotSora slot, ArmorID armor)
        {
            GetPID();
            var byte1 = (byte)(((int)armor & 0xFF00) >> 8);
            var byte2 = (byte)(((int)armor & 0x00FF));
            memory.WriteMemory($"{process}+{(int)slot:X8}", "bytes", $"0x{byte1:X} 0x{byte2:X}");
        }

        /// <summary>
        /// Equip an armor to Donald in a slot of your choice.
        /// </summary>
        public void EquipArmorDonald(ArmorSlotDonald slot, ArmorID armor)
        {
            GetPID();
            var byte1 = (byte)(((int)armor & 0xFF00) >> 8);
            var byte2 = (byte)(((int)armor & 0x00FF));
            memory.WriteMemory($"{process}+{(int)slot:X8}", "bytes", $"0x{byte1:X} 0x{byte2:X}");
        }

        /// <summary>
        /// Equip an armor to Goofy in a slot of your choice.
        /// </summary>
        public void EquipArmorGoofy(ArmorSlotGoofy slot, ArmorID armor)
        {
            GetPID();
            var byte1 = (byte)(((int)armor & 0xFF00) >> 8);
            var byte2 = (byte)(((int)armor & 0x00FF));
            memory.WriteMemory($"{process}+{(int)slot:X8}", "bytes", $"0x{byte1:X} 0x{byte2:X}");
        }

        #endregion

        #region Equip accessory

        /// <summary>
        /// Equip an accessory to Sora in a slot of your choice.
        /// </summary>
        public void EquipAccessorySora(AccessorySlotSora slot, AccessoryID accessory)
        {
            GetPID();
            var byte1 = (byte)(((int)accessory & 0xFF00) >> 8);
            var byte2 = (byte)(((int)accessory & 0x00FF));
            memory.WriteMemory($"{process}+{(int)slot:X8}", "bytes", $"0x{byte1:X} 0x{byte2:X}");
        }

        /// <summary>
        /// Equip an accessory to Donald in a slot of your choice.
        /// </summary>
        public void EquipAccessoryDonald(AccessorySlotDonald slot, AccessoryID accessory)
        {
            GetPID();
            var byte1 = (byte)(((int)accessory & 0xFF00) >> 8);
            var byte2 = (byte)(((int)accessory & 0x00FF));
            memory.WriteMemory($"{process}+{(int)slot:X8}", "bytes", $"0x{byte1:X} 0x{byte2:X}");
        }

        /// <summary>
        /// Equip an accessory to Goofy in a slot of your choice.
        /// </summary>
        public void EquipAccessoryGoofy(AccessorySlotGoofy slot, AccessoryID accessory)
        {
            GetPID();
            var byte1 = (byte)(((int)accessory & 0xFF00) >> 8);
            var byte2 = (byte)(((int)accessory & 0x00FF));
            memory.WriteMemory($"{process}+{(int)slot:X8}", "bytes", $"0x{byte1:X} 0x{byte2:X}");
        }

        #endregion

        #endregion

        #endregion

        #region Read from memory

        /// <summary>
        /// Checks if a Map is loaded or not. Useful for Warp and Event.
        /// </summary>
        public bool isMapLoaded()
        {
            bool isMapLoaded = false;
            int check = ReadByte(0x9B8090);
            if (check == 1)
                isMapLoaded = true;
            return isMapLoaded;
        }

        /// <summary>
        /// Check if an Event has ben won or not.
        /// </summary>
        public bool hasEventWon()
        {
            bool hasEventWon = false;
            int check = ReadByte(0xAB8B50);
            if (check == 1)
                hasEventWon = true;
            return hasEventWon;
        }

        /// <summary>
        /// Returns the current Battle State as a string.
        /// </summary>
        /// <returns></returns>
        public string BattleStateText()
        {
            string result = "Idle";
            int battlestate = ReadByte(0x2A0EAC4);
            if (battlestate == 0)
                result = "Idle";
            else if (battlestate == 1)
                result = "Battle";
            else if (battlestate == 2)
                result = "Event";
            return result;
        }

        /// <summary>
        /// Returns the current Battle State as an int.
        /// </summary>
        /// <returns></returns>
        public int BattleStateID()
        {
            int battlestate = ReadByte(0x2A0EAC4);
            return battlestate;
        }

        /// <summary>
        /// Returns the current ID of the World you are currently in as an int.
        /// </summary>
        public int FetchWorldID()
        {
            int result = ReadByte(0x714DB8);
            return result;
        }

        /// <summary>
        /// Returns your current FPS from the PC exclusive settings menu.
        /// </summary>
        public float FetchFPS()
        {
            float FPS = memory.ReadFloat($"{process}+89E9D0");
            return FPS;
        }

        /// <summary>
        /// Returns the current ID of the Room you are currently in as an int.
        /// </summary>
        public int FetchRoomID()
        {
            int result = ReadByte(0x714DB9);
            return result;
        }

        /// <summary>
        /// Returns the current difficulty as a plain text.
        /// </summary>
        /// <returns></returns>
        public async Task<string> FetchDifficultyText()
        {
            int difficulty_get = ReadByte(0x9A9508);
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
            int difficultyid = ReadByte(0x9A9508);
            return difficultyid;
        }

        /// <summary>
        /// Returns the current ID of the spawn point as a hex value.
        /// </summary>
        public int FetchSpawnID()
        {
            int result = ReadByte(0x714DBA);
            return result;
        }

        /// <summary>
        /// Returns the current IDs of the Event you are currently in as a hex string.
        /// </summary>
        public string FetchEventID()
        {
            int event1 = ReadByte(0x714DBC);
            int event2 = ReadByte(0x714DBE);
            int event3 = ReadByte(0x714DC0);

            string result = $"{event1:X2}, {event2:X2}, {event3:X2}";
            return result;
        }

        /// <summary>
        /// Returns the current World as a plain text.
        /// </summary>
        public async Task<string> FetchWorldText()
        {
            int world_get = ReadByte(0x714DB8);
            var world_fetch = await Worlds.GetWorld(world_get);
            string world = world_fetch[0];
            return world;
        }

        /// <summary>
        /// Returns the current Room as a plain text.
        /// </summary>
        public async Task<string> FetchRoomText()
        {
            int world_get = ReadByte(0x714DB8);
            var world_fetch = await Worlds.GetWorld(world_get);
            int room_get = ReadByte(0x714DB9);
            var room_fetch = await Rooms.GetRoom(world_fetch[0]);
            string room = room_fetch[room_get];
            return room;
        }

        /// <summary>
        /// Returns the current BGM ID used in fields.
        /// </summary>
        public int FetchFieldBGM()
        {
            GetPID();
            int BGM = ReadByte(0xAB8504);
            return BGM;
        }

        /// <summary>
        /// Returns the current BGM ID used in battles.
        /// </summary>
        public int FetchBattleBGM()
        {
            GetPID();
            int BGM = ReadByte(0xAB8514);
            return BGM;
        }

        /// <summary>
        /// Returns the current amount of munny you have.
        /// </summary>
        public int FetchMunny()
        {
            GetPID();
            int munny = ReadInt(0x9A94B0);
            return munny;
        }

        #endregion
    }
}

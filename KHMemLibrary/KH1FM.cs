using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}

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

        /// <summary>
        /// Refills Sora's HP to his current max HP.
        /// </summary>
        public void RefillHP()
        {
            GetPID();
            memory.WriteMemory($"{process}+2D592CC", "int", $"{memory.ReadInt($"{process}+2D592D0")}");
        }

        /// <summary>
        /// Refills Sora's MP to his current max MP.
        /// </summary>
        public void RefillMP()
        {
            GetPID();
            memory.WriteMemory($"{process}+2D592D4", "int", $"{memory.ReadInt($"{process}+2D592D8")}");
        }

        /// <summary>
        /// Opens the save menu.
        /// </summary>
        public void SaveMenu()
        {
            GetPID();
            memory.WriteMemory($"{process}+2350CD4", "byte", $"0x03");
        }

        /// <summary>
        /// Opens the party menu.
        /// </summary>
        public void PartyMenu()
        {
            GetPID();
            memory.WriteMemory($"{process}+2350CD8", "byte", $"0x01");
        }

        /// <summary>
        /// Change the speed of the game.
        /// </summary>
        /// <param name="value">Default is 1</param>
        public void GameSpeed(float value)
        {
            GetPID();
            memory.WriteMemory($"{process}+233C24C", "float", $"{value}");
        }
    }
}

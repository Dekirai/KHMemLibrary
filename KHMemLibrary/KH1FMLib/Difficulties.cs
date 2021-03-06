using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHMemLibrary.KH1FMLib
{
    public class Difficulties
    {
        public static async Task<string[]> GetDifficulty(int difficulty)
        {
            List<string> getdifficulty = new List<string>();
            switch (difficulty)
            {
                case 0:
                    getdifficulty.Add("Beginner");
                    break;
                case 1:
                    getdifficulty.Add("Standard");
                    break;
                case 2:
                    getdifficulty.Add("Proud");
                    break;
            }
            return getdifficulty.ToArray();
        }
    }
}

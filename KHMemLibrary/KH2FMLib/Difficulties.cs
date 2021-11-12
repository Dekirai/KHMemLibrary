namespace KHMemLibrary.KH2FMLib
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
                case 3:
                    getdifficulty.Add("Critical");
                    break;
            }
            return getdifficulty.ToArray();
        }
    }
}

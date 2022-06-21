namespace CFilzenMain.Helpers
{
    public class LotteryHelper
    {
        public static int GenerateFLLotto()
        {
            Random rnd = new Random();
            return rnd.Next(1, 53);
        }

        public static int GenerateFLPowerballLotto()
        {
            Random rnd = new Random();
            return rnd.Next(1, 69);
        }
        
        public static int GenerateFLPowerball()
        {
            Random rnd = new Random();
            return rnd.Next(1, 26);
        }

        public static int GenerateMegaMillLotto()
        {
            Random rnd = new Random();
            return rnd.Next(1, 70);
        }

        public static int GenerateMegaMillMB()
        {
            Random rnd = new Random();
            return rnd.Next(1, 25);
        }

        public static int GenerateCash4LifeLotto()
        {
            Random rnd = new Random();
            return rnd.Next(1, 60);
        }

        public static int GenerateCash4LifeCB()
        {
            Random rnd = new Random();
            return rnd.Next(1, 4);
        }

        public static int GenerateJackpotTriplePlay()
        {
            Random rnd = new Random();
            return rnd.Next(1, 46);
        }

        public static int GenerateCashPopNumbers()
        {
            Random rnd = new Random();
            return rnd.Next(1, 15);
        }

        public static List<int> GenerateCashPop()
        {
            var plays = GenerateCashPopNumbers();
            var numbers = new List<int>();
            
            for (int i = 0; i < plays; i++)
            {
                Random rnd = new Random();
                numbers.Add(rnd.Next(1, 15));
            }

            return numbers;
        }
    }
}

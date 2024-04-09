namespace _06._Gold_Mine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberLocations = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberLocations; i++)
            {
                int expectedIncomeGold = int.Parse(Console.ReadLine());
                int numberDaysDiggingAtLocation = int.Parse(Console.ReadLine());
                int goldIncomeSum = 0;
                int a = 1;
                for (; a <= numberDaysDiggingAtLocation; a++)
                {
                    int goldIncome = int.Parse(Console.ReadLine());
                    goldIncomeSum += goldIncome;
                }
                a--;
                double goldIncomeSumD = goldIncomeSum, aD = a;
                double expectedIncomeGoldD = expectedIncomeGold;
                double averageGoldIncome = goldIncomeSumD / aD;
                if (averageGoldIncome >= expectedIncomeGoldD)
                {
                    Console.WriteLine
                    ($"Good job! Average gold per day: {averageGoldIncome:f2}.");
                }
                else
                {
                    double requiered = expectedIncomeGoldD - averageGoldIncome;
                    Console.WriteLine($"You need {requiered:f2} gold.");
                }


            }
        }
    }
}

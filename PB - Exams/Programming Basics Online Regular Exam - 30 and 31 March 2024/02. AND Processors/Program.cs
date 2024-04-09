namespace _02._AND_Processors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());
            int workingHours = numberOfWorkers * workingDays * 8;
            double workingHoursD = workingHours;
            double processorMade = Math.Floor(workingHoursD/3.0);
            if (processorMade>=n)
            {
                double result = processorMade - n;
                result *= 110.10;
                    Console.WriteLine($"Profit: -> {result:f2} BGN");
            }
            else
            {
                double result = n - processorMade;
                result *= 110.10;
                Console.WriteLine($"Losses: -> {result:f2} BGN");
            }
        }
    }
}

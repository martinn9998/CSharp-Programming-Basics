namespace _01._Mining_Rig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceVideoCard = double.Parse(Console.ReadLine());
            double priceAdapter = double.Parse(Console.ReadLine());
            double consummedACDay = double.Parse(Console.ReadLine());
            double profitDay = double.Parse(Console.ReadLine());

            

            double sumPriceVC = priceVideoCard * 13;
            double sumPriceAdapters = priceAdapter * 13;
            double sumSpendedMoney = sumPriceVC + sumPriceAdapters + 1000;
            double profitDayVC = profitDay - consummedACDay;
            double sumProfitDayVC = profitDayVC * 13;
            
            double daysReturning = Math.Ceiling(sumSpendedMoney / sumProfitDayVC);
            Console.WriteLine($"{sumSpendedMoney:f0}");
            Console.WriteLine($"{daysReturning}");



        }
    }
}

namespace _05._Christmas_Gifts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int adults = 0, kids = 0, toys = 0,
                swaters = 0;
            while (input != "Christmas")
            {
                if (int.Parse(input) > 16)
                {
                    adults++;
                    swaters++;
                }
                else if (int.Parse(input) >= 1 && int.Parse(input) <= 16)
                {
                    kids++;
                    toys++;
                }
                input = Console.ReadLine();
            }
            int moneyToys = toys * 5;
            int moneySweaters = swaters * 15;
            Console.WriteLine($"Number of adults: {adults}");
            Console.WriteLine($"Number of kids: {kids}");
            Console.WriteLine($"Money for toys: {moneyToys}");
            Console.WriteLine($"Money for sweaters: {moneySweaters}");
        }
    }
}

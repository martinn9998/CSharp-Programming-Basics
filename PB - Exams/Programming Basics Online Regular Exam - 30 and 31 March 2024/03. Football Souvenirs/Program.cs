namespace _03._Football_Souvenirs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string souvenirs = Console.ReadLine();
            double numberBought = double.Parse(Console.ReadLine());
            double price = 0;
            bool isTrue = true;
            switch (team)
            {
                case "Argentina":
                    if (souvenirs == "flags")
                    {
                        price = 3.25;
                    }
                    else if (souvenirs == "caps")
                    {
                        price = 7.20;
                    }
                    else if (souvenirs == "posters")
                    {
                        price = 5.10;
                    }
                    else if (souvenirs == "stickers")
                    {
                        price = 1.25;
                    }
                    else
                    {
                        isTrue = false;
                        Console.WriteLine("Invalid stock!");
                    }
                    break;
                case "Brazil":
                    if (souvenirs == "flags")
                    {
                        price = 4.20;
                    }
                    else if (souvenirs == "caps")
                    {
                        price = 8.50;
                    }
                    else if (souvenirs == "posters")
                    {
                        price = 5.35;
                    }
                    else if (souvenirs == "stickers")
                    {
                        price = 1.20;
                    }
                    else
                    {
                        isTrue = false;
                        Console.WriteLine("Invalid stock!");
                    }
                    break;
                case "Croatia":
                    if (souvenirs == "flags")
                    {
                        price = 2.75;
                    }
                    else if (souvenirs == "caps")
                    {
                        price = 6.90;
                    }
                    else if (souvenirs == "posters")
                    {
                        price = 4.95;
                    }
                    else if (souvenirs == "stickers")
                    {
                        price = 1.10;
                    }
                    else
                    {
                        isTrue = false;
                        Console.WriteLine("Invalid stock!");
                    }
                    break;
                case "Denmark":
                    if (souvenirs == "flags")
                    {
                        price = 3.10;
                    }
                    else if (souvenirs == "caps")
                    {
                        price = 6.50;
                    }
                    else if (souvenirs == "posters")
                    {
                        price = 4.80;
                    }
                    else if (souvenirs == "stickers")
                    {
                        price = 0.90;
                    }
                    else
                    {
                        isTrue = false;
                        Console.WriteLine("Invalid stock!");
                    }
                    break;
                default:
                    {
                        isTrue = false;
                        Console.WriteLine("Invalid country!");
                        break;
                    }
            }
            if (isTrue)
            {
                double priceCalc = numberBought * price;
                Console.WriteLine($"Pepi bought {numberBought} {souvenirs} of {team} for {priceCalc:f2} lv.");
            }
        }
    }
}

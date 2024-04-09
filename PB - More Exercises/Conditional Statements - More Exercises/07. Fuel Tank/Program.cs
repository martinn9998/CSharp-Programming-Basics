string fuelType = Console.ReadLine();
double ammount = double.Parse(Console.ReadLine());
switch (fuelType)
{
    case "Diesel":
        if (ammount >= 25)
        {
            Console.WriteLine($"You have enough diesel.");
        }
        else
        {
            Console.WriteLine($"Fill your tank with diesel!");
        }
        break;
    case "Gasoline":
        if (ammount >= 25)
        {
            Console.WriteLine($"You have enough gasoline.");
        }
        else
        {
            Console.WriteLine($"Fill your tank with gasoline!");
        }
        break;
    case "Gas":
        if (ammount >= 25)
        {
            Console.WriteLine($"You have enough gas.");
        }
        else
        {
            Console.WriteLine($"Fill your tank with gas!");
        }
        break;
    default:
        Console.WriteLine("Invalid fuel!");
        break;
}


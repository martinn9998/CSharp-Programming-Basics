double budget = double.Parse(Console.ReadLine());
string category = Console.ReadLine();
int numberPeopleInGroup = int.Parse(Console.ReadLine());
double transport = 0, remaining = 0;
if (numberPeopleInGroup >= 50 )
{
    transport = budget * 0.25;
    remaining = budget - transport;
}
else if (numberPeopleInGroup >= 25 && numberPeopleInGroup <= 49)
{
    transport = budget * 0.40;
    remaining = budget - transport;
}
else if (numberPeopleInGroup >= 10 && numberPeopleInGroup <= 24)
{
    transport = budget * 0.50;
    remaining = budget - transport;
}
else if (numberPeopleInGroup >= 5 && numberPeopleInGroup <= 9)
{
    transport = budget * 0.60;
    remaining = budget - transport;
}
else if (numberPeopleInGroup >= 1 && numberPeopleInGroup <= 4)
{
    transport = budget * 0.75;
    remaining = budget - transport;
}

double price = 0,remainingOfPrice = 0;
switch (category)
{
    case "Normal":

        price = 249.99;
        price *= numberPeopleInGroup;
        if (remaining >= price)
        {
            remainingOfPrice = remaining - price;
            Console.WriteLine($"Yes! You have {remainingOfPrice:f2} leva left.");
        }
        else
        {
            remainingOfPrice = price - remaining;
            Console.WriteLine($"Not enough money! You need {remainingOfPrice:f2} leva.");
        }
        break;


    case "VIP":

        price = 499.99;
        price *= numberPeopleInGroup;
        if (remaining >= price)
        {
            remainingOfPrice = remaining - price;
            Console.WriteLine($"Yes! You have {remainingOfPrice:f2} leva left.");
        }
        else
        {
            remainingOfPrice = price - remaining;
            Console.WriteLine($"Not enough money! You need {remainingOfPrice:f2} leva.");
        }
        break;
}
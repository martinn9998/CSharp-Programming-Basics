double budget = 0;
double people = 0;
double priceSum = 0;
double priceEasterBread = 4;
double price1Egg = 0.45;
people = double.Parse(Console.ReadLine());
budget = double.Parse(Console.ReadLine());
// Известно е, че един козунак стига за трима човека, като всеки гост ще получи и по 2 яйца. 
double neededEasterBreads = Math.Ceiling(people / 3);
double neededEggs = people * 2;
double priceEasterBreads = neededEasterBreads * priceEasterBread;
double priceEggs = neededEggs * price1Egg;
priceSum = priceEasterBreads + priceEggs;


if (budget >= priceSum)
{
    double remainingMoney = budget - priceSum;
    Console.WriteLine($"Lyubo bought {neededEasterBreads} Easter bread and {neededEggs} eggs.");
    Console.WriteLine($"He has {remainingMoney:f2} lv. left.");
}
else if (priceSum>budget) 
{
    double neededMoney = priceSum - budget;
    Console.WriteLine($"Lyubo doesn't have enough money.");
    Console.WriteLine($"He needs {neededMoney:f2} lv. more.");
}
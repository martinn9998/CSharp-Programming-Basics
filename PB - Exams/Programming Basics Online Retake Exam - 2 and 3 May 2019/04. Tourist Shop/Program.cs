double budget = double.Parse(Console.ReadLine());
string nameOfProduct = "";
double priceOfProduct = 0;
int count = 0;
double priceSum = 0;
bool isTrue = true;

while (true)
{
    nameOfProduct = Console.ReadLine();
    if (nameOfProduct == "Stop")
    {
        Console.WriteLine($"You bought {count} products for {priceSum:f2} leva.");
        isTrue = false;
        break;
    }

    count++;
    priceOfProduct = double.Parse(Console.ReadLine());

    if (count % 3 == 0)
    {
        priceOfProduct /= 2;
    }
    if (priceOfProduct > budget)
    {
        break;
    }
    priceSum += priceOfProduct;
    budget -= priceOfProduct;

}
if (isTrue)
{
    double remainingMoney = priceOfProduct - budget;
    Console.WriteLine($"You don't have enough money!");
    Console.WriteLine($"You need {remainingMoney:f2} leva!");
}
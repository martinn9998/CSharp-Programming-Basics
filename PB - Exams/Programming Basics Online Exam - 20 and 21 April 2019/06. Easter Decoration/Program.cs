double basket = 1.50;
double wreath = 3.80;
double chocolateBunny = 7.00;
double productCount = 0;
double priceSumForCurrentClient = 0;
double priceSum = 0;
string input = "";

double numberOfClients = double.Parse(Console.ReadLine());
for (int i = 0; i < numberOfClients; i++)
{
    while (true)
    {
        input = Console.ReadLine();
        if (input == "Finish")
        {
            break;
        }
        if (input == "basket")
        {

            productCount++;
            priceSumForCurrentClient += basket;
        }
        else if (input == "wreath")
        {

            productCount++;
            priceSumForCurrentClient += wreath;
        }
        if (input == "chocolate bunny")
        {

            productCount++;
            priceSumForCurrentClient += chocolateBunny;

        }
    }
    if (productCount % 2 == 0)
    {
        priceSumForCurrentClient *= 0.80;
    }
    priceSum += priceSumForCurrentClient;

    Console.WriteLine($"You purchased {productCount} items for {priceSumForCurrentClient:f2} leva.");
    priceSumForCurrentClient = 0;
    productCount = 0;
}
double averageBillPerClient = priceSum / numberOfClients;
Console.WriteLine($"Average bill per client is: {averageBillPerClient:f2} leva.");
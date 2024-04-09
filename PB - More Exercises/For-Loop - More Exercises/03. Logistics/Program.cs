int numberOFLoads = int.Parse(Console.ReadLine());
double weight = 0, price = 0, bus = 0, truck = 0, train = 0;
double weightSum = 0, priceSum = 0, weightBus = 0,weightTruck = 0;
double weightTrain = 0;
for (int i = 0; i < numberOFLoads; i++)
{
    weight = int.Parse(Console.ReadLine());
    if (weight >= 12)
    {
        price = 120;
        weightSum += weight;
        priceSum += weight * price;
        weightTrain += weight;
        train++;
    }
    else if (weight >= 4 && weight <= 11)
    {
        price = 175;
        weightSum += weight;
        priceSum += weight * price;
        weightTruck += weight;
        truck++;
    }
    else if (weight <= 3)
    {
        price = 200;
        weightSum += weight;
        priceSum += weight * price; 
        weightBus += weight;
        bus++;
    }
}
double average = (priceSum / weightSum);
double withBus = (weightBus / weightSum)*100;
double withTruck = (weightTruck / weightSum)*100;
double withTrain = (weightTrain / weightSum)*100;
Console.WriteLine($"{average:f2}");
Console.WriteLine($"{withBus:f2}%");
Console.WriteLine($"{withTruck:f2}%");
Console.WriteLine($"{withTrain:f2}%");
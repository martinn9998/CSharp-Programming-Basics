double months = double.Parse(Console.ReadLine());
double priceForElectricity = 0, priceOthers = 0, priceSum = 0,
    priceWater = 20, priceInternet = 15, priceElectricitySum = 0,
    priceOthersSum = 0, priceWaterSum = 0, priceInternetSum = 0;
for (int i = 0; i < months; i++)
{
    priceForElectricity = double.Parse(Console.ReadLine());
    priceOthers = (priceForElectricity + 20 + 15) * 1.20;

    priceElectricitySum += priceForElectricity;
    priceWaterSum += priceWater;
    priceInternetSum += priceInternet;
    priceOthersSum += priceOthers;
    priceSum += priceForElectricity + priceWater + priceInternet
        + priceOthers;
}
double average = priceSum / months;
Console.WriteLine($"Electricity: {priceElectricitySum:f2} lv");
Console.WriteLine($"Water: {priceWaterSum:f2} lv");
Console.WriteLine($"Internet: {priceInternetSum:f2} lv");
Console.WriteLine($"Other: {priceOthersSum:f2} lv");
Console.WriteLine($"Average: {average:f2} lv");
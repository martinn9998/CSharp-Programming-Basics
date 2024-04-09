//  Рибарите ползват допълнително 5 % отстъпка, ако са четен брой освен ако не е есен
//- тогава нямат допълнителна отстъпка, която се начислява след като
//се приспадне отстъпката по горните критерии.
 
int budjet = int.Parse(Console.ReadLine());
string seasone = Console.ReadLine();
int numberFisherman = int.Parse(Console.ReadLine());
double priceBoat = 0;
 
if (seasone == "Spring")
{
    priceBoat = 3000;
}
if (seasone == "Summer" || seasone == "Autumn")
{
    priceBoat = 4200;
}
if (seasone == "Winter")
{
    priceBoat = 2600;
}
if (numberFisherman <= 6)
{
    priceBoat *= 0.90;
}
if (numberFisherman >= 7 && numberFisherman <= 11)
{
    priceBoat *= 0.85;
}
if (numberFisherman > 12)
{
    priceBoat *= 0.75;
}
 
if (seasone != "Autumn" && numberFisherman % 2 == 0)
{
    priceBoat *= 0.95;
}
if (budjet >= priceBoat)
{
    Console.WriteLine($"Yes! You have {budjet - priceBoat:f2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {priceBoat - budjet:f2} leva.");
}
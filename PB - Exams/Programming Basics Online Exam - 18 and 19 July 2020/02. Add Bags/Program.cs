//up to 10kg price = 0.20 * over20KGPrice;
//between 20 and 10 kg price = 0.50 * over20KGPrice;
//above 20 kg price = read from console;

//above 30 days = price * 1.1;
//between 7 and 30 days = price * 1.15;
//less than 7 days = price * 1.4;

//finalPrice = luggagesNumber * price;

using System.Diagnostics;
using System;

double over20KGPrice = double.Parse(Console.ReadLine());
double kgOfLuggage = double.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());
int luggagesNumber = int.Parse(Console.ReadLine());
double price = 0;

if (kgOfLuggage > 20)
{
    price = over20KGPrice;
}
else if (kgOfLuggage >= 10 && kgOfLuggage <= 20)
{
    price = 0.50 * over20KGPrice;
}
else if (kgOfLuggage < 10)
{
    price = 0.20 * over20KGPrice;
}

if (days > 30)
{
    price *= 1.1;
}
else if (days >= 7 && days <= 30)
{
    price *= 1.15;
}
else if (days < 7)
{
    price *= 1.40;
}
double finalPrice = luggagesNumber * price;

Console.WriteLine($" The total price of bags is: {finalPrice:f2} lv. ");
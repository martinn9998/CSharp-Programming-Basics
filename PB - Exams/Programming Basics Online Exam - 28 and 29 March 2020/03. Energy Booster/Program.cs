//               Watermelon      Mango	         Pineapple	   Raspberry
//2 броя (small)	56 лв./бр.	   36.66 лв./бр.	42.10 лв./бр.	20 лв./бр.
//5 броя (big)	  28.70 лв./бр.	  19.60 лв./бр.  	24.80 лв./бр.	15.20 лв./бр.

string fruit = Console.ReadLine();
string setSize = Console.ReadLine();
double numberOfOrders = double.Parse(Console.ReadLine());
double price = 0;
double priceSum = 0;
if (fruit == "Watermelon")
{
    if (setSize == "small")
    {
        price = 56;
        priceSum = price * 2;
    }
    else if (setSize == "big")
    {
        price = 28.70;
        priceSum = price * 5;
    }
}
else if (fruit == "Mango")
{ 
    if (setSize == "small")
    {
        price = 36.66;
        priceSum = price * 2;
    }
    else if (setSize == "big")
    {
        price = 19.60;
        priceSum = price * 5;
    }
}
else if (fruit == "Pineapple")
{ 
    if (setSize == "small")
    {
        price = 42.10;
        priceSum = price * 2;
    }
    else if (setSize == "big")
    {
        price = 24.80;
        priceSum = price * 5;
    }
}
else if (fruit == "Raspberry")
{
    if (setSize == "small")
    {
        price = 20;
        priceSum = price * 2;
    }
    else if (setSize == "big")
    {
        price = 15.20;
        priceSum = price * 5;
    }
}
double finalPrice = priceSum * numberOfOrders;
if (finalPrice >= 400 && finalPrice <= 1000)
{
    finalPrice *= 0.85;
}
else if (finalPrice > 1000)
{
    finalPrice *= 0.50;
}

Console.WriteLine($"{finalPrice:f2} lv.");
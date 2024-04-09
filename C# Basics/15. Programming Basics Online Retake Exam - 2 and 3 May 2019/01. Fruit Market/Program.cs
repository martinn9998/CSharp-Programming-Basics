double strawberryPrice = double.Parse(Console.ReadLine());
double bananaKG = double.Parse(Console.ReadLine());
double orangesKG = double.Parse(Console.ReadLine());
double raspberryKG = double.Parse(Console.ReadLine());
double strawberryKG = double.Parse(Console.ReadLine());
double raspberryPrice = 0;
double orangesPrice = 0;
double bananasPrice = 0;
double sumAll = 0;

raspberryPrice = strawberryPrice * 0.5;
orangesPrice = raspberryPrice * 0.6;
bananasPrice = raspberryPrice * 0.2;
sumAll = strawberryPrice * strawberryKG + raspberryPrice
* raspberryKG + bananasPrice * bananaKG + orangesKG * orangesPrice;
Console.WriteLine($"{sumAll:f2}")


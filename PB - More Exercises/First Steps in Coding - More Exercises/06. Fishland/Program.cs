double priceMackerelKG = double.Parse(Console.ReadLine());
double priceSpratKG = double.Parse(Console.ReadLine());
double bonitoKG = double.Parse(Console.ReadLine());
double saffronKG = double.Parse(Console.ReadLine());
double musselsKG = double.Parse(Console.ReadLine());

double priceBonitoKG = priceMackerelKG * 1.60;
double priceSaffronKG = priceSpratKG * 1.80;
double priceMusselsKG = 7.50;

double bonitoSum = bonitoKG * priceBonitoKG;
double saffronSum = saffronKG * priceSaffronKG;
double sumMussels =  musselsKG * priceMusselsKG;
double bill = bonitoSum + saffronSum + sumMussels;
Console.WriteLine($"{bill:f2}");


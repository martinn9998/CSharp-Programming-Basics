double priceForKGVegetables = double.Parse(Console.ReadLine());
double priceForKGFruits = double.Parse(Console.ReadLine());
double sumKGVegetables = double.Parse(Console.ReadLine());
double sumKGFruits = double.Parse(Console.ReadLine());
double vegetableWorth = priceForKGVegetables * sumKGVegetables;
double fruitsWorth = priceForKGFruits * sumKGFruits;
double sum = vegetableWorth + fruitsWorth;
double convertToDollars = sum / 1.94;
Console.WriteLine($"{convertToDollars:f2}");
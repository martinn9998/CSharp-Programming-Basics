double rent = double.Parse(Console.ReadLine());
double cakePrice = rent * 0.20;
double drinksPrice = cakePrice * 0.55;
double animatorPrice = rent * (1.0 / 3.0);
double necessarySum = rent + cakePrice + drinksPrice + animatorPrice;
Console.WriteLine($"{necessarySum:f1}");
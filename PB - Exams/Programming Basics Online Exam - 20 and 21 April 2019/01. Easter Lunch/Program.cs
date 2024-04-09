double priceEasterBread  = 3.20;
double pricePeelEggs = 4.35;  // лв. за кора с 12 яйца
double priceCookies = 5.40;// лв. за килограм
double pricePaintingForEggs = 0.15; // лв. за яйце
double numberOfEasterBreads = double.Parse(Console.ReadLine());
double numberOfPeelsEggs = double.Parse(Console.ReadLine());
double ammountCookiesKGs = double.Parse(Console.ReadLine());
double priceEasterBread1 = priceEasterBread * numberOfEasterBreads;
double pricePeelEggs1 = pricePeelEggs * numberOfPeelsEggs;
double priceCookies1 = priceCookies * ammountCookiesKGs;
double pricePaintingForEggs1 = pricePaintingForEggs * (numberOfPeelsEggs * 12);
double priceSum = priceEasterBread1 + pricePeelEggs1 + priceCookies1 + pricePaintingForEggs1;
Console.WriteLine($"{priceSum:f2}");
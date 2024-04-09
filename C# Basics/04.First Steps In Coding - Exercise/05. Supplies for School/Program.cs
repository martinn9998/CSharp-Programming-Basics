double chemicalPackets = double.Parse(Console.ReadLine());
double markerPackets = double.Parse(Console.ReadLine());
double cleaningDetrgent = double.Parse(Console.ReadLine());
double percentDiscount = double.Parse(Console.ReadLine());

double priceChemicals = chemicalPackets * 5.80;

double priceMarkers = markerPackets * 7.20;

double priceCleaningDetergent = cleaningDetrgent * 1.20;

double priceSummary = priceChemicals + priceMarkers + priceCleaningDetergent;

double discountDecimal = percentDiscount / 100;

double discount = priceSummary * discountDecimal;

double priceWithDiscount = priceSummary - discount;

Console.WriteLine(priceWithDiscount);
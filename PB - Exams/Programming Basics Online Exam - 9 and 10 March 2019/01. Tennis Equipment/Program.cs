double oneRaquetPrice = double.Parse(Console.ReadLine());
double numberOfRaquets = double.Parse(Console.ReadLine());
double numberOfShoes = double.Parse(Console.ReadLine());
double shoePrice = 0;
shoePrice = oneRaquetPrice * (1.0 / 6.0);
double finalPrice = 0;
//друга екипировка, на стойност 20% от общата цена на закупените ракети и маратонки.
double sumPriceShoes = numberOfShoes * shoePrice;
double sumPriceRaquets = numberOfRaquets * oneRaquetPrice;
double anotherEquipmentSUmPrice = (sumPriceRaquets + sumPriceShoes) * 0.2;
finalPrice = numberOfRaquets * oneRaquetPrice + numberOfShoes * shoePrice + anotherEquipmentSUmPrice;
double paidByDjokovic = Math.Floor(finalPrice * (1.0 / 8.0));
double paidBySponsors = Math.Ceiling(finalPrice * (7.0 / 8.0));
Console.WriteLine($"Price to be paid by Djokovic {paidByDjokovic}");
Console.WriteLine($"Price to be paid by sponsors {paidBySponsors}");

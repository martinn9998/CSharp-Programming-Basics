string name = Console.ReadLine();
int numberOfTicketsAdults = int.Parse(Console.ReadLine());
int numberOfTicketsChildren = int.Parse(Console.ReadLine());
double netPriceForAdult = double.Parse(Console.ReadLine());
double serviceTax = double.Parse(Console.ReadLine());

double netPriceForChildren = netPriceForAdult * 0.3;
double priceSum = numberOfTicketsAdults * (netPriceForAdult + serviceTax) + numberOfTicketsChildren * (netPriceForChildren + serviceTax);
double profitAgency = priceSum * 0.2;
Console.WriteLine($"The profit of your agency from {name} tickets is {profitAgency:f2} lv.");

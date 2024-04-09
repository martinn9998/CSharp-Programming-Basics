int numberOfPeople = int.Parse(Console.ReadLine());
int numberNightStays = int.Parse(Console.ReadLine());
int numberOfTransportCards = int.Parse(Console.ReadLine());
int numberOfTicketsForMuseum = int.Parse(Console.ReadLine());


double priceNightStays = numberNightStays * 20;
double priceTransportCards = numberOfTransportCards * 1.60;
double priceMuseum = numberOfTicketsForMuseum * 6;
double sum = priceNightStays + priceTransportCards + priceMuseum;
double sumForWholeGroup = sum * numberOfPeople;
double sumExpenses = sumForWholeGroup * 1.25;

Console.WriteLine($"{sumExpenses:f2}");
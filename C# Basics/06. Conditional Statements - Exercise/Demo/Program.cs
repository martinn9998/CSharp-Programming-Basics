double budget = double.Parse(Console.ReadLine());
int videoCard = int.Parse(Console.ReadLine());
int processors = int.Parse(Console.ReadLine());
int ram = int.Parse(Console.ReadLine());

double videoCardPrice = videoCard * 250;
double processorsPrice = (videoCardPrice * 0.35) * processors;
double ramPrice = (videoCardPrice * 0.10) * ram;
double bill = videoCardPrice + processorsPrice + ramPrice;
double total = 0.0;

if (videoCard > processors)
{
    total = bill * 0.85;

}

if (total > budget)
{
    Console.WriteLine($"Not enough money! You need {(total - budget):f2} leva more!");
}
else
{
    Console.WriteLine($"You have {(budget - total):f2} leva left!");
}

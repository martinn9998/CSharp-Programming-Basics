//season       chrysanthemums	       Roses	         Tulips
//Spring / Summer	2.00 лв./бр.	4.10 лв./бр.	2.50 лв./бр.
//Autumn / Winter	3.75 лв./бр.	4.50 лв./бр.	4.15 лв./бр.

int boughtChrysanthemums = int.Parse(Console.ReadLine());
int boughtRoses = int.Parse(Console.ReadLine());
int boughtTulips = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
char ifItsHoliday = char.Parse(Console.ReadLine());
double priceChrysanthemums = 0, priceRoses = 0, priceTulips = 0;
if (season == "Spring" || season == "Summer")
{
    if (ifItsHoliday == 'Y')
    {
        priceChrysanthemums = 2 * 1.15;
        priceRoses = 4.10 * 1.15;
        priceTulips = 2.5 * 1.15;
    }
    else
    {
        priceChrysanthemums = 2;
        priceRoses = 4.10;
        priceTulips = 2.5;
    }
}
else if (season == "Autumn" || season == "Winter")
{
    if (ifItsHoliday == 'Y')
    {
        priceChrysanthemums = 3.75 * 1.15;
        priceRoses = 4.50 * 1.15;
        priceTulips = 4.15 * 1.15;
    }
    else
    {
        priceChrysanthemums = 3.75;
        priceRoses = 4.50;
        priceTulips = 4.15;
    }
}
double bouquet = boughtChrysanthemums * priceChrysanthemums + boughtRoses * priceRoses + boughtTulips * priceTulips;
double sumFlowers = boughtChrysanthemums + boughtRoses + boughtTulips;
if (sumFlowers>20)
{
    bouquet *= 0.80;
}
if (boughtRoses>=10 && season == "Winter")
{
    bouquet *= 0.90;
}
if (boughtTulips > 7 && season == "Spring")
{
    bouquet *= 0.95;
}

bouquet += 2;

Console.WriteLine($"{bouquet:f2}");
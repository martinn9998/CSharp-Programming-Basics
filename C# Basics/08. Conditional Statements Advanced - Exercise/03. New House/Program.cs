// напишете програма която да изчисли колко ще им струва,
// да си засадят определен брой цветя и дали наличния бюджет ще им е достатъчен.
// Различните цветя са с различни цени.
//  · Вид цветя -текст с възможности -"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
string flower = Console.ReadLine();
double numberFlower = double.Parse(Console.ReadLine());
double budget = double.Parse(Console.ReadLine());
 
double priceRoses = 5;
double priceDahlias = 3.80;
double priceTulips = 2.80;
double priceNarcissus = 3.00;
double priceGladiolus = 2.50;
double price = 0;
if (flower == "Roses" && numberFlower > 80)
{
    priceRoses *= 0.90;
}
if (flower == "Dahlias" && numberFlower > 90)
{
    priceDahlias *= 0.85;
}
if (flower == "Tulips" && numberFlower > 80)
{
    priceTulips *= 0.85;
}
if (flower == "Narcissus" && numberFlower < 120)
{
    priceNarcissus = priceNarcissus + priceNarcissus * 0.15;
}
if (flower == "Gladiolus" && numberFlower < 80)
{
    priceGladiolus = priceGladiolus + priceGladiolus * 0.20;
}
 
 
switch (flower)
{
    case "Roses":
 
        priceRoses = priceRoses * numberFlower;
        price = priceRoses;
        break;
    case "Dahlias":
 
        priceDahlias = priceDahlias * numberFlower;
        price = priceDahlias;
        break;
    case "Tulips":
        priceTulips = priceTulips * numberFlower;
        price = priceTulips;
        break;
    case "Narcissus":
        priceNarcissus = priceNarcissus * numberFlower;
        price = priceNarcissus;
        break;
    case "Gladiolus":
        priceGladiolus = priceGladiolus * numberFlower;
        price = priceGladiolus;
        break;
}
 
if (budget >= price)
{
    Console.WriteLine($"Hey, you have a great garden with {numberFlower} {flower} and {(budget - price):f2} leva left.");
}
 
else
{
    Console.WriteLine($"Not enough money, you need {Math.Abs(price - budget):f2} leva more.");
}
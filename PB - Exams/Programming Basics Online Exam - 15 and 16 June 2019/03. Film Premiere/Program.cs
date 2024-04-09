string projection = Console.ReadLine();
string packetForMovie = Console.ReadLine();
int ticketsNumber  = int.Parse(Console.ReadLine());
int packetPrice = 0;
double finalPrice = 0;
//       John Wick	Star Wars	Jumanji
//Drink	 12 лв./бр. 	18 лв. /бр. 	9 лв. /бр.
//Popcorn 15 лв. /бр.	25 лв. /бр. 	11 лв. /бр.
//Menu	  19 лв. /бр.	30 лв. /бр.	 14 лв. /бр.

if (projection == "John Wick")
{
    if (packetForMovie == "Drink")
    {
        packetPrice = 12;
    }
    else if (packetForMovie == "Popcorn")
    {
        packetPrice = 15;
    }
    else if (packetForMovie == "Menu")
    {
        packetPrice = 19;
    }
}
else if (projection == "Star Wars")
{
    if (packetForMovie == "Drink")
    {
        packetPrice = 18;
    }
    else if (packetForMovie == "Popcorn")
    {
        packetPrice = 25;
    }
    else if (packetForMovie == "Menu")
    {
        packetPrice = 30;
    }
}
else if (projection == "Jumanji")
{
    if (packetForMovie == "Drink")
    {
        packetPrice = 9;
    }
    else if (packetForMovie == "Popcorn")
    {
        packetPrice = 11;
    }
    else if (packetForMovie == "Menu")
    {
        packetPrice = 14;
    }
}
finalPrice = packetPrice * ticketsNumber;
if (projection=="Star Wars")
{
    if (ticketsNumber>=4)
    {
        finalPrice = finalPrice * 0.7;
    }
}

if (projection == "Jumanji")
{
    if (ticketsNumber == 2)
    {
        finalPrice = finalPrice * 0.85;
    }
}
Console.WriteLine($"Your bill is {finalPrice:f2} leva.");
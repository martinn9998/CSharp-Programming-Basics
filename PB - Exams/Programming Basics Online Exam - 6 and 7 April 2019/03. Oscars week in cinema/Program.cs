string nameMovie = Console.ReadLine();
string typeOfHall = Console.ReadLine();
double ticketsNumber = double.Parse(Console.ReadLine());
double priceTicket = 0;
double sumPriceTicket = 0;


if (typeOfHall == "normal")
{
    if (nameMovie == "A Star Is Born")
    {
        priceTicket = 7.50;
    }
    else if (nameMovie == "Bohemian Rhapsody")
    {
        priceTicket = 7.35;
    }
    else if (nameMovie == "Green Book")
    {
        priceTicket = 8.15;
    }
    else if (nameMovie == "The Favourite")
    {
        priceTicket = 8.75;
    }
}
else if (typeOfHall == "luxury")
{
    if (nameMovie == "A Star Is Born")
    {
        priceTicket = 10.50;
    }
    else if (nameMovie == "Bohemian Rhapsody")
    {
        priceTicket = 9.45;
    }
    else if (nameMovie == "Green Book")
    {
        priceTicket = 10.25;
    }
    else if (nameMovie == "The Favourite")
    {
        priceTicket = 11.55;
    }
}
else if (typeOfHall == "ultra luxury")
{
    if (nameMovie == "A Star Is Born")
    {
        priceTicket = 13.50;
    }
    else if (nameMovie == "Bohemian Rhapsody")
    {
        priceTicket = 12.75;
    }
    else if (nameMovie == "Green Book")
    {
        priceTicket = 13.25;
    }
    else if (nameMovie == "The Favourite")
    {
        priceTicket = 13.95;
    }
}


    sumPriceTicket = priceTicket * ticketsNumber;


    

Console.WriteLine($"{nameMovie} -> {sumPriceTicket:f2} lv.");
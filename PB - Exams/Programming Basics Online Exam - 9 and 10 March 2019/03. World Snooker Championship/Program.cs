while (true)
{
    string stageChampionship = Console.ReadLine();
    string typeTicket = Console.ReadLine();
    int ticketsNumber = int.Parse(Console.ReadLine());
    char photoWithTrophie = char.Parse(Console.ReadLine());

    if (ticketsNumber > 30)
    {
        break;
    }
    double priceTicket = 0;
    double finalPrice = 0;
    double photoWithTrophy = 40;

    if (stageChampionship == "Quarter final")
    {
        if (typeTicket == "Standard")
        {
            priceTicket = 55.50;
        }
        else if (typeTicket == "Premium")
        {
            priceTicket = 105.20;
        }
        else if (typeTicket == "VIP")
        {
            priceTicket = 118.90;
        }
    }
    else if (stageChampionship == "Semi final")
    {
        if (typeTicket == "Standard")
        {
            priceTicket = 75.88;
        }
        else if (typeTicket == "Premium")
        {
            priceTicket = 125.22;
        }
        else if (typeTicket == "VIP")
        {
            priceTicket = 300.40;
        }
    }
    else if (stageChampionship == "Final")
    {
        if (typeTicket == "Standard")
        {
            priceTicket = 110.10;
        }
        else if (typeTicket == "Premium")
        {
            priceTicket = 160.66;
        }
        else if (typeTicket == "VIP")
        {
            priceTicket = 400;
        }
    }

    finalPrice = priceTicket * ticketsNumber;

    if (finalPrice > 4000)
    {
        finalPrice *= 0.75;
        photoWithTrophie = 'N';
    }
    else if (finalPrice > 2500)
    {
        finalPrice *= 0.9;
    }

    if (photoWithTrophie == 'Y')
    {
        finalPrice += ticketsNumber * photoWithTrophy;
    }

    Console.WriteLine($"{finalPrice:f2}");
    break;
}
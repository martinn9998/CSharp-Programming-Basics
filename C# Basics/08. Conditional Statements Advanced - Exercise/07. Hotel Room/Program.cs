 string month = Console.ReadLine();
    int stay = int.Parse(Console.ReadLine());
    double studio = 0;
    double apartment = 0;
    double priceStudio = 0;
 
    if (month == "May" || month == "October")
    {
        studio = 50;
        apartment = 65 * stay;
        if (stay > 14)
        {
            priceStudio = studio * stay * 0.70;
 
        }
        else if (stay > 7)
        {
            priceStudio = studio * stay * 0.95;
        }
        else
        {
            priceStudio = studio * stay;
        }
    }
    if (month == "June" || month == "September")
    {
        studio = 75.20;
        apartment = 68.70 * stay;
 
        if (stay > 14)
        {
            priceStudio = studio * stay * 0.80;
        }
        else
        {
            priceStudio = studio * stay;
        }
    }
 
 
    if (month == "July" || month == "August")
    {
        studio = 76;
        apartment = 77 * stay;
        priceStudio = studio * stay;
 
    }
    if (stay > 14)
    {
        apartment = apartment * 0.9;
    }
 
    Console.WriteLine($"Apartment: {apartment:f2} lv.");
    Console.WriteLine($"Studio: {priceStudio:f2} lv.");
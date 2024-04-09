int dayStay = int.Parse(Console.ReadLine());
string typeRental = Console.ReadLine();
string feedback = Console.ReadLine();
dayStay = dayStay - 1;
if (dayStay <= 10 & dayStay >= 0)
{
    if (typeRental == "room for one person")
    {
        double price = dayStay * 18.00;
        if (feedback == "positive")
        {
            price = price * 1.25;
            Console.WriteLine($"{price:f2}");
        }
        else if (feedback == "negative")
        {
            price = price * 0.9;
            Console.WriteLine($"{price:f2}");
        }
    }
    else if (typeRental == "apartment")
    {
        double price = (dayStay * 25.00) * 0.7;
        if (feedback == "positive")
        {
            price = price * 1.25;
            Console.WriteLine($"{price:f2}");
        }
        else if (feedback == "negative")
        {
            price = price * 0.9;
            Console.WriteLine($"{price:f2}");
        }
    }
    else if (typeRental == "president apartment")
    {
        double price = (dayStay * 35.00) * 0.9;
        if (feedback == "positive")
        {
            price = price * 1.25;
            Console.WriteLine($"{price:f2}");
        }
        else if (feedback == "negative")
        {
            price = price * 0.9;
            Console.WriteLine($"{price:f2}");
        }
    }
}
else if (dayStay <= 15 & dayStay > 10)
{
    if (typeRental == "room for one person")
    {
        double price = dayStay * 18.00;
        if (feedback == "positive")
        {
            price = price * 1.25;
            Console.WriteLine($"{price:f2}");
        }
        else if (feedback == "negative")
        {
            price = price * 0.9;
            Console.WriteLine($"{price:f2}");
        }
    }
    else if (typeRental == "apartment")
    {
        double price = (dayStay * 25.00) * 0.65;
        if (feedback == "positive")
        {
            price = price * 1.25;
            Console.WriteLine($"{price:f2}");
        }
        else if (feedback == "negative")
        {
            price = price * 0.9;
            Console.WriteLine($"{price:f2}");
        }
    }
    else if (typeRental == "president apartment")
    {
        double price = (dayStay * 35.00) * 0.85;
        if (feedback == "positive")
        {
            price = price * 1.25;
            Console.WriteLine($"{price:f2}");
        }
        else if (feedback == "negative")
        {
            price = price * 0.9;
            Console.WriteLine($"{price:f2}");
        }
    }
}
else if (dayStay > 15 & dayStay <= 365)
{
    if (typeRental == "room for one person")
    {
        double price = dayStay * 18.00;
        if (feedback == "positive")
        {
            price = price * 1.25;
            Console.WriteLine($"{price:f2}");
        }
        else if (feedback == "negative")
        {
            price = price * 0.9;
            Console.WriteLine($"{price:f2}");
        }
    }
    else if (typeRental == "apartment")
    {
        double price = (dayStay * 25.00) * 0.50;
        if (feedback == "positive")
        {
            price = price * 1.25;
            Console.WriteLine($"{price:f2}");
        }
        else if (feedback == "negative")
        {
            price = price * 0.9;
            Console.WriteLine($"{price:f2}");
        }
    }
    else if (typeRental == "president apartment")
    {
        double price = (dayStay * 35.00) * 0.80;
        if (feedback == "positive")
        {
            price = price * 1.25;
            Console.WriteLine($"{price:f2}");
        }
        else if (feedback == "negative")
        {
            price = price * 0.9;
            Console.WriteLine($"{price:f2}");
        }
    }
}
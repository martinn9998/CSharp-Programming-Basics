string fruit = Console.ReadLine();
string day = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());
double price = 0;
if (fruit == "banana" & (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday"))
{
    price = 2.5;
    double finalPrice = price * quantity;
    Console.WriteLine("{0:f2}", finalPrice);
}
else if (fruit == "banana" & (day == "Saturday" || day == "Sunday"))
{
    price = 2.7;
    double finalPrice = price * quantity;
    Console.WriteLine("{0:f2}", finalPrice);
}
else if (fruit == "apple" & (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday"))
{
    price = 1.2;
    double finalPrice = price * quantity;
    Console.WriteLine("{0:f2}", finalPrice);
}
else if (fruit == "apple" & (day == "Saturday" || day == "Sunday"))
{
    price = 1.25;
    double finalPrice = price * quantity;
    Console.WriteLine("{0:f2}", finalPrice);
}
else if (fruit == "orange" & (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday"))
{
    price = 0.85;
    double finalPrice = price * quantity;
    Console.WriteLine("{0:f2}", finalPrice);
}
else if (fruit == "orange" & (day == "Saturday" || day == "Sunday"))
{
    price = 0.9;
    double finalPrice = price * quantity;
    Console.WriteLine("{0:f2}", finalPrice);
}
else if (fruit == "grapefruit" & (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday"))
{
    price = 1.45;
    double finalPrice = price * quantity;
    Console.WriteLine("{0:f2}", finalPrice);
}
else if (fruit == "grapefruit" & (day == "Saturday" || day == "Sunday"))
{
    price = 1.60;
    double finalPrice = price * quantity;
    Console.WriteLine("{0:f2}", finalPrice);
}
else if (fruit == "kiwi" & (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday"))
{
    price = 2.7;
    double finalPrice = price * quantity;
    Console.WriteLine("{0:f2}", finalPrice);
}
else if (fruit == "kiwi" & (day == "Saturday" || day == "Sunday"))
{
    price = 3;
    double finalPrice = price * quantity;
    Console.WriteLine("{0:f2}", finalPrice);
}
else if (fruit == "pineapple" & (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday"))
{
    price = 5.5;
    double finalPrice = price * quantity;
    Console.WriteLine("{0:f2}", finalPrice);
}
else if (fruit == "pineapple" & (day == "Saturday" || day == "Sunday"))
{
    price = 5.6;
    double finalPrice = price * quantity;
    Console.WriteLine("{0:f2}", finalPrice);
}
else if (fruit == "grapes" & (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday"))
{
    price = 3.85;
    double finalPrice = price * quantity;
    Console.WriteLine("{0:f2}", finalPrice);
}
else if (fruit == "grapes" & (day == "Saturday" || day == "Sunday"))
{
    price = 4.2;
    double finalPrice = price * quantity;
    Console.WriteLine("{0:f2}", finalPrice);
}
else
{
    Console.WriteLine("error");
}
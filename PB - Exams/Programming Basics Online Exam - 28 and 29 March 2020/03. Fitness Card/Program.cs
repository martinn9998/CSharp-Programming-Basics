double sumWeHave = double.Parse(Console.ReadLine());
string gender =  Console.ReadLine();
double age = double.Parse(Console.ReadLine());
string sport = Console.ReadLine();
double price = 0;
//Пол    Gym	Boxing	Yoga	Zumba	Dances	Pilates
//мъж	$42	     $41	$45	    $34	    $51	    $39
//жена	$35	     $37	$42	    $31	    $53	    $37

if (sport=="Gym")
{
    if (gender == "m")
    {
        price = 42;
    }
    else if (gender == "f")
    {
        price = 35;
    }
}
else if (sport == "Boxing")
{
    if (gender == "m")
    {
        price = 41;
    }
    else if (gender == "f")
    {
        price = 37;
    }
}
else if (sport == "Yoga")
{
    if (gender == "m")
    {
        price = 45;
    }
    else if (gender == "f")
    {
        price = 42;
    }
}
else if (sport == "Zumba")
{
    if (gender == "m")
    {
        price = 34;
    }
    else if (gender == "f")
    {
        price = 31;
    }
}
else if (sport == "Dances")
{
    if (gender == "m")
    {
        price = 51;
    }
    else if (gender == "f")
    {
        price = 53;
    }
}
else if (sport == "Pilates")
{
    if (gender == "m")
    {
        price = 39;
    }
    else if (gender == "f")
    {
        price = 37;
    }
}

if (age <= 19 && age >= 1)
{
    price *= 0.8;
}

if (sumWeHave>=price)
{
    Console.WriteLine($"You purchased a 1 month pass for {sport}.");
}
else
{
    double moneyNeeded = price - sumWeHave;
    Console.WriteLine($"You don't have enough money! You need ${moneyNeeded:f2} more.");
}
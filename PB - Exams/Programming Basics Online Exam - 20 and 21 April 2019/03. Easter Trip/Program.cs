//Дестинация  21-23 март  24-27 март  28-31 март
//Франция          30 лв.  35 лв.        40 лв.
//Италия        28 лв.  32 лв.       39 лв.
//Германия         32 лв. 37 лв.        43 лв.
string destination = Console.ReadLine();
string dateReservation = Console.ReadLine();
int nightStay = int.Parse(Console.ReadLine());
double price = 0;
switch (destination)
{
    case "France":
        if (dateReservation == "21-23")
        {
            price = 30;
        }
        else if (dateReservation == "24-27")
        {
            price = 35;
        }
        else if (dateReservation == "28-31")
        {
            price = 40;
        }
        break;
    case "Italy":
        if (dateReservation == "21-23")
        {
            price = 28;
        }
        else if (dateReservation == "24-27")
        {
            price = 32;
        }
        else if (dateReservation == "28-31")
        {
            price = 39;
        }
        break;
    case "Germany":
        if (dateReservation == "21-23")
        {
            price = 32;
        }
        else if (dateReservation == "24-27")
        {
            price = 37;
        }
        else if (dateReservation == "28-31")
        {
            price = 43;
        }
        break;

}


price = price * nightStay;

Console.WriteLine($"Easter trip to {destination} : {price:f2} leva.");
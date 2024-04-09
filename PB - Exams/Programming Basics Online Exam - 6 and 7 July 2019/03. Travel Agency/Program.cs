string nameOfCity = Console.ReadLine();
string typeOfPacket = Console.ReadLine();
string yesOrNo = Console.ReadLine();
int dayStay = int.Parse(Console.ReadLine());

if (dayStay <= 0)
{
    Console.WriteLine("Days must be positive number!");
    return;
}
if (dayStay > 7)
{
    dayStay--;
}

double cena = 0;
switch (nameOfCity)
{
    case "Bansko" or "Borovets":
        if (typeOfPacket == "withEquipment")
        {
            cena = 100 * dayStay;

            if (yesOrNo == "yes")
            {
                cena *= 0.9;
            }

        }
        else if (typeOfPacket == "noEquipment")
        {
            cena = 80 * dayStay;

            if (yesOrNo == "yes")
            {
                cena *= 0.95;
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
        break;

    case "Varna" or "Burgas":
        if (typeOfPacket == "withBreakfast")
        {
            cena = 130 * dayStay;

            if (yesOrNo == "yes")
            {
                cena *= 0.88;
            }

        }
        else if (typeOfPacket == "noBreakfast")
        {
            cena = 100 * dayStay;

            if (yesOrNo == "yes")
            {
                cena *= 0.93;
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }

        break;

    default:
        Console.WriteLine("Invalid input!");
        break;

}
if (cena > 0)
{
    Console.WriteLine($"The price is {cena:F2}lv! Have a nice time!");
}
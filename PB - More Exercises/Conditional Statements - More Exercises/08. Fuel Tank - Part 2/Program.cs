string fuelType = Console.ReadLine();
double ammount = double.Parse(Console.ReadLine());
string yesOrNo = Console.ReadLine();
double priceForLiter = 0,finalPrice = 0;
switch (fuelType)
{
    case "Diesel":
        priceForLiter = 2.33;
        if (yesOrNo == "Yes")
        {
            priceForLiter -= 0.12;
        }
        finalPrice = priceForLiter * ammount;
        if (ammount > 25)
        {
            finalPrice *= 0.90;
        }
        else if (ammount >= 20 && ammount <=25)
        {
            finalPrice *= 0.92;
        }
        break;
    case "Gasoline":
        priceForLiter = 2.22;
        if (yesOrNo == "Yes")
        {
            priceForLiter -= 0.18;
        }
        finalPrice = priceForLiter * ammount;
        if (ammount > 25)
        {
            finalPrice *= 0.90;
        }
        else if (ammount >= 20 && ammount <= 25)
        {
            finalPrice *= 0.92;
        }
        break;
    case "Gas":
        priceForLiter = 0.93;
        if (yesOrNo == "Yes")
        {
            priceForLiter -= 0.08;
        }
        finalPrice = priceForLiter * ammount;
        if (ammount > 25)
        {
            finalPrice *= 0.90;
        }
        else if (ammount >= 20 && ammount <= 25)
        {
            finalPrice *= 0.92;
        }
        break;
}

Console.WriteLine($"{finalPrice:f2} lv.");
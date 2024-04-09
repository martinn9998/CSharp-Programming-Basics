string contactTerm = Console.ReadLine();
string typeOfContract = Console.ReadLine();
string addedMobileInternet = Console.ReadLine();
int numberOfMothsToPay = int.Parse(Console.ReadLine());
double price = 0;
//Term type	Small	Middle	   Large	  ExtraLarge
//One	  9.98 лв.	18.99 лв.	25.98 лв.	35.99 лв.
//two	  8.58 лв.	17.09 лв.	23.59 лв.	31.79 лв.
if (typeOfContract == "Small")
{
    if (contactTerm == "one")
    {
        price = 9.98;
    }
    else if (contactTerm == "two")
    {
        price = 8.58;
    }
}
else if (typeOfContract == "Middle")
{
    if (contactTerm == "one")
    {
        price = 18.99;
    }
    else if (contactTerm == "two")
    {
        price = 17.09;
    }
}
else if (typeOfContract == "Large")
{
    if (contactTerm == "one")
    {
        price = 25.98;
    }
    else if (contactTerm == "two")
    {
        price = 23.59;
    }
}
else if (typeOfContract == "ExtraLarge")
{
    if (contactTerm == "one")
    {
        price = 35.99;
    }
    else if (contactTerm == "two")
    {
        price = 31.79;
    }
}
if (addedMobileInternet == "yes")
{
    if (price > 0 && price <= 10)
    {
        price += 5.50;
    }
    else if (price > 10 && price <= 30)
    {
        price += 4.35;
    }
    else if (price > 30)
    {
        price += 3.85;
    }

}
if (contactTerm == "two")
{
    price = price * 0.9625;
}
double finalPrice = price * numberOfMothsToPay;
Console.WriteLine($"{finalPrice:f2} lv.");
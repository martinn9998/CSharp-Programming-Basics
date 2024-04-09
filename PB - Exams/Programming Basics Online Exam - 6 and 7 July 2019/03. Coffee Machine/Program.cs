string drink = Console.ReadLine();
string sugar = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());
double price = 0;
double sum = 0;
int espressoCount = 0;
 //              Без захар	Нормално	Допълнително захар
//Еспресо	    0.90 лв./бр.	1 лв. /бр.	    1.20 лв. /бр.
//Капучино	1.00 лв. /бр.	1.20 лв. /бр.	1.60 лв. /бр.
//Чай	       0.50 лв. /бр.	0.60 лв. /бр.	0.70 лв. /бр.
if (sugar == "Without")
{
    if (drink == "Espresso")
    {
        price = 0.90;
        espressoCount++;
    }
    else if (drink == "Cappuccino")
    {
        price = 1.00;
    }
    else if (drink == "Tea")
    {
        price = 0.50;
    }
}
else if (sugar == "Normal")
{
     if (drink == "Espresso")
     {
        price = 1;
        espressoCount++;
    }
     else if (drink == "Cappuccino")
     {
        price = 1.20;
     }
     else if (drink == "Tea")
     {
        price = 0.60;
     }
}
else if (sugar == "Extra")
{
    if (drink == "Espresso")
    {
        price = 1.20;
        espressoCount++;
    }
    else if (drink == "Cappuccino")
    {
        price = 1.60;
    }
    else if (drink == "Tea")
    {
        price = 0.70;
    }
}
sum = price * quantity;
if (sugar == "Without")
{
    sum = sum * 0.65;

}
if (espressoCount==1)
{
    if (quantity>=5)
    {
        sum = sum * 0.75;
    }
}

if (sum>15)
{
    sum = sum * 0.8;
}
Console.WriteLine($"You bought {quantity} cups of {drink} for {sum:f2} lv.");
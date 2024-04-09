//Размер Единична цена	Отстъпка от цената
//90X130	110 лв.	 Над 30 броя – 5%
//                   Над 60 броя – 8%

//100X150	140 лв.	 Над 40 броя – 6%
//                   Над 80 броя – 10%

//130X180	190 лв.	 Над 20 броя – 7% 
//                   Над 50 броя – 12%

//200X300	250 лв.	 Над 25 броя – 9%
//                   Над 50 броя – 14%
double numberOfWindows = double.Parse(Console.ReadLine());
string typeOfWindows = Console.ReadLine();
string methodOfReceipt = Console.ReadLine();    
double sumPrice = 0;
double price = 0;
bool isTrue = true;
while (true)
{

    if (numberOfWindows < 10)
    {
        Console.WriteLine("Invalid order");
        isTrue = false;
        break;
    }

    if (typeOfWindows == "90X130")
    {
        price = 110 * numberOfWindows;
        if (numberOfWindows > 30 && numberOfWindows <= 60)
        {
            price *= 0.95;
        }
        else if (numberOfWindows > 60)
        {
            price *= 0.92;
        }
    }
    else if (typeOfWindows == "100X150")
    {
        price = 140 * numberOfWindows; 
        if (numberOfWindows > 40 && numberOfWindows <= 80)
        {
            price *= 0.94;
        }
        else if (numberOfWindows > 80)
        {
            price *= 0.90;
        }
    }
    else if (typeOfWindows == "130X180")
    {
        price = 190 * numberOfWindows;
        if (numberOfWindows > 20 && numberOfWindows <= 50)
        {
            price *= 0.93;
        }
        else if (numberOfWindows > 50)
        {
            price *= 0.88;
        }
    }
    else if (typeOfWindows == "200X300")
    {
        price = 250 * numberOfWindows;
        if (numberOfWindows > 25 && numberOfWindows <= 50)
        {
            price *= 0.91;
        }
        else if (numberOfWindows > 50)
        {
            price *= 0.86;
        }
    }
   
    if (methodOfReceipt== "With delivery")
    {
        price += 60;
    }
    else if (methodOfReceipt== "Without delivery")
    {
    }
    if (numberOfWindows > 99)
    {
        price *= 0.96;
    }
    break;
}
if (isTrue)
{
    Console.WriteLine($"{price:f2} BGN");
}
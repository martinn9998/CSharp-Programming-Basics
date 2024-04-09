

           //Червено(Red)   Зелено(Green)  Жълто(Yellow)
//Големи(Large)  16 лв.      12 лв.        9 лв.
//Средни(Medium) 13 лв.      9 лв.        7 лв.
//Малки(Small)   9 лв.       8 лв.        5 лв.

string sizeOfEggs = Console.ReadLine();
string colourOfEggs = Console.ReadLine();   
double numbersOfBatchs = double.Parse(Console.ReadLine());
double price = 0;

if (colourOfEggs=="Red")
{
    if (sizeOfEggs=="Large")
    {
        price = 16;
    }
    else if (sizeOfEggs == "Medium")
    {
        price = 13;
    }
    else if (sizeOfEggs == "Small")
    {
        price = 9;
    }
}
else if (colourOfEggs == "Green")
{
    if (sizeOfEggs == "Large")
    {
        price = 12;
    }
    else if (sizeOfEggs == "Medium")
    {
        price = 9;
    }
    else if (sizeOfEggs == "Small")
    {
        price = 8;
    }
}
else if (colourOfEggs == "Yellow")
{
    if (sizeOfEggs == "Large")
    {
        price = 9;
    }
    else if (sizeOfEggs == "Medium")
    {
        price = 7;
    }
    else if (sizeOfEggs == "Small")
    {
        price = 5;
    }
}
double priceSum = price * numbersOfBatchs;
priceSum = 0.65 * priceSum;
Console.WriteLine($"{priceSum:f2} leva.");
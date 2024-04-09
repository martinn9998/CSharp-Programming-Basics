double neededMoney = double.Parse(Console.ReadLine());
double avaliableMoney = double.Parse(Console.ReadLine());
int days = 0;
int count = 0;
while (avaliableMoney < neededMoney)
{
    string input = Console.ReadLine();
    double money = double.Parse(Console.ReadLine());
    days++;
 
    if (input == "spend")
    {
        count++;
 
        if (count == 5)
        {
            Console.WriteLine("You can't save the money.");
            Console.WriteLine(days);
            break;
        }
        avaliableMoney -= money;
        if (avaliableMoney < 0)
        {
            avaliableMoney = 0;
        }
    }
    else //save
    {
        count = 0;
        avaliableMoney += money;
    }
}
if (avaliableMoney >= neededMoney)
{
    Console.WriteLine($"You saved the money for {days} days.");
}
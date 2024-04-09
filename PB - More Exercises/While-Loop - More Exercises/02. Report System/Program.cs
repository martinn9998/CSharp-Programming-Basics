int requieredAmmount = int.Parse(Console.ReadLine());
string input = Console.ReadLine();

int allMoney = 0;
int count = 0;
int card = 0;
int cardPayment = 0;
int cash = 0;
int cashPayment = 0;

while (input != "End")
{
    int moneyTransfer = int.Parse(input);
    count++;

    if (count % 2 == 0)
    {
        if (moneyTransfer < 10)
            Console.WriteLine("Error in transaction!");
        else
        {
            Console.WriteLine("Product sold!");
            allMoney += moneyTransfer;
            card++;
            cardPayment += moneyTransfer;
        }
    }
    else
    {
        if (moneyTransfer > 100)
            Console.WriteLine("Error in transaction!");
        else
        {
            Console.WriteLine("Product sold!");
            allMoney += moneyTransfer;
            cash++;
            cashPayment += moneyTransfer;

        }
    }
    if (allMoney >= requieredAmmount)
    {
        Console.WriteLine($"Average CS: {(double)cashPayment / cash:F2}");
        Console.WriteLine($"Average CC: {(double)cardPayment / card:F2}");
        break;
    }

    input = Console.ReadLine();
}
if (input == "End")
{
    Console.WriteLine("Failed to collect required money for charity.");
}
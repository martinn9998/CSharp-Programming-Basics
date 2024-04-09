int roomCapacity = int.Parse(Console.ReadLine());
string text = "";
int peopleNumber = 0;
double income = 0;
double incomeSum = 0;
bool full = true;
while (roomCapacity >= 0)
{
    text = Console.ReadLine();
    if (text == "Movie time!")
    {
        Console.WriteLine($"There are {roomCapacity} seats left in the cinema.");
        Console.WriteLine($"Cinema income - {Math.Floor(incomeSum)} lv.");
        full = false;
        break;
    }
    peopleNumber = int.Parse(text);
    roomCapacity -= peopleNumber;
    if (roomCapacity < 0)
    {
        break;
    }
    income = peopleNumber * 5;

    if (peopleNumber % 3 == 0)
    {
        income = income - 5;
    }
    incomeSum += income;
}

    if (full)
{
    Console.WriteLine($"The cinema is full.");
    Console.WriteLine($"Cinema income - {Math.Floor(incomeSum)} lv.");
}
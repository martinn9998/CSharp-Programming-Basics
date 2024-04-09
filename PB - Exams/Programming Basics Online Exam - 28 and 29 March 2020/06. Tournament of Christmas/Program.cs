double numberOfTournirs = double.Parse(Console.ReadLine());
string sport = string.Empty;
string result = string.Empty;
double won = 0;
double lost = 0;
double moneySum = 0;
double dayWon = 0;
double dayLost = 0;
double moneyAllSum = 0;
for (int i = 0; i < numberOfTournirs; i++)  
{
    
    while (true)
    {
        sport = Console.ReadLine();
        if (sport == "Finish")
        {
            if (won > lost)
            {
                moneySum *= 1.10;
                moneyAllSum += moneySum;
                dayWon++;
                won = 0;
                lost = 0;
                moneySum = 0;
                break;
            }
            else
            {
                dayLost++;
                won = 0;
                lost = 0;
                moneyAllSum += moneySum;
                moneySum = 0;
                break;
            }
        }
        result = Console.ReadLine();
        if (result == "win")
        {
            won++;
            moneySum += 20;
        }
        else
        {
            lost++;
        }
    }
}
if (dayWon > dayLost)
{
    moneyAllSum *= 1.20;
    Console.WriteLine($"You won the tournament! Total raised money: {moneyAllSum:f2}");
}
else
{
    Console.WriteLine($"You lost the tournament! Total raised money: {moneyAllSum:f2}");
}
double maxNumber = double.MinValue;
string nameMaxGoals = string.Empty;
while (true)
{
    string nameOfPLayer = Console.ReadLine();
    if (nameOfPLayer == "END")
    {
        break;
    }
    string input = Console.ReadLine();
    if (input == "END")
    {
        break;
    }
    double numberOfGoalScores = double.Parse(input);
    if (numberOfGoalScores>maxNumber)
    {
        maxNumber = numberOfGoalScores;
        nameMaxGoals = nameOfPLayer;
    }
    if (numberOfGoalScores>=10)
    {
        break;
    }
}
Console.WriteLine($"{nameMaxGoals} is the best player!");
if (maxNumber >= 3)
{
    Console.WriteLine($"He has scored {maxNumber} goals and made a hat-trick !!!");
}
else
{
    Console.WriteLine($"He has scored {maxNumber} goals.");
}
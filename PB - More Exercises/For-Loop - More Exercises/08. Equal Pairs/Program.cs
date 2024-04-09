int couples = int.Parse(Console.ReadLine());
int firstNumber = 0, secondNumber = 0, sumOfPair = 0,
     couple = 0, couple1 = 0, couple2 = 0,
    firstCouple = 0, secondCouple = 0;
for (int i = 0; i < couples; i++)
{
    firstNumber = int.Parse(Console.ReadLine());
    secondNumber = int.Parse(Console.ReadLine());
    couple++;
    sumOfPair = firstNumber + secondNumber;
    if (couple ==1)
    {
        couple1++;
        firstCouple = sumOfPair;
    }
    else if (couple == 2)
    {
        couple2++;
        secondCouple = sumOfPair;
        couple = 0;
    }
}
if (couple2==0)
{
    Console.WriteLine($"Yes, value={firstCouple}");
}
else if (firstCouple == secondCouple)
{
    Console.WriteLine($"Yes, value={firstCouple}");
}
else if (firstCouple>secondCouple)
{

    double result = firstCouple - secondCouple;
    Console.WriteLine($"No, maxdiff={result}");
}
else if (secondCouple>firstCouple)
{
    double result = secondCouple - firstCouple;
    Console.WriteLine($"No, maxdiff={result}");
}
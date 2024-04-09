double n = double.Parse(Console.ReadLine());
double oddSum = 0, oddMin = int.MaxValue, oddMax = int.MinValue,
    evenSum = 0, oddMinCount = 0, oddMaxCount = 0,
    evenMin = int.MaxValue, evenMax = int.MinValue, input = 0,
    evenMinCount = 0, evenMaxCount = 0;
for  (int i = 1; i <= n; i++)
{
    input = double.Parse(Console.ReadLine());
   
    if (i % 2 == 0)
    {
        if (input>evenMax)
        {
            evenMax = input;
            evenMaxCount++;
        }
        if (input<evenMin)
        {
            evenMin = input;
            evenMinCount++;
        }
        evenSum += input;
    }
    else 
    {
        if (input >oddMax)
        {
            oddMax = input;
            oddMaxCount++;
        }
        if (input < oddMin)
        {
            oddMin = input;
            oddMinCount++;
        }
        oddSum += input;
    }
}

Console.WriteLine($"OddSum={oddSum:f2},");
if (oddMinCount==0)
{
    Console.WriteLine($"OddMin=No,");
}
else
{
    Console.WriteLine($"OddMin={oddMin:f2},");
}
if (oddMaxCount == 0)
{
    Console.WriteLine($"OddMax=No,");
}
else
{
    Console.WriteLine($"OddMax={oddMax:f2},");
}
Console.WriteLine($"EvenSum={evenSum:f2},");
if (evenMinCount == 0)
{
    Console.WriteLine($"EvenMin=No,");
}
else
{
    Console.WriteLine($"EvenMin={evenMin:f2},");
}
if (evenMaxCount == 0)
{
    Console.WriteLine($"EvenMax=No");
}
else
{
    Console.WriteLine($"EvenMax={evenMax:f2}");
}
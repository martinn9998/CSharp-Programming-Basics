int n = int.Parse(Console.ReadLine());
int num = 0;
int sum = 0;
int max = 0;
for (int i = 0; i < n; i++)
{
    num = int.Parse(Console.ReadLine());
    sum += num;
    if (i == 0)
    {
        max = num;
    }
    else
    {
        if (num > max)
        {
            max = num;
        }
    }
}
int sumWithoutMaxNumber = sum - max;
if (max > sumWithoutMaxNumber)
{

    int diff = Math.Abs(max - sumWithoutMaxNumber);
    Console.WriteLine("No");
    Console.WriteLine("Diff = " + diff);



}
else if (sumWithoutMaxNumber > max)
{
    int diff = Math.Abs(max - sumWithoutMaxNumber);
    Console.WriteLine("No");
    Console.WriteLine("Diff = " + diff);

}
else if (sumWithoutMaxNumber == max)
{
    Console.WriteLine("Yes");
    Console.WriteLine("Sum = " + max);
}

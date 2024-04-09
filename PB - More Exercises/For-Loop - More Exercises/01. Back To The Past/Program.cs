double inheritedMoney = double.Parse(Console.ReadLine());
int year = int.Parse(Console.ReadLine());
int expences = 0;
int yearsOfIvancho = 18;

for (int i = 1800; i <= year; i++)
{
    if (i % 2 == 0)
    {
        expences = 12000;
        inheritedMoney -= expences;
    }
    else if (i % 2 == 1)
    {
        expences = 12000 + (50 * yearsOfIvancho);
        inheritedMoney -= expences;
    }
    yearsOfIvancho++;
}
if (inheritedMoney >= 0)
{
    Console.WriteLine($"Yes! He will live a carefree life and will have {inheritedMoney:f2} dollars left.");
}
else
{
    Console.WriteLine($"He will need {Math.Abs(inheritedMoney):f2} dollars to survive.");
}
double budgetForActors = double.Parse(Console.ReadLine());
double budgetSum = budgetForActors;
string nameOfActor = "";
double reward = 0;
bool bool1 = false;
while (true)
{
    nameOfActor = Console.ReadLine();
    if (nameOfActor == "ACTION")
    {
        break;
    }
    if (nameOfActor.Length <= 15)
    {
        reward = double.Parse(Console.ReadLine());
        budgetSum -= reward;
    }
    else
    {
        reward = budgetSum * 0.2;
        budgetSum -= reward;
    }
    if (budgetSum<=0)
    {
        bool1 = true;
        break;
    }    
}
if (bool1)
{
    budgetSum = Math.Abs(budgetSum);
    Console.WriteLine($"We need {budgetSum:f2} leva for our actors.");
}
else
{
    Console.WriteLine($"We are left with {budgetSum:f2} leva.");
}
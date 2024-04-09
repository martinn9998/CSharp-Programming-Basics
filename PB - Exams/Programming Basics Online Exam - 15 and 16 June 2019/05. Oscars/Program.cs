string nameOfActor = Console.ReadLine();
double pointsFromAcademy = double.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
double allPoints = pointsFromAcademy;
for (int i = 0; i < n; i++)
{
    string nameOfJudge = Console.ReadLine();
    double pointsFromJudge = double.Parse(Console.ReadLine());
    allPoints += (pointsFromJudge * nameOfJudge.Length) / 2;
    if (allPoints > 1250.5)
    {
        i = n;
        Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {allPoints:f1}!");
    }
}
if (allPoints <= 1250.5)
{
    Console.WriteLine($"Sorry, {nameOfActor} you need {(1250.5 - allPoints):f1} more!");
}
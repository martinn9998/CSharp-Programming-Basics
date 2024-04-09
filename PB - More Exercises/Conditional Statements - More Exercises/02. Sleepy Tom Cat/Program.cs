int numberOfRestingDays = int.Parse(Console.ReadLine());
int minutesGame = numberOfRestingDays * 127;
int minutesGameYear = (365 - numberOfRestingDays) * 63;
double minutesGameSum = minutesGame + minutesGameYear;
if (30000 >= minutesGameSum)
{
    double remaining = 30000 - minutesGameSum;
    double hoursCalculation = Math.Floor(remaining / 60);
    double minutesCalculation = Math.Floor(remaining % 60);
    Console.WriteLine($"Tom sleeps well");
    Console.WriteLine($"{hoursCalculation} hours and {minutesCalculation} minutes less for play");
}
else
{
    double less = minutesGameSum - 30000;
    double hoursCalculation = Math.Floor(less / 60);
    double minutesCalculation = Math.Floor(less % 60);
    Console.WriteLine($"Tom will run away");
    Console.WriteLine($"{hoursCalculation} hours and {minutesCalculation} minutes more for play");
}
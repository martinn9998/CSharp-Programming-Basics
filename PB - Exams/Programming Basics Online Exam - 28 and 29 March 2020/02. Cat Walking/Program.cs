double minutesPerDay = double.Parse(Console.ReadLine());
double walksPerDay = double.Parse((Console.ReadLine()));
double caloriesRecievedForTheDay = double.Parse((Console.ReadLine()));
double wholeTime = minutesPerDay * walksPerDay;
double sumCaloriesBurnedForTheDay = wholeTime * 5;
double fiftyPercent = caloriesRecievedForTheDay * 0.5;

if (sumCaloriesBurnedForTheDay>=fiftyPercent)
{
    Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {Math.Floor(sumCaloriesBurnedForTheDay)}.");
}
else
{
    Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {Math.Floor(sumCaloriesBurnedForTheDay)}.");
}
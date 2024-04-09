int numberDays = int.Parse(Console.ReadLine());
int leftFoodKG = int.Parse(Console.ReadLine());
double foodForDogForADayKG = double.Parse(Console.ReadLine());
double foodForCatForADayKG = double.Parse(Console.ReadLine());
double foodForTurtleForADayGrams = double.Parse(Console.ReadLine());

double neededFoodDog = numberDays * foodForDogForADayKG;
double neededFoodCat = numberDays * foodForCatForADayKG;
double neededFoodTurtle = (numberDays * foodForTurtleForADayGrams)/1000;
double sum = neededFoodDog + neededFoodCat + neededFoodTurtle;
if (sum<=leftFoodKG)
{
    double result = Math.Floor(leftFoodKG - sum);
    Console.WriteLine($"{result} kilos of food left.");
}
else
{
    double result = Math.Ceiling(sum-leftFoodKG);
    Console.WriteLine($"{result} more kilos of food are needed.");
}
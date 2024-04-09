string nameOfSeries = Console.ReadLine();
int episosdeDuration = int.Parse(Console.ReadLine());
int breakDuration = int.Parse(Console.ReadLine());  //Времето за обяд ще бъде 1/8 от времето за почивка, а времето за отдих ще бъде 1/4 от времето за почивка. 
double lunchBreakDuration = breakDuration * 0.125;
double restDuration = breakDuration * 0.25;
double timeAvailable = breakDuration - lunchBreakDuration - restDuration;

if (timeAvailable >= episosdeDuration)
{
    double result = Math.Ceiling(timeAvailable - episosdeDuration);
    Console.WriteLine($"You have enough time to watch {nameOfSeries} and left with {result} minutes free time."
);

}
else
{
    double result = Math.Ceiling(episosdeDuration - timeAvailable);
    Console.WriteLine($"You don't have enough time to watch {nameOfSeries}, you need {result} more minutes.");

}
double recordInSec = double.Parse(Console.ReadLine());
double distanceInMeters = double.Parse(Console.ReadLine());
double timeInSecFor1Meter = double.Parse(Console.ReadLine());
double mustClimb = distanceInMeters *  timeInSecFor1Meter;
double additional = Math.Floor(distanceInMeters / 50) * 30;
double timeSum = mustClimb + additional;
if (recordInSec<=timeSum)
{
    double result = timeSum - recordInSec;
    Console.WriteLine($"No! He was {result:f2} seconds slower.");
}
else
{
   
    Console.WriteLine($"Yes! The new record is {timeSum:f2} seconds.");
}
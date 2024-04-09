double recordInSeconds = double.Parse(Console.ReadLine());
double distanceInMeters = double.Parse(Console.ReadLine());
double timeInSecondsForOneMetresDistance = double.Parse(Console.ReadLine());
// пресмятаме колко ще е рекорда на Иван
double recordForIvanInSec = distanceInMeters * timeInSecondsForOneMetresDistance;
// пресмятаме забавянето
double delay = Math.Floor(distanceInMeters / 15);
// смятаме колко ще е крайното време
double allTime = recordForIvanInSec + delay * 12.50;
//проверяваме дали неговото време е по-малко или не от рекорда и принтираме резултата
if (allTime < recordInSeconds)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {allTime:f2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {allTime - recordInSeconds:f2} seconds slower.");
}
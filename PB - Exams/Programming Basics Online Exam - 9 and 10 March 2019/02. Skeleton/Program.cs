int controlMin = int.Parse(Console.ReadLine()); 
int controlSec  = int.Parse(Console.ReadLine());
double lenghtGutteringMeters = double.Parse(Console.ReadLine()); 
int secondsFor100Meters = int.Parse(Console.ReadLine());
double secondsSlower = 0;
controlSec = controlMin * 60 + controlSec;
double lessTime = lenghtGutteringMeters / 120;
double lessTImeSum = lessTime * 2.5;
double marinTimeSum = (lenghtGutteringMeters / 100) * secondsFor100Meters - lessTImeSum;
double controlTime = controlSec;
if (marinTimeSum <= controlTime)
{
    Console.WriteLine($"Marin Bangiev won an Olympic quota!");
    Console.WriteLine($"His time is {marinTimeSum:f3}.");
}
else
{
    secondsSlower = marinTimeSum - controlTime;
    Console.WriteLine($"No, Marin failed! He was {secondsSlower:f3} second slower.");
}



    



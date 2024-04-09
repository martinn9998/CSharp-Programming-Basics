int numberOfDays = int.Parse(Console.ReadLine());   
double ammountOfFood = double.Parse(Console.ReadLine());
double eatenByDog = 0;
double dogDayAmmount = 0;
double catDayAmmount = 0;
double eatenByCat = 0;
double cookie = 0;
for (int i = 1; i <= numberOfDays; i++)
{
    dogDayAmmount = double.Parse(Console.ReadLine());
    eatenByDog += dogDayAmmount;
    catDayAmmount = double.Parse(Console.ReadLine());
    eatenByCat += catDayAmmount;
    if (i % 3 == 0)
    {
        cookie += (dogDayAmmount + catDayAmmount) * 0.10;
    }
}
cookie = Math.Round(cookie, 0);
double eatenSum = eatenByDog + eatenByCat;
double percentEatenFood = (eatenSum / ammountOfFood) * 100;
double percentEatenFromDog = (eatenByDog / eatenSum) * 100;
double percentEatenFromCat = (eatenByCat / eatenSum) * 100;
Console.WriteLine($"Total eaten biscuits: {cookie}gr.");
Console.WriteLine($"{percentEatenFood:F2}% of the food has been eaten.");
Console.WriteLine($"{percentEatenFromDog:F2}% eaten from the dog.");
Console.WriteLine($"{percentEatenFromCat:F2}% eaten from the cat.");
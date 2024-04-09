int dayNumber = int.Parse(Console.ReadLine());
double amountFood  = double.Parse(Console.ReadLine());  //
int foodEatenByTheDog = 0;
double sumDogFood = 0;
double sumCatFood = 0;
double thirdDayCookie = 0;
int foodEatenByTheCat = 0;
int i = 0;
double percentEatenFood = 0;
double percentEatenByTheDog = 0;
double percentEatenByTheCat = 0;

for (i = 0; i < dayNumber; i++)
{
    foodEatenByTheDog = int.Parse(Console.ReadLine());
    sumDogFood += foodEatenByTheDog;
    foodEatenByTheCat = int.Parse(Console.ReadLine());
    sumCatFood += foodEatenByTheCat;
    if (i == 3)
    {
        thirdDayCookie = (foodEatenByTheCat + foodEatenByTheDog) * 1.10;
        thirdDayCookie = thirdDayCookie - (foodEatenByTheCat + foodEatenByTheDog);
    }
}
if (i == 3)
{
    thirdDayCookie = (foodEatenByTheCat + foodEatenByTheDog) * 1.10;
    thirdDayCookie = thirdDayCookie - (foodEatenByTheCat + foodEatenByTheDog);
}
//На всеки трети ден получават награда - бисквитки.
//Количеството на бисквитките е 10% от общо изядената храна за деня.
Console.WriteLine($"Total eaten biscuits: {Math.Round(thirdDayCookie, 0)}gr.");
percentEatenFood = (sumCatFood + sumDogFood) / amountFood * 100;
Console.WriteLine($"{percentEatenFood:f2}% of the food has been eaten.");
percentEatenByTheDog = sumDogFood / (sumCatFood + sumDogFood) * 100; 
Console.WriteLine($"{percentEatenByTheDog:f2}% eaten from the dog.");
percentEatenByTheCat = sumCatFood / (sumCatFood + sumDogFood) * 100;
Console.WriteLine($"{percentEatenByTheCat:f2}% eaten from the cat.");
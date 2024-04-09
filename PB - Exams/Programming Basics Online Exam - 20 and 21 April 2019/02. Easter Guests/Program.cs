//Ако покани:
//•	Между 10 (вкл.) и 15 (вкл.) човека -> 15 % отстъпка от куверта за един човек
//•	Между 15 и 20 (вкл.) човека -> 20 % отстъпка от куверта за един човек
//•	Над 20 човека -> 25 % отстъпка от куверта за един човек
double invited = 0;
double priceFor1Person = 0;
double priceForCake = 0;
double priceSum = 0;
double budget = 0;
invited =  double.Parse(Console.ReadLine());
priceFor1Person = double.Parse(Console.ReadLine());
budget = double.Parse(Console.ReadLine());
if (invited >= 1 && invited < 10)
{
    priceFor1Person = priceFor1Person;
}
else if (invited >= 10 && invited <= 15)
{
    priceFor1Person = priceFor1Person * 0.85;
}
else if (invited > 15 && invited <= 20)
{
    priceFor1Person = priceFor1Person * 0.80;
}
else if (invited>20)
{
    priceFor1Person = priceFor1Person * 0.75;
}

priceSum = invited * priceFor1Person;
priceForCake = budget * 0.10; // cake
priceSum += priceForCake;

if (budget >= priceSum)
{
    double reaminingMoney = budget - priceSum;
    Console.WriteLine($"It is party time! {reaminingMoney:f2} leva left.");
}
else if (priceSum>budget)
{
    double neededMoney = priceSum - budget;
    Console.WriteLine($"No party! {neededMoney:f2} leva needed.");
}    
double priceOfParty = double.Parse(Console.ReadLine());  
int numberLoveLMessages = int.Parse(Console.ReadLine());   //0.60
int numberRoses = int.Parse(Console.ReadLine());   //7.20
int numberKeyholders = int.Parse(Console.ReadLine());  //3.60
int numberCaricatures = int.Parse(Console.ReadLine());  //18.20
int numberSurpriseLuck = int.Parse(Console.ReadLine());  //22.00;

double sum = numberLoveLMessages * 0.60 +
    numberRoses * 7.20 + numberKeyholders * 3.60 +
    numberCaricatures * 18.20 + numberSurpriseLuck * 22.00;
int numberOfArticules = numberLoveLMessages + numberRoses +
    numberKeyholders + numberCaricatures + numberSurpriseLuck;
double discount = 0;
if (numberOfArticules>25)
{
    discount = sum * 0.35;
}


double finalprice = sum - discount;

double expenceHosting = finalprice * 0.1;

double gainMoney = finalprice - expenceHosting;

if (gainMoney>=priceOfParty)
{
    double calculation = gainMoney - priceOfParty;
    Console.WriteLine($"Yes! {calculation:f2} lv left.");
}
else
{
    double calculation = priceOfParty - gainMoney;
    Console.WriteLine($"Not enough money! {calculation:f2} lv needed.");
}
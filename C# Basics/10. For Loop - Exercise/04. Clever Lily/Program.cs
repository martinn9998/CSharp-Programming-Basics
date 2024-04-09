int ageOfLily = int.Parse(Console.ReadLine());
double priceWashingMachine = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());
int numberOfToys = 0;
int savedMoney = 0;
int moneyForBirthday = 10;
for (int currentYear = 1; currentYear <= ageOfLily; currentYear++)
{
    if (currentYear % 2 == 0)
    {
        savedMoney += (moneyForBirthday - 1);
        moneyForBirthday += 10;
    }
    else
    {
        numberOfToys++;
    }
}
savedMoney += numberOfToys * toyPrice;
Console.WriteLine(savedMoney >= priceWashingMachine ?
    $"Yes! {(savedMoney - priceWashingMachine):0.00}" :
    $"No! {(priceWashingMachine - savedMoney):0.00}");
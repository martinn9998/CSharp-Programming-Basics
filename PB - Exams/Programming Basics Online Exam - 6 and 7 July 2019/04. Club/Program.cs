double wantedIncome = double.Parse(Console.ReadLine());
string nameCocktail = "";
int quantity = 0;
double sumIncome = 0;
int priceCocktail = 0;
double priceCalculation = 0;
while (sumIncome<wantedIncome)
{
   nameCocktail = Console.ReadLine();
   if (nameCocktail == "Party!")
    {
        if (wantedIncome <= sumIncome)
        {
            Console.WriteLine("Target acquired.");
            break;
        }
        else
        {
         double result = wantedIncome - sumIncome;
         Console.WriteLine($"We need {result:f2} leva more.");
         break;          
        }
    }
   quantity = int.Parse(Console.ReadLine());
   priceCocktail = nameCocktail.Length;
   priceCalculation = quantity * priceCocktail;
   if (priceCalculation%2==1)
   {
   priceCalculation = priceCalculation * 0.75;
   }
   sumIncome+=priceCalculation;
}
if (wantedIncome <= sumIncome)
{
    Console.WriteLine("Target acquired.");
    
}
Console.WriteLine($"Club income - {sumIncome:f2} leva.");
double annualTax = double.Parse(Console.ReadLine());
double shoesPrice = annualTax - (annualTax * 0.4);
double equipment = shoesPrice - (shoesPrice * 0.2);
double basketballBall = equipment * 0.25;
double accessories = basketballBall * 0.2;
double allExpeces = annualTax + shoesPrice + equipment + basketballBall + accessories;
Console.WriteLine(allExpeces);
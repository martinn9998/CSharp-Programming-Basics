double annualTax = double.Parse(Console.ReadLine());
double shoesBasketball = 0;
double equipment = 0;
double ballBasketball = 0;
double accessories = 0;
double allSum = 0;
shoesBasketball = annualTax * 0.6;
equipment = shoesBasketball * 0.8;
ballBasketball = equipment * 0.25;
accessories = ballBasketball * (1.0 / 5);
allSum = annualTax + shoesBasketball + equipment +ballBasketball + accessories;
Console.WriteLine($"{allSum:f2}");



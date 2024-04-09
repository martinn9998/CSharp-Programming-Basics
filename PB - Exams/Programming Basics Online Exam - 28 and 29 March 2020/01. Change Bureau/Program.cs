int bitcointsAvailable = int.Parse(Console.ReadLine()); // 1168 leva
double chineseUanaAvailable  = double.Parse(Console.ReadLine()); // 0.15 dollars / 1 dollar = 1.76 leva;
double commision = double.Parse(Console.ReadLine());
double bitcoinsToLeva = bitcointsAvailable * 1168;
double unaToDollars = chineseUanaAvailable * 0.15;
double dollarsToLeva = unaToDollars * 1.76;
double sumLeva = bitcoinsToLeva + dollarsToLeva;
double levaToEuro = sumLeva / 1.95;  //1 euro = 1.95 leva.

double result = levaToEuro * ((100 - commision)/100);
Console.WriteLine($"{result:f2}");
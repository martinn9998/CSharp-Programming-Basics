﻿double nylonQuantity = double.Parse(Console.ReadLine());
double paintingQuantity = double.Parse(Console.ReadLine());
double paintThinnerQuantity = double.Parse(Console.ReadLine());
int labourHours = int.Parse(Console.ReadLine());
double nylonProtection = (nylonQuantity + 2) * 1.50;
double painting = (paintingQuantity + (paintingQuantity * 0.1)) * 14.50;
double paintThinner = paintThinnerQuantity * 5.00;
double bags = 0.40;
double allMaterialsExpence = nylonProtection + painting + paintThinner + bags;
double labourExpence = labourHours * (allMaterialsExpence * 0.3);
double allExpeces = allMaterialsExpence + labourExpence;
Console.WriteLine(allExpeces);
﻿double h = double.Parse(Console.ReadLine());
double w = double.Parse(Console.ReadLine());
double wCm = w * 100;
double hCm = h * 100;
double wWithoutCorridor = wCm - 100;
double wDesks = Math.Floor(wWithoutCorridor  / 70);
double remainingW = wWithoutCorridor % 70;
double hDesks = Math.Floor(hCm / 120);
double remainingH = hCm % 120;
double result = (wDesks * hDesks) - 3;
Console.WriteLine($"{Math.Floor(result)}");
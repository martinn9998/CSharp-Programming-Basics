﻿double priceOfFlour1KG = double.Parse(Console.ReadLine());
double ammountKGsOfFlour = double.Parse(Console.ReadLine());
double ammountKGOfSugar = double.Parse(Console.ReadLine());
double numberOfPeelEggs = double.Parse(Console.ReadLine());
double packetsYeast = double.Parse(Console.ReadLine());
double priceOfSugar1KG = priceOfFlour1KG * 0.75;
double priceOf1PeelEgg = priceOfFlour1KG * 1.10;
double priceOf1PacketYeast = priceOfSugar1KG * 0.20;
double priceOfFlour = priceOfFlour1KG * ammountKGsOfFlour;
double priceOfSugar = priceOfSugar1KG * ammountKGOfSugar;
double priceOfEggs = priceOf1PeelEgg * numberOfPeelEggs;
double priceOfYeast = priceOf1PacketYeast * packetsYeast;
double priceSum = priceOfFlour + priceOfSugar + priceOfEggs + priceOfYeast;
Console.WriteLine($"{priceSum:f2}");
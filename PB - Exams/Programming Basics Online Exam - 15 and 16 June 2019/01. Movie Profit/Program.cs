﻿string movieName = Console.ReadLine();
double daysNumber = double.Parse(Console.ReadLine());
double ticketsNumber = double.Parse(Console.ReadLine());
double priceTicket = double.Parse(Console.ReadLine());
double percentForCinema = double.Parse(Console.ReadLine());
double priceTicketsForADay = 0;
double wholeTimeIncome = 0;
double calculationPercent = 0;
double incomeFromeTheMovie = 0;
priceTicketsForADay = ticketsNumber *  priceTicket;
wholeTimeIncome = daysNumber * priceTicketsForADay;
calculationPercent = wholeTimeIncome * (percentForCinema / 100);
incomeFromeTheMovie = wholeTimeIncome - calculationPercent;
Console.WriteLine($"The profit from the movie {movieName} is {incomeFromeTheMovie:f2} lv.");

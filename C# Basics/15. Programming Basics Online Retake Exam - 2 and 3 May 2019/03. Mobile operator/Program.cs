int dayFilmingCost = 0;
double budgetMovie = double.Parse(Console.ReadLine());
string destination = Console.ReadLine();
string season = Console.ReadLine();
int days  = int.Parse(Console.ReadLine());
double calculationCost = 0;
//Дестинация
//Сезон	     Dubai	        Sofia	    London
//Winter	45 000 lv.	17 000 lv.	24 000 lv.
//Summer	40 000 lv.	12 500 lv.	20 250 lv.
//•	Ако дестинацията е Дубай – 30% отстъпка от крайната цена
//•	Ако дестинацията е София – цената се оскъпява с 25%


if (season == "Winter" && destination == "Dubai")
{
    dayFilmingCost = 45000;
    calculationCost = days * dayFilmingCost;
    calculationCost = calculationCost * 0.7;
    if (calculationCost > budgetMovie)
    {
        Console.WriteLine($"The director needs {calculationCost - budgetMovie:f2} leva more!");
    }
    else
    {
        Console.WriteLine($"The budget for the movie is enough! We have {budgetMovie - calculationCost:f2} leva left!");
    }
}
else if (season == "Summer" && destination == "Dubai")
{
    dayFilmingCost = 40000;
    calculationCost = days * dayFilmingCost;
    calculationCost = calculationCost * 0.7;
    if (calculationCost > budgetMovie)
    {
        Console.WriteLine($"The director needs {calculationCost - budgetMovie:f2} leva more!");
    }
    else
    {
        Console.WriteLine($"The budget for the movie is enough! We have {budgetMovie - calculationCost:f2} leva left!");
    }
}
else if (season == "Winter" && destination == "Sofia")
{
    dayFilmingCost = 17000;
    calculationCost = days * dayFilmingCost;
    calculationCost = calculationCost * 1.25;
    if (calculationCost > budgetMovie)
    {
        Console.WriteLine($"The director needs {calculationCost - budgetMovie:f2} leva more!");
    }
    else
    {
        Console.WriteLine($"The budget for the movie is enough! We have {budgetMovie-calculationCost:f2} leva left!");
    }

}
else if (season == "Summer" && destination == "Sofia")
{
    dayFilmingCost = 12500;
    calculationCost = days * dayFilmingCost;
    calculationCost = calculationCost * 1.25;
    if (calculationCost > budgetMovie)
    {
        Console.WriteLine($"The director needs {calculationCost - budgetMovie:f2} leva more!");
    }
    else
    {
        Console.WriteLine($"The budget for the movie is enough! We have {budgetMovie - calculationCost:f2} leva left!");
    }
}
else if (season == "Winter" && destination == "London")
{
    dayFilmingCost = 24000;
    calculationCost = days * dayFilmingCost;
    if (calculationCost > budgetMovie)
    {
        Console.WriteLine($"The director needs {calculationCost - budgetMovie:f2} leva more!");
    }
    else
    {
        Console.WriteLine($"The budget for the movie is enough! We have {budgetMovie - calculationCost:f2} leva left!");
    }
}
else if (season == "Summer" && destination == "London")
{
    dayFilmingCost = 20250;
    calculationCost = days * dayFilmingCost;
    if (calculationCost > budgetMovie)
    {
        Console.WriteLine($"The director needs {calculationCost - budgetMovie:f2} leva more!");
    }
    else
    {
        Console.WriteLine($"The budget for the movie is enough! We have {budgetMovie - calculationCost:f2} leva left!");
    }
}



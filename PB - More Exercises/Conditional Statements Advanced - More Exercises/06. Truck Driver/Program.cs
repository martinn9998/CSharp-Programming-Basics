string season = Console.ReadLine();
double kmMonthly = double.Parse(Console.ReadLine());

//                           Spring / Autumn     Summer         Winter
//kmMonthly <= 5000      	   0.75 лв./км	    0.90 лв./км  	1.05 лв./км
//5000 < kmMonthly <= 10000    0.95 лв./км   	1.10 лв./км 	1.25 лв./км
//10000 < kmMonthly <= 20000   1.45 лв./км – за който и да е сезон
double price = 0;
if (kmMonthly > 10000 && kmMonthly <= 20000)
{
    switch(season)
    {
        case "Spring":
        case "Autumn":
            price = 1.45;
            break;
        case "Summer":
            price = 1.45;
            break;
        case "Winter":
            price = 1.45;
            break;
    }
}
else if (kmMonthly > 5000 && kmMonthly <= 10000)
{
    switch (season)
    {
        case "Spring":
        case "Autumn":
            price = 0.95;
            break;
        case "Summer":
            price = 1.10;
            break;
        case "Winter":
            price = 1.25;
            break;
    }
}
else if (kmMonthly >= 1 && kmMonthly <= 5000)
{
    switch (season)
    {
        case "Spring":
        case "Autumn":
            price = 0.75;
            break;
        case "Summer":
            price = 0.90;
            break;
        case "Winter":
            price = 1.05;
            break;
    }
}
double finalPrice = (kmMonthly * price) * 4;
finalPrice *= 0.90;
Console.WriteLine($"{finalPrice:f2}");
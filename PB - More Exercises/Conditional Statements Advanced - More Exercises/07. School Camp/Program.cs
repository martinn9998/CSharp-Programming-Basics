string season = Console.ReadLine();
string groupType = Console.ReadLine();
int numberOfStudents = int.Parse(Console.ReadLine());
int numberOFNightStays = int.Parse(Console.ReadLine());

//               Winter vacation	Spring vacation	  Summer vacation
//boys/girls	            9.60	   7.20          	15
//mixed                   	10	        9.50	        20
double price = 0;
if (season == "Winter")
{
    if (groupType == "boys" || groupType == "girls")
    {
        price = 9.60;
    }
    else if (groupType == "mixed")
    {
        price = 10;
    }
}
else if (season == "Spring")
{
    if (groupType == "boys" || groupType == "girls")
    {
        price = 7.20;
    }
    else if (groupType == "mixed")
    {
        price = 9.50;
    }
}
else if (season == "Summer")
{
    if (groupType == "boys" || groupType == "girls")
    {
        price = 15;
    }
    else if (groupType == "mixed")
    {
        price = 20;
    }
}

//                   Winter vacation	Spring vacation  	Summer vacation
//girls              	Gymnastics       	Athletics	     Volleyball
//boys	                    Judo	          Tennis	      Football
//mixed                 	Ski	             Cycling	      Swimming
string sport = "";
if (season == "Winter")
{
    if (groupType == "boys")
    {
        sport = "Judo";
    }
    else if (groupType == "girls")
    {
        sport = "Gymnastics";
    }
    else if (groupType == "mixed")
    {
        sport = "Ski";
    }
}
else if (season == "Spring")
{
    if (groupType == "boys")
    {
        sport = "Tennis";
    }
    else if (groupType == "girls")
    {
        sport = "Athletics";
    }
    else if (groupType == "mixed")
    {
        sport = "Cycling";
    }
}
else if (season == "Summer")
{
    if (groupType == "boys")
    {
        sport = "Football";
    }
    else if (groupType == "girls")
    {
        sport = "Volleyball";
    }
    else if (groupType == "mixed")
    {
        sport = "Swimming";
    }
}

double finalPrice = numberOfStudents * numberOFNightStays * price;

if (numberOfStudents >= 50)
{
    finalPrice *= 0.50;
}
else if (numberOfStudents >= 20 && numberOfStudents < 50)
{
    finalPrice *= 0.85;
}
else if (numberOfStudents >= 10 && numberOfStudents < 20)
{
    finalPrice *= 0.95;
}
Console.WriteLine($"{sport} {finalPrice:f2} lv.");
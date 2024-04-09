int number = int.Parse(Console.ReadLine());
int startinPoints = int.Parse(Console.ReadLine());
int points = startinPoints;
string typeCompetition = "";
int win = 0;
for (int i = 0; i < number; i++)
{
    typeCompetition = Console.ReadLine();
    if (typeCompetition=="F")
    {
        points += 1200;
        
    }
    if (typeCompetition == "SF")
    {
        points += 720;
    }
    if (typeCompetition == "W")
    {
        points += 2000;
        win++;
    }
}

double calc = points - startinPoints;
double average1 = calc/number;
double number1 = number;
double win1 = win;
double percentWonCompetitions = (win1/ number1) * 100;

Console.WriteLine($"Final points: {points}");
Console.WriteLine($"Average points: {Math.Floor(average1)}");
Console.WriteLine($"{percentWonCompetitions:f2}%");
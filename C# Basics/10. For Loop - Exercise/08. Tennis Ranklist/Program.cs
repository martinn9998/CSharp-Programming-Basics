int numberCompetitions = int.Parse(Console.ReadLine());
int pointsBegging = int.Parse(Console.ReadLine());
string competitionStage = "";
int points = pointsBegging;
int cpt1 = 0;
int cpt2 = 0;
int cpt3 = 0;
int winner = 0;
int final = 0;
int semifinal = 0;
for (int i = 0; i < numberCompetitions; i++)
{
    competitionStage = Console.ReadLine();
    if (competitionStage == "W")
    {
        cpt1++;
        winner = 2000;
        points += winner;
    }
    else if (competitionStage == "F")
    {
        cpt2++;
        final = 1200;
        points += final;

    }
    if (competitionStage == "SF")
    {
        cpt3++;
        semifinal = 720;
        points += semifinal;
    }
}
double averagePoints = points - pointsBegging;
double averagePoints2 = averagePoints / numberCompetitions;
double numberCompetitions1 = numberCompetitions;
double cpt11 = cpt1;
double percentWonCompetitions = cpt11 / numberCompetitions1;
double percentWonCompetitions2 = percentWonCompetitions * 100;

Console.WriteLine($"Final points: {points}");
Console.WriteLine($"Average points: {Math.Floor(averagePoints2)}");
Console.WriteLine($"{percentWonCompetitions2:f2}%");
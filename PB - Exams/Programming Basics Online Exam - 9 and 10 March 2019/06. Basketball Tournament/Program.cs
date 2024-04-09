
int pointsTeam = 0;
int pointsOpposingTeam = 0;
int game = 0;
int countCompetitions = 0;
double sumPointsTeam = 0;
double sumPointsOpposingTeam = 0;
int teamWinTime = 0;
int teamOpposingWinTime = 0;
int calc = 0;
while (true)
{
    countCompetitions = 0;
    string nameCompetition = Console.ReadLine();
    if (nameCompetition == "End of tournaments")
    {
        double teamWinTime1 = teamWinTime;
        double game1 = game;
        double teamOpposingWinTime1 = teamOpposingWinTime;
        double percentCalculationTeam = (teamWinTime1 / game1) * 100;
        double percentCalculationTeamLost = (teamOpposingWinTime1 / game1) * 100;
        Console.WriteLine($"{percentCalculationTeam:f2}% matches win");
        Console.WriteLine($"{percentCalculationTeamLost:f2}% matches lost");
        break;
    }
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        pointsTeam = int.Parse(Console.ReadLine());
        pointsOpposingTeam = int.Parse(Console.ReadLine());
        if (pointsTeam > pointsOpposingTeam)
        {
            countCompetitions++;
            game++;
            calc = pointsTeam - pointsOpposingTeam;
            sumPointsOpposingTeam += pointsTeam;
            teamWinTime++;
            Console.WriteLine($"Game {countCompetitions} of tournament {nameCompetition}: win with {calc} points.");
        }
        else if (pointsTeam < pointsOpposingTeam)
        {
            countCompetitions++;
            game++;
            calc= pointsOpposingTeam - pointsTeam;
            sumPointsOpposingTeam -= sumPointsOpposingTeam;
                teamOpposingWinTime++;
            Console.WriteLine($"Game {countCompetitions} of tournament {nameCompetition}: lost with {calc} points.");
        }
    }
}
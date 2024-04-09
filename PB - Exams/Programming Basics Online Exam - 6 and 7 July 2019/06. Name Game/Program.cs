using System.Reflection;

string namePlayer = "";
int n = 0;
int number = 0;
int points = 0;
int i = 0;
int pointsPlayer1 = 0;
int pointsPlayer2 = 0;
string namePlayer1 = "";
string namePlayer2 = "";
//int playerCount = 0;

int maxPoints = int.MinValue;
string bestPlayer = "";

while (true)
{
    namePlayer = Console.ReadLine();

    if (namePlayer == "Stop")
    {

        break;
    }
    n = namePlayer.Length;
    for (i = 0; i < n; i++)
    {
        number = int.Parse(Console.ReadLine());
        if (number == namePlayer[i])
        {
            points += 10;
        }
        else
        {
            points += 2;
        }
    }
    //playerCount++;

    if (points >= maxPoints)
    {
        maxPoints = points;
        bestPlayer = namePlayer;
    }
    points = 0;

    //if (playerCount == 1)
    //{
    //    namePlayer1 = namePlayer;
    //    pointsPlayer1 = points;
    //    points = 0;
    //    i = 0;
    //}
    //else if (playerCount == 2)
    //{
    //    namePlayer2 = namePlayer;
    //    pointsPlayer2 = points;
    //    points = 0;
    //    i = 0;
    //}


}
Console.WriteLine($"The winner is {bestPlayer} with {maxPoints} points!");
//if (pointsPlayer1 > pointsPlayer2)
//{
//    Console.WriteLine($"The winner is {namePlayer1} with {pointsPlayer1} points!");
//}
//else if (pointsPlayer1 <= pointsPlayer2)
//{
//    Console.WriteLine($"The winner is {namePlayer2} with {pointsPlayer2} points!");
//}
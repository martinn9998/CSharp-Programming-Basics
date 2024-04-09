string name = Console.ReadLine();
int meetings = int.Parse(Console.ReadLine());
int i = 0;
int points = 0;
double pointsSum = 0; 
int wonGames = 0;
int evenGames = 0;
int lostGames = 0;
int games = 0;
string input = "";
double percentWonGames = 0;
bool hasntPlayed = true;
if (meetings==0)
{
 Console.WriteLine($"{name} hasn't played any games during this season.");
    hasntPlayed = false;
}
while (i<meetings)
{
  input = Console.ReadLine();
  if (input == "W")
  {
   points = 3; 
   pointsSum += points; 
   wonGames++;
   games++;
  }
  else if (input == "D")
  {
   points = 1;
   pointsSum += points; 
   evenGames++;
   games++;
  }
  else 
  {
   lostGames++;
   games++;
  }
  i++;
}
if (hasntPlayed)
{
    double wonGames0 = wonGames;
    double games0 = games;
    percentWonGames = (wonGames0 / games0) * 100;
    Console.WriteLine($"{name} has won {pointsSum} points during this season.");
    Console.WriteLine($"Total stats:");
    Console.WriteLine($"## W: {wonGames}");
    Console.WriteLine($"## D: {evenGames}");
    Console.WriteLine($"## L: {lostGames}");
    Console.WriteLine($"Win rate: {percentWonGames:f2}%");
}
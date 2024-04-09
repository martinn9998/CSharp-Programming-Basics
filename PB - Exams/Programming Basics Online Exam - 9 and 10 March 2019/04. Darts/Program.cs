double totalPoints = 301;
string field = "";
int successfulShots = 0;
int unsuccessfulShots = 0;
int points = 0;
string namePlayer = Console.ReadLine();
for (; true;)
{
    field = Console.ReadLine();
    if (field == "Retire")
    {
        Console.WriteLine($"{namePlayer} retired after {unsuccessfulShots} unsuccessful shots.");
        break;
    }
    points = int.Parse(Console.ReadLine());


    
 if (field == "Single")
  {
       
        if (points > totalPoints)
        {
            unsuccessfulShots++;
            continue;
        }
        else
        {
            totalPoints -= points;
            successfulShots++;
        }
  }
  else if (field == "Double")
  {
      points = points * 2;
        if (points > totalPoints)
        {
            unsuccessfulShots++;
            continue;
        }
        else
        {
            totalPoints -= points;
            successfulShots++;
        }
    }
  else if (field == "Triple")
  {
      points = points * 3;
        if (points > totalPoints)
        {
            unsuccessfulShots++;
            continue;
        }
        else
        {
            totalPoints -= points;
            successfulShots++;
        }

    }
    





    if (totalPoints <= 0)
    {
        Console.WriteLine($"{namePlayer} won the leg with {successfulShots} shots.");
        break;
    }
}
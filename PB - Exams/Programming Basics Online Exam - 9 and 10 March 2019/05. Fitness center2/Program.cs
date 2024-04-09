int number = int.Parse(Console.ReadLine());
int back = 0;
int chest = 0;
int legs = 0;
int abs = 0;
int proteinShake = 0;
int proteinBar = 0;
int workOut = 0;
int protein = 0;
double percentWorkOut = 0;
double percentProtein = 0;

for (int i = 0; i < number; i++)
{
    string text = Console.ReadLine();
    if (text == "Back")
    {
        back++;
        workOut++;
    }
    else if (text == "Chest")
    {
        chest++;
        workOut++;
    }
    else if (text == "Legs")
    {
        legs++;
        workOut++;
    }
    else if (text == "Abs")
    {
        abs++;
        workOut++;
    }
    else if (text == "Protein shake")
    {
        proteinShake++;
        protein++;
    }
    else if (text == "Protein bar")
    {
        proteinBar++;
        protein++;
    }

}

double number1 = number;
double workOut1 = workOut;
double protein1 = protein;

percentWorkOut = (workOut1 / number1) * 100;
percentProtein = (protein1 / number1) * 100;
Console.WriteLine($"{back} - back");
Console.WriteLine($"{chest} - chest");
Console.WriteLine($"{legs} - legs");
Console.WriteLine($"{abs} - abs");
Console.WriteLine($"{proteinShake} - protein shake");
Console.WriteLine($"{proteinBar} - protein bar");
Console.WriteLine($"{percentWorkOut:f2}% - work out");
Console.WriteLine($"{percentProtein:f2}% - protein");

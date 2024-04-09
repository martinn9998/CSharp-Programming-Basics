int numberGames = int.Parse(Console.ReadLine());
int i = 0;
string name = "";
int hearthstone = 0;
int fornite = 0;
int overwatch = 0;
int others = 0;
int games = 0;
double percentHearthstone = 0;
double percentFornite = 0;
double percentOverwatch = 0;
double percentOthers = 0;
while (i<numberGames)
{
   name = Console.ReadLine();
   if (name == "Hearthstone")
   {
       hearthstone++;
        games++;
   }
   else if (name == "Fornite")
   {
       fornite++;
        games++;
   }
   else if (name == "Overwatch")
   {
       overwatch++;
        games++;
   }
   else 
   {
        others++;
        games++;
   }
   i++;
}
double games0 = games;
double hearthstone0 = hearthstone;
double fornite0 = fornite;
double overwatch0 = overwatch;
double others0 = others;
percentHearthstone = (hearthstone0 / games0) * 100;
percentFornite = (fornite0 / games0) * 100;
percentOverwatch = (overwatch0 / games0) * 100;
percentOthers = (others0 / games0) * 100;
Console.WriteLine($"Hearthstone - {percentHearthstone:f2}%");
Console.WriteLine($"Fornite - {percentFornite:f2}%");
Console.WriteLine($"Overwatch - {percentOverwatch:f2}%");
Console.WriteLine($"Others - {percentOthers:f2}%");


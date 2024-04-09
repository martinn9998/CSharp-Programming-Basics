string movieName = "";
double points = 0;
int symbolNumber = 0;
int maxNumber0 = int.MinValue;
double maxNumber = maxNumber0;
string movieMaxPoints = string.Empty;
char symbol = ' ';
char symbolSpace = ',';

bool break1 = false;

for (int i = 0; i < 7; i++)
{
  
    movieName =  Console.ReadLine();
    if (movieName =="STOP")
    {
        break1 = true;
        break;
    }
    for (int j = 0; j < movieName.Length;j++ )
    {
        symbol = movieName[j];
        if (symbol==' ')
        {
            symbolNumber = 32;
            points += symbolNumber;

        }
        else if (char.IsUpper(symbol))
        {
            symbolNumber = movieName[j];
            points -= movieName.Length;
            points += symbolNumber;
        }
        else if (char.IsLower(symbol)) 
        {
            symbolNumber = movieName[j];
            points -= movieName.Length;
            points -= movieName.Length;
            points += symbolNumber;
        }
        else if (char.IsDigit(symbol))
        {
            symbolNumber = movieName[j];
            points += symbolNumber;
        }
                                       
    }
    if ( points > maxNumber )
    {
        movieMaxPoints = movieName;
        maxNumber = points;
    }
    points = 0;

}
if (break1)
{
    Console.WriteLine($"The best movie for you is {movieMaxPoints} with {maxNumber} ASCII sum.");
}
else
{
    Console.WriteLine($"The limit is reached.");
    Console.WriteLine($"The best movie for you is {movieMaxPoints} with {maxNumber} ASCII sum.");
}
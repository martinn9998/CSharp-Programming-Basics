int n = int.Parse(Console.ReadLine());
string possibleSellsString = string.Empty;
double madeSells = 0;
double calculationRating = 0;
double ratingSum = 0, ratingCount = 0;

for (int i = 1; i <= n; i++)
{
    string number  = Console.ReadLine();
    char numberChar = ' ';
    int possibleSells = 0;
    for (int j = 0; j <= 2; j++)
    {
        numberChar = (char)number[j];
        
        if (j == 0)
        {
            possibleSellsString += numberChar;
            continue;
        }
        if (j == 1)
        {
            possibleSellsString += numberChar;
            possibleSells = int.Parse(possibleSellsString);
            possibleSellsString = string.Empty;
        }

        if (j==2)
        {
            int rating = numberChar - '0';
            ratingSum += rating;
            ratingCount++;
            if (rating>=2 && rating<=6)
            {
                calculationRating = possibleSells;
                if (rating==2)
                {
                    calculationRating *= 0;
                }
                else if (rating == 3)
                {
                    calculationRating *= 0.50;
                }
                else if (rating == 4)
                {
                    calculationRating *= 0.70;
                }
                else if (rating == 5)
                {
                    calculationRating *= 0.85;
                }
                else if (rating == 6)
                {
                    calculationRating *= 1;
                }
            }
            calculationRating = Math.Round(calculationRating, 0);
            madeSells += calculationRating;
            calculationRating = 0;
            possibleSells = 0;
        }

    }
    

}

double averageRatingCalculation = ratingSum / ratingCount;
Console.WriteLine($"{madeSells:f2}");
Console.WriteLine($"{averageRatingCalculation:f2}");
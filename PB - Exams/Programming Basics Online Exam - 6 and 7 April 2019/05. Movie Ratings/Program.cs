int moviesNumber = int.Parse(Console.ReadLine());
string movieName = "";
double movieRating = 0;
double ratingSum = 0;
int movieCount = 0;
int maxNumber = int.MinValue;
double maxNumber1 = maxNumber;
int minNumber = int.MaxValue;
double minNumber1 = minNumber;
int i = 0;
double averageRating = 0;
string maxRatingName = "";
string minRatingName = "";
while (i < moviesNumber)
{
    movieName = Console.ReadLine();
    movieRating = double.Parse(Console.ReadLine());
    ratingSum += movieRating;
    movieCount++;
    if (movieRating > maxNumber1)
    {

        maxNumber1 = movieRating;
        maxRatingName = movieName;

    }
    else if (movieRating < minNumber1)
    {
        minNumber1 = movieRating;
        minRatingName = movieName;
    }

    i++;
}
averageRating = ratingSum / movieCount;
Console.WriteLine($"{maxRatingName} is with highest rating: {maxNumber1:f1}");
Console.WriteLine($"{minRatingName} is with lowest rating: {minNumber1:f1}");
Console.WriteLine($"Average rating: {averageRating:f1}");


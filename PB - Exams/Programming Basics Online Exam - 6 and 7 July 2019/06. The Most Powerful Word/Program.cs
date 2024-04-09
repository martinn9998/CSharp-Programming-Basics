

string word = "";
int asciiNumber = 0;
int asciiSum = 0;
int i = 0;
char firstLetter = ' ';
int wordLenght = 0;
double finalCalculation = 0;
int wordCount = 0;
string firstWordText = "";
double firstWordScore = 0;
string secondWordText = "";
double secondWordScore = 0;
string thirdWordText = "";
double thirdWordScore = 0;
string fourthWordText = "";
double fourthWordScore = 0;
string fifthWordText = "";
double fifthWordScore = 0;
string sixthWordText = "";
double sixthWordScore = 0;
string seventhWordText = "";
double seventhWordScore = 0;
string eighthWordText = "";
double eighthWordScore = 0;
string ninthWordText = "";
double ninthWordScore = 0;
string tenthWordText = "";
double tenthWordScore = 0;
double maxScore = int.MinValue;
string maxScoreText = ""; 
while (true)
{
    word = Console.ReadLine();
    if (word == "End of words")
    {
        break;
    }
    for (; i < word.Length; i++)
    {
        if (i==0)
        {
            firstLetter = word[i];
        }
        asciiNumber = word[i];
        asciiSum += asciiNumber;
        
        
    }
    i = 0;
    wordLenght = word.Length;
    if (firstLetter == 'a' || firstLetter == 'e' || firstLetter == 'i'
            || firstLetter == 'o' || firstLetter == 'u' || firstLetter == 'y' ||
              firstLetter == 'A' || firstLetter == 'E' || firstLetter == 'I'
              ||firstLetter == 'O' || firstLetter == 'U' || firstLetter == 'Y')
    {
        
        finalCalculation = asciiSum * wordLenght;

    }
    else
    {
        finalCalculation = asciiSum / wordLenght;
        finalCalculation = Math.Floor(finalCalculation);
    }

    if (finalCalculation > maxScore)
    {
        maxScore = finalCalculation;
        maxScoreText = word;

    }


    wordCount ++;
    if (wordCount == 1)
    {
        firstWordText = word;
        firstWordScore = finalCalculation;
    }
    else if (wordCount == 2)
    {
        secondWordText = word;
        secondWordScore = finalCalculation;
    }
    else if (wordCount == 3)
    {
        thirdWordText = word;
        thirdWordScore = finalCalculation;
    }
    else if (wordCount == 4)
    {
        fourthWordText = word;
        fourthWordScore = finalCalculation;
    }
    else if (wordCount == 5)
    {
        fifthWordText = word;
        fifthWordScore = finalCalculation;
    }
    else if (wordCount == 6)
    {
        sixthWordText = word;
        sixthWordScore = finalCalculation;
    }
    else if (wordCount == 7)
    {
        seventhWordText = word;
        seventhWordScore = finalCalculation;
    }
    else if (wordCount == 8)
    {
        eighthWordText = word;
        eighthWordScore = finalCalculation;
    }
    else if (wordCount == 9)
    {
        ninthWordText = word;
        ninthWordScore = finalCalculation;
    }
    else if (wordCount == 10)
    {
        ninthWordText = word;
        ninthWordScore = finalCalculation;
    }
    asciiSum = 0;
}

Console.WriteLine($"The most powerful word is {maxScoreText} - {Math.Round(maxScore, 0)}");
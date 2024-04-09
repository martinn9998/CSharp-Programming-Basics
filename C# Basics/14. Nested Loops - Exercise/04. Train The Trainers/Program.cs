int judgesNumber = int.Parse(Console.ReadLine());
double grade = 0;
double averageGrade = 0;
double gradeSum= 0;
double gradeSum2 = 0;
bool isTrue = false;
int g = 0;
int s = 0;

for (; true;) 
{
    string nameOfPresentation = Console.ReadLine();
    if (nameOfPresentation == "Finish")
    {
        averageGrade = gradeSum2 / g;
        Console.WriteLine($"Student's final assessment is {averageGrade:f2}.");
        isTrue = true;
        break;
    }
    for (s = 0;s<judgesNumber;s++)
    {
        string input = Console.ReadLine();
        if (input == "Finish")
        {
            averageGrade = gradeSum2 / g;
            Console.WriteLine($"Student's final assessment is {averageGrade:f2}.");
            isTrue = true;
            break;
        }
        grade = double.Parse(input);
        gradeSum += grade;


    }
    if (s == judgesNumber)
    {
        Console.WriteLine($"{nameOfPresentation} - {gradeSum / judgesNumber:f2}.");
        gradeSum2 += gradeSum / judgesNumber;
        gradeSum = 0;
        g++;
    }    
    if (isTrue)
    {
        break;
    }
}


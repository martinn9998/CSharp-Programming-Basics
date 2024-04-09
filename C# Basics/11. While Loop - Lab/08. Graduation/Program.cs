
string name = Console.ReadLine();
int gradesAges = 1;
int gradesAges2 = 0;
double sum = 0;
while (gradesAges <= 12)
{
    double gradeNumber = double.Parse(Console.ReadLine());
    if (gradesAges == 1)
    {
        if (gradeNumber < 4.00)
        {
            Console.WriteLine($"{name} has been excluded at {gradesAges} grade");
            gradesAges = 14;
            break;
        }
        sum += gradeNumber;
        gradesAges2++;
        gradesAges++;

    }
    else if (gradesAges == 2)
    {
        if (gradeNumber < 4.00)
        {
            Console.WriteLine($"{name} has been excluded at {gradesAges} grade");
            gradesAges = 14;
            break;
        }
        sum += gradeNumber;
        gradesAges2++;
        gradesAges++;
    }
    else if (gradesAges == 3)
    {
        if (gradeNumber < 4.00)
        {
            Console.WriteLine($"{name} has been excluded at {gradesAges} grade");
            gradesAges = 14;
            break;
        }
        sum += gradeNumber;
        gradesAges2++;
        gradesAges++;
    }
    else if (gradesAges == 4)
    {
        if (gradeNumber < 4.00)
        {
            Console.WriteLine($"{name} has been excluded at {gradesAges} grade");
            gradesAges = 14;
            break;
        }
        sum += gradeNumber;
        gradesAges2++;
        gradesAges++;
    }
    else if (gradesAges == 5)
    {
        if (gradeNumber < 4.00)
        {
            Console.WriteLine($"{name} has been excluded at {gradesAges} grade");
            gradesAges = 14;
            break;
        }
        sum += gradeNumber;
        gradesAges2++;
        gradesAges++;
    }
    else if (gradesAges == 6)
    {
        if (gradeNumber < 4.00)
        {
            Console.WriteLine($"{name} has been excluded at {gradesAges} grade");
            gradesAges = 14;
            break;

        }
        sum += gradeNumber;
        gradesAges2++;
        gradesAges++;
    }
    else if (gradesAges == 7)
    {
        if (gradeNumber < 4.00)
        {
            Console.WriteLine($"{name} has been excluded at {gradesAges} grade");
            gradesAges = 14;
            break;
        }
        sum += gradeNumber;
        gradesAges2++;
        gradesAges++;
    }
    else if (gradesAges == 8)
    {
        if (gradeNumber < 4.00)
        {
            Console.WriteLine($"{name} has been excluded at {gradesAges} grade");
            gradesAges = 14;
            break;
        }
        sum += gradeNumber;
        gradesAges2++;
        gradesAges++;
    }
    else if (gradesAges == 9)
    {
        if (gradeNumber < 4.00)
        {
            Console.WriteLine($"{name} has been excluded at {gradesAges} grade");
            gradesAges = 14;
            break;
        }
        sum += gradeNumber;
        gradesAges2++;
        gradesAges++;
    }
    else if (gradesAges == 10)
    {
        if (gradeNumber < 4.00)
        {
            Console.WriteLine($"{name} has been excluded at {gradesAges} grade");
            gradesAges = 14;
            break;
        }
        sum += gradeNumber;
        gradesAges2++;
        gradesAges++;
    }
    else if (gradesAges == 11)
    {
        if (gradeNumber < 4.00)
        {
            Console.WriteLine($"{name} has been excluded at {gradesAges} grade");
            gradesAges = 14;
            break;
        }
        sum += gradeNumber;
        gradesAges2++;
        gradesAges++;
    }
    else if (gradesAges == 12)
    {
        if (gradeNumber < 4.00)
        {
            Console.WriteLine($"{name} has been excluded at {gradesAges} grade");
            gradesAges = 14;
            break;
        }
        sum += gradeNumber;
        gradesAges2++;
        gradesAges++;
    }



}

double average = sum / (gradesAges2);

if (gradesAges == 14)
{

}
else
{
    Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
}
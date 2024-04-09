int numberOfEasterBreads = int.Parse(Console.ReadLine());
string nameOfBacker = "";
string grade = "";
int grade0 = 0;
bool isTrue = true;
int gradeCount = 0;
int gradeSumForCurrentBaker = 0;
string nameBakerMaxPoints = "";
int maxNumer = int.MinValue;
for  (int i = 0; i < numberOfEasterBreads; i++)
{
    nameOfBacker = Console.ReadLine();
  while (true)
    {
        grade = Console.ReadLine();
        if (grade== "Stop")
        {
            break;
        }
        grade0 = int.Parse(grade);
        gradeSumForCurrentBaker += grade0;

    }
    Console.WriteLine($"{nameOfBacker} has {gradeSumForCurrentBaker} points.");
    if (gradeSumForCurrentBaker>maxNumer)
    {
        maxNumer = gradeSumForCurrentBaker;
        nameBakerMaxPoints = nameOfBacker;
        Console.WriteLine($"{nameBakerMaxPoints} is the new number 1!");
    }
    gradeSumForCurrentBaker = 0;
}
if (isTrue)
{
    Console.WriteLine($"{nameBakerMaxPoints} won competition with {maxNumer} points!");
}
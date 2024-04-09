using System.Diagnostics.Contracts;

int number = int.Parse(Console.ReadLine());
double grade = 0, topStudent = 0, gradeSum = 0;
double grade4 = 0, grade3 = 0, fail = 0;
for  (int i = 0; i < number; i++)
{
    grade = double.Parse(Console.ReadLine());
    if (grade>=5.00)
    {
        topStudent++;
        gradeSum += grade;
    }
    else if (grade>= 4.00 && grade <= 4.99)
    {
        grade4++;
        gradeSum += grade;
    }
    else if (grade >= 3.00 && grade <= 3.99)
    {
        grade3++;
        gradeSum += grade;
    }
    else
    {
        fail++;
        gradeSum += grade;
    }
}
double allGrades = topStudent + grade4 + grade3 + fail;
double percentTopStudents = (topStudent / allGrades)  * 100;
double percentGrade4 = (grade4 / allGrades) * 100;
double percentGrade3 = (grade3 / allGrades) * 100;
double percentFail = (fail / allGrades) * 100;
double average = gradeSum / allGrades;
Console.WriteLine($"Top students: {percentTopStudents:f2}%");
Console.WriteLine($"Between 4.00 and 4.99: {percentGrade4:f2}%");
Console.WriteLine($"Between 3.00 and 3.99: {percentGrade3:f2}%");
Console.WriteLine($"Fail: {percentFail:f2}%");
Console.WriteLine($"Average: {average:f2}");
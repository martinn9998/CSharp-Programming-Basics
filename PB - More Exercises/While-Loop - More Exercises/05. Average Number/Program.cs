double number = int.Parse(Console.ReadLine());
int n = 0; 
double sum = 0;
for  (int i = 0; i < number; i++)
{
    n = int.Parse(Console.ReadLine());
    sum += n;
}
double average = sum / number;
Console.WriteLine($"{average:f2}");
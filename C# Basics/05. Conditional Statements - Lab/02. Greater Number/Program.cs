int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
bool firstBigger = number1 >= number2;
if (firstBigger)
{ 
    Console.WriteLine(number1); 
}
bool secondBigger = number1 < number2;
if (secondBigger)
{
    Console.WriteLine(number2);
}
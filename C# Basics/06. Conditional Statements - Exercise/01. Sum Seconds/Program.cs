int value1 = int.Parse(Console.ReadLine());
int value2 = int.Parse(Console.ReadLine());
int value3 = int.Parse(Console.ReadLine());
int sum = value1 + value2 + value3;
int min = sum / 60;
int sec = sum % 60;
if (sec < 10)
{
    Console.WriteLine($"{min}:0{sec}");
}
else { Console.WriteLine($"{min}:{sec}"); }
{

}
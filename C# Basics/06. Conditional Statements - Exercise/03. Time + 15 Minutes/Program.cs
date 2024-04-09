int hour = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());
int allMinutes = minutes + 15;
if (allMinutes < 60)
{
    if (allMinutes < 10)
    {
        Console.WriteLine($"{hour}:0{allMinutes}");
    }
    else
    {
        Console.WriteLine($"{hour}:{allMinutes}");
    }
}
else if (allMinutes == 60)
{
    hour++;
    allMinutes = 0;
    if (hour == 24)
    {
        hour = 0;
    }
    Console.WriteLine($"{hour}:0{allMinutes}");
}
else if (allMinutes > 60)
{
    int newMinutes = allMinutes % 60;
    hour += 1;
    if (hour == 24)
    {
        hour = 0;
    }
    if (newMinutes < 10)
    {
        Console.WriteLine($"{hour}:0{newMinutes}");
    }
    else
    {
        Console.WriteLine($"{hour}:{newMinutes}");
    }
}
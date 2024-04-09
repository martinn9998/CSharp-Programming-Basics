double capacity = double.Parse(Console.ReadLine());
string input = string.Empty;
double volume = 0;
double luggagesStored = 0;
bool end = true;
while (true)
{
    if (capacity <= 0)
    {
        end = false;
        break;
    }
    input = Console.ReadLine();
    if (input == "End")
    {
        break;
    }
    volume = double.Parse(input);
    
    
    luggagesStored++;
    if (luggagesStored == 3)
    {
        volume *= 1.1;
    }
    
    capacity -= volume;
  if (capacity <= 0)
    {
        luggagesStored--;
        continue;
    }
}
if (end)
{
    Console.WriteLine($"Congratulations! All suitcases are loaded!");
    Console.WriteLine($"Statistic: {luggagesStored} suitcases loaded.");
}
else
{
    Console.WriteLine($"No more space!");
    Console.WriteLine($"Statistic: {luggagesStored} suitcases loaded.");
}
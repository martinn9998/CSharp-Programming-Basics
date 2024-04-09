double nSum = 0;
string input = "";
bool end = false;
while (true)
{
    if (end)
    {
        break;
    }
    string country = Console.ReadLine();
    if (country == "End")
    {
        break;
    }
    double budget = double.Parse(Console.ReadLine());
    while (nSum<budget)
        {
        input = Console.ReadLine();
        if (input=="End")
        {
            end = true;
            break;
        }
        double n = double.Parse(input);
        nSum += n;
        if (nSum >= budget)
        {
            Console.WriteLine($"Going to {country}!");
            
        }
    }
    nSum = 0;
}
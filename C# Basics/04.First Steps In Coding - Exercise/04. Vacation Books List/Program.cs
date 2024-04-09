int pageNumbers = int.Parse(Console.ReadLine());
int pageHours = int.Parse(Console.ReadLine());
int dayNumbers = int.Parse(Console.ReadLine());
int timeWhole = pageNumbers / pageHours;
int timeDaily = timeWhole / dayNumbers;
Console.WriteLine(timeWhole / dayNumbers);
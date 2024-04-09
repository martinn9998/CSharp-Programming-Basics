string dayName = Console.ReadLine();
if (dayName == "Monday" || dayName == "Tuesday" || dayName == "Friday")
{
    Console.WriteLine(12);
}
else if (dayName == "Wednesday" || dayName == "Thursday")
{
    Console.WriteLine(14);
}
else if (dayName == "Saturday" || dayName == "Sunday")
{
    Console.WriteLine(16);
}
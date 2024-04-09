int number = int.Parse(Console.ReadLine());
if (100 > number) 
{
    Console.WriteLine("Less than 100"); 
}
else if (number <= 200) 
{
    Console.WriteLine("Between 100 and 200"); 
}
else 
{
    Console.WriteLine("Greater than 200"); 
}
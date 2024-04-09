
string favourateBook = Console.ReadLine();
int counter = 0;
bool isBookFound = false;
string nextBook = Console.ReadLine();
while (nextBook != "No More Books")
{
    if (nextBook == favourateBook)
    {
        isBookFound = true;
        break;
    }
    counter++;
    nextBook = Console.ReadLine();
}
if (isBookFound)
{
    Console.WriteLine($"You checked {counter} books and found it.");
}
else
{
    Console.WriteLine("The book you search is not here!");
    Console.WriteLine($"You checked {counter} books.");
}

char lastSector = char.Parse(Console.ReadLine());
int numberOfRowsFirstSector = int.Parse(Console.ReadLine());
int numberOfSeatsInOddRow = int.Parse(Console.ReadLine());
char currentChar = 'A';  // Използваме 'A' като начална стойност

int countCW = 0;

while (currentChar <= lastSector)
{
    for (int row = 1; row <= numberOfRowsFirstSector; row++)
    {
        int seatsLimit = (row % 2 == 1) ? numberOfSeatsInOddRow : numberOfSeatsInOddRow + 2;

        for (int seat = 0; seat < seatsLimit; seat++)
        {
            char seatChar = (char)('a' + seat);  // Генериране на символи 'a', 'b', 'c', ...
            Console.WriteLine($"{currentChar}{row}{seatChar}");
            countCW++;
        }
    }

    numberOfRowsFirstSector++;
    currentChar++;  // Увеличаваме текущия символ с 1 (преход към следващия сектор)
}

Console.WriteLine(countCW);


int floors = int.Parse(Console.ReadLine());
int rooms = int.Parse(Console.ReadLine());
int asd = floors ;
bool isTrue = false ;
for (int i = floors; i <= asd; i--)
{
    for (int j = 0; j < rooms; j++)
    {

        if (i == floors)
        {
            Console.Write($"L{i}{j} ");
            if (i == 1 && j == rooms - 1)
            {
                isTrue = true;
                break;
            }
        }

        else if (i % 2 == 0)
        {
            Console.Write($"O{i}{j} ");
            if (i == 1 && j == rooms - 1)
            {
                isTrue = true;
                break;
            }
        }
        else if (i % 2 == 1)
        {

            Console.Write($"A{i}{j} ");
            if (i == 1 && j == rooms - 1)
            {
                isTrue = true;
                break;
            }
        }
           
    }


    if (isTrue)
    {
        break;
    }
    Console.WriteLine();    
}   

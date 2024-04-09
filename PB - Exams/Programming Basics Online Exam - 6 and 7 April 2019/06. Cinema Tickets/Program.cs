string movieName = "";
int availableSeats = 0;
int ticketSell = 0;
bool isTrue = false;
double percentStudentTickets = 0;
double studentTicket = 0;
double percentStandardTickets = 0;
double standardTickets = 0;
double percentKidTickets = 0;
double kidTickets = 0;
string typeOfTicket = "";
double sumTickets = 0;
int i = 0;

for (; true;)

{
    if (isTrue)
    {
        break;
    }



    movieName = Console.ReadLine();
    if (movieName == "Finish")
    {

        Console.WriteLine($"Total tickets: {sumTickets}");
        percentStudentTickets = (studentTicket / sumTickets) * 100;
        Console.WriteLine($"{percentStudentTickets:f2}% student tickets.");
        percentStandardTickets = (standardTickets / sumTickets) * 100;
        Console.WriteLine($"{percentStandardTickets:f2}% standard tickets.");
        percentKidTickets = (kidTickets / sumTickets) * 100;
        Console.WriteLine($"{percentKidTickets:f2}% kids tickets.");
        isTrue = true;

    }
    if (isTrue)
    {
        break;
    }
    availableSeats = int.Parse(Console.ReadLine());
    for (i = 0; i < availableSeats; i++)
    {
        typeOfTicket = Console.ReadLine();

        if (typeOfTicket == "End")
        {
            double ticketSell123 = ticketSell;
            double availableSets123 = availableSeats;
            Console.WriteLine($"{movieName} - {(ticketSell123 / availableSets123) * 100:f2}% full.");
            sumTickets += ticketSell;
            ticketSell = 0;
            break;
        }
        else if (typeOfTicket == "Finish")
        {

            Console.WriteLine($"Total tickets: {sumTickets}");
            percentStudentTickets = (studentTicket / sumTickets) * 100;
            Console.WriteLine($"{percentStudentTickets}% student tickets.");
            percentStandardTickets = (standardTickets / sumTickets) * 100;
            Console.WriteLine($"{percentStandardTickets}% standard tickets.");
            percentKidTickets = (kidTickets / sumTickets) * 100;
            Console.WriteLine($"{percentKidTickets}% kids tickets.");
            isTrue = true;
            break;
        }
        else if (typeOfTicket == "standard")
        {
            standardTickets++;
            ticketSell++;
            continue;
        }
        else if (typeOfTicket == "student")
        {
            studentTicket++;
            ticketSell++;
            continue;
        }
        else if (typeOfTicket == "kid")
        {
            kidTickets++;
            ticketSell++;
            continue;
        }

    }

    if (i == availableSeats)
    {
        double ticketSell123 = ticketSell;
        double availableSets123 = availableSeats;
        Console.WriteLine($"{movieName} - {(ticketSell123 / availableSets123) * 100:f2}% full.");
        sumTickets += ticketSell;
        ticketSell = 0;



        continue;
    }
}
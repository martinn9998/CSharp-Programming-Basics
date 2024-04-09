int hourExam = int.Parse(Console.ReadLine());
int minuteExam = int.Parse(Console.ReadLine());
int hourArrival = int.Parse(Console.ReadLine());
int minuteArrival = int.Parse(Console.ReadLine());
if ((hourExam <= 23 & hourExam >= 0) & (hourArrival <= 23 & hourArrival >= 0) & (minuteExam <= 59 & minuteExam >= 0) & (minuteArrival <= 59 & minuteArrival >= 0))
{
    double convertHourExam = (hourExam * 60) + minuteExam;
    double convertHourArrival = (hourArrival * 60) + minuteArrival;
    if (convertHourExam - convertHourArrival > 30)
    {
        double resultHours = (convertHourExam - convertHourArrival) / 60;
        double resultMinutes = (convertHourExam - convertHourArrival) % 60;
        if (resultHours <= 0.999)
        {
            if (resultMinutes <= 9.9999)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{Math.Floor(resultMinutes)} minutes before the start");
            }
            else if (resultMinutes > 9.9999)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{Math.Floor(resultMinutes)} minutes before the start");
            }
        }
        else if (resultHours > 0.999)
        {
            if (resultMinutes <= 9.9999)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{Math.Floor(resultHours)}:0{Math.Floor(resultMinutes)} hours before the start");
            }
            else if (resultMinutes > 9.9999)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{Math.Floor(resultHours)}:{Math.Floor(resultMinutes)} hours before the start");
            }
        }
    }
    else if (convertHourExam - convertHourArrival <= 30 & convertHourExam - convertHourArrival >= 0)
    {
        double resultHours = (convertHourExam - convertHourArrival) / 60;
        double resultMinutes = (convertHourExam - convertHourArrival) % 60;
        if (resultHours <= 0.999)
        {
            if (resultHours == 0 & resultMinutes == 0)
            {
                Console.WriteLine("On time");
            }
            else if (resultMinutes <= 9.9999)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{Math.Floor(resultMinutes)} minutes before the start");
            }
            else if (resultMinutes > 9.9999)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{Math.Floor(resultMinutes)} minutes before the start");
            }
        }
        else if (resultHours > 0.999)
        {
            if (resultMinutes <= 9.9999)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{Math.Floor(resultHours)}:0{Math.Floor(resultMinutes)} hours before the start");
            }
            else if (resultMinutes > 9.9999)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{Math.Floor(resultHours)}:{Math.Floor(resultMinutes)} hours before the start");
            }
        }

    }
    else if (convertHourArrival - convertHourExam > 0)
    {
        double resultHours = (convertHourArrival - convertHourExam) / 60;
        double resultMinutes = (convertHourArrival - convertHourExam) % 60;
        if (resultHours <= 0.999)
        {
            if (resultMinutes <= 9.9999)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{Math.Floor(resultMinutes)} minutes after the start");
            }
            else if (resultMinutes > 9.9999)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{Math.Floor(resultMinutes)} minutes after the start");
            }
        }
        else if (resultHours > 0.999)
        {

            if (resultMinutes <= 9.9999)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{Math.Floor(resultHours)}:0{Math.Floor(resultMinutes)} hours after the start");
            }
            else if (resultMinutes > 9.9999)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{Math.Floor(resultHours)}:{Math.Floor(resultMinutes)} hours after the start");
            }
        }
    }
}



double rent = int.Parse(Console.ReadLine());
double statuettePrice = rent * 0.7;
double catering = statuettePrice * 0.85;
double musicPrice = catering * 0.5;
double sumPrice = rent + statuettePrice + catering + musicPrice;
Console.WriteLine($"{sumPrice:f2}");
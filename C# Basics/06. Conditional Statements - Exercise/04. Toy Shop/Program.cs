using static System.Net.Mime.MediaTypeNames;

double excursionPrice = double.Parse(Console.ReadLine());
int numberPuzzles = int.Parse(Console.ReadLine());
int talkingDolls = int.Parse(Console.ReadLine());
int teddyBears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int truckToys = int.Parse(Console.ReadLine());
double summ = numberPuzzles * 2.60 + talkingDolls * 3 + teddyBears * 4.10 + minions * 8.20 + truckToys * 2;
double numberAll = numberPuzzles + talkingDolls + teddyBears + minions + truckToys;
if (numberAll >= 50)
{
    double discountSumm = summ - (summ * 0.25);
    double turnover = discountSumm - (discountSumm * 0.1);
    if (turnover >= excursionPrice)
    {
        double final = Math.Round(turnover - excursionPrice, 2);
        string text = string.Format("{0:f2}", final);
        Console.WriteLine($"Yes! {text} lv left.");
    }
    else if (turnover < excursionPrice)
    {
        double final = Math.Round(excursionPrice - turnover, 2);
        string text = string.Format("{0:f2}", final);
        Console.WriteLine($"Not enough money! {text} lv needed.");
    }
}
else
{

    double discountSumm = summ;
    double turnover = discountSumm - (discountSumm * 0.1);
    if (turnover >= excursionPrice)
    {
        double final = Math.Round(turnover - excursionPrice, 2);
        string text = string.Format("{0:f2}", final);
        Console.WriteLine($"Yes! {text} lv left.");

    }
    else if (turnover < excursionPrice)
    {
        double final = Math.Round(excursionPrice - turnover, 2);
        string text = string.Format("{0:f2}", final);
        Console.WriteLine($"Not enough money! {text} lv needed.");
    }
}
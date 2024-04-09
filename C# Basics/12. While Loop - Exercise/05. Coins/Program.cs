double sum = double.Parse(Console.ReadLine());
int counter = 0;
bool isTrue = true;
while (sum > 0)
{

    if (sum >= 2.00)
    {
        sum -= 2.00;
        sum = Math.Round(sum, 02);
        counter++;

    }
    else if (sum >= 1.00)
    {
        sum -= 1.00;
        sum = Math.Round(sum, 02);
        counter++;

    }
    else if (sum >= 0.50)
    {
        sum -= 0.50;
        sum = Math.Round(sum, 02);
        counter++;

    }
    else if (sum >= 0.20)
    {
        sum -= 0.20;
        sum = Math.Round(sum, 02);
        counter++;

    }
    else if (sum >= 0.10)
    {
        sum -= 0.10;
        sum = Math.Round(sum, 02);
        counter++;

    }
    else if (sum >= 0.05)
    {
        sum -= 0.05;
        sum = Math.Round(sum, 02);
        counter++;

    }
    else if (sum >= 0.02)
    {
        sum -= 0.02;
        sum = Math.Round(sum, 02);
        counter++;

    }
    else if (sum >= 0.01)
    {
        sum -= 0.01;
        sum = Math.Round(sum, 02);
        counter++;

    }


}
Console.WriteLine(counter);

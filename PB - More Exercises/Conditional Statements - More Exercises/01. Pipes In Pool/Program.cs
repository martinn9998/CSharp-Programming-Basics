double v = double.Parse(Console.ReadLine());
double p1 = double.Parse(Console.ReadLine());
double p2 = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());
double firstPipeCalculation = p1 * h;
double secondPipeCalculation = p2 * h;
double pipesSum = firstPipeCalculation + secondPipeCalculation;
if (pipesSum<=v)
{
    double poolFullPercent = (pipesSum / v) * 100;
    double firstPipePercent = (firstPipeCalculation / pipesSum) * 100;
    double secondPipePercent = (secondPipeCalculation / pipesSum) * 100;
    Console.WriteLine($"The pool is {poolFullPercent:f2}% full. Pipe 1: {firstPipePercent:f2}%. Pipe 2: {secondPipePercent:f2}%.");
}
else
{
    double overflow = pipesSum - v;
    Console.WriteLine($"For {h:f2} hours the pool overflows with {overflow:f2} liters.");
}
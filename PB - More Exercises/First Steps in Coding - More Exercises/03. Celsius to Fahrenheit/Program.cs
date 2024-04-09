double celsius = double.Parse(Console.ReadLine());
double fahrenheit = (9.0 / 5.0);
fahrenheit *= celsius;
fahrenheit += 32;


Console.WriteLine($"{fahrenheit:f2}");
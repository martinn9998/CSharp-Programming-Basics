// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double lenghtCm = double.Parse(Console.ReadLine());
double widthCm = double.Parse(Console.ReadLine());
double heightCm = double.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());
double volumeCm = lenghtCm * widthCm * heightCm;
double volumeDm = volumeCm * 0.001;
double finalVolumeDm = volumeDm - (volumeDm * (percent / 100));
Console.WriteLine(finalVolumeDm);
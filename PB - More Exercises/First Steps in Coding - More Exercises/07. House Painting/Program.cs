double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());
//walls
double sideWall = x * y;
double windowArea = 1.5 * 1.5;
double twoPagesTotal = 2 * sideWall - 2 * windowArea;
double backWall = x * x;
double input = 1.2 * 2;
double totalFrontAndRear = 2 * backWall - input;
double totalArea = twoPagesTotal + totalFrontAndRear; //m2
double greenPaint = totalArea / 3.4; //lters
//roof
double theTwoRectanglesOTR = 2 * (x * y);
double theTwoTriangles = 2 * (x * h / 2);
//total area
double totalArea2 = theTwoRectanglesOTR + theTwoTriangles;//m2
double redPaint = totalArea2 / 4.3; //liters

Console.WriteLine($"{greenPaint:f2}");
Console.WriteLine($"{redPaint:f2}");
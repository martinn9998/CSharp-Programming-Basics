double cortyard = double.Parse(Console.ReadLine()) * 7.61;
double discount = cortyard * 0.18;
double final = cortyard - discount;
Console.WriteLine($"The final price is: {final} lv.");
Console.WriteLine($"The discount is: {discount} lv.");
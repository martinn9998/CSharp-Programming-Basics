double ammountDep = double.Parse(Console.ReadLine());
double timeDep = double.Parse(Console.ReadLine());
double percentAnnual = double.Parse(Console.ReadLine());
double annualIncrease = ammountDep * (percentAnnual / 100);
double monthlyIncrease = annualIncrease / 12;
double ammountFinal = ammountDep + timeDep * monthlyIncrease;
Console.WriteLine(ammountFinal);
double capacityStadium = double.Parse(Console.ReadLine());
double allFans = double.Parse(Console.ReadLine());
char sector = ' ';
double sectorA = 0, sectorB = 0, sectorV = 0, sectorG = 0;
for  (int i = 0; i < allFans; i++)
{
    sector = char.Parse(Console.ReadLine());
    if (sector == 'A')
    {
        sectorA++;
    }
    else if (sector == 'B')
    {
        sectorB++;
    }
    else if (sector == 'V')
    {
        sectorV++;
    }
    else if (sector == 'G')
    {
        sectorG++;
    }
}
double percentSectorA = (sectorA / allFans) * 100;
double percentSectorB = (sectorB / allFans) * 100;
double percentSectorV = (sectorV / allFans) * 100;
double percentSectorG = (sectorG / allFans) * 100;
double percentStadium = (allFans / capacityStadium) * 100;
Console.WriteLine($"{percentSectorA:f2}%");
Console.WriteLine($"{percentSectorB:f2}%");
Console.WriteLine($"{percentSectorV:f2}%");
Console.WriteLine($"{percentSectorG:f2}%");
Console.WriteLine($"{percentStadium:f2}%");

int numberOfGroups = int.Parse(Console.ReadLine());
double people = 0, everest = 0, k2 = 0, kalimandjaro = 0, monblan = 0, musala = 0;
double sumPeople = 0, everestPeople = 0, k2People = 0, kalimandjaroPeople = 0, monblanPeople = 0, musalaPeople = 0;
for (int i = 1; i <= numberOfGroups; i++)
{
    people = int.Parse(Console.ReadLine());
    if (people >= 1 && people <= 5)
    {
        musala++;
        sumPeople += people;
        musalaPeople += people;
    }
    else if (people >= 6 && people <= 12)
    {
        monblan++;
        sumPeople += people;
        monblanPeople += people;
    }
    else if (people >= 13 && people <= 25)
    {
        kalimandjaro++;
        sumPeople += people;
        kalimandjaroPeople += people;
    }
    else if (people >= 26 && people <= 40)
    {
        k2++;
        sumPeople += people;
        k2People += people;
    }

    else if (people >= 41)
    {
        everest++;
        sumPeople += people;
        everestPeople += people;
    }



}

double percentMusala = (musalaPeople / sumPeople) * 100;
double percentMonblan = (monblanPeople / sumPeople) * 100;
double percentKalinmadjaro = (kalimandjaroPeople / sumPeople) * 100;
double percentK2 = (k2People / sumPeople) * 100;
double percentEverest = (everestPeople / sumPeople) * 100;
Console.WriteLine($"{percentMusala:f2}%");
Console.WriteLine($"{percentMonblan:f2}%");
Console.WriteLine($"{percentKalinmadjaro:f2}%");
Console.WriteLine($"{percentK2:f2}%");
Console.WriteLine($"{percentEverest:f2}%");
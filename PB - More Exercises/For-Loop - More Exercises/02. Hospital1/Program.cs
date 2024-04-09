int period = int.Parse(Console.ReadLine());
int patients = 0, doctors = 7, treatedPatients = 0;
int untreatedPatients = 0, daysNewDoctor = 1;

for (int days = 1; days <= period; daysNewDoctor++,days++)
{
    if (daysNewDoctor == 3)
    {
        if (untreatedPatients > treatedPatients)
        {
            doctors++;
            daysNewDoctor = 0;
        }
        else
        {
            daysNewDoctor = 0;
        }
    }
    patients = int.Parse(Console.ReadLine());
    if (patients < doctors)
    {
        treatedPatients += patients;
        patients = 0;
        continue;
    }
    else
    {
        patients -= doctors;
        treatedPatients += doctors;
    }

    if (patients > 0)
    {
        untreatedPatients += patients;
    }

}
Console.WriteLine($"Treated patients: {treatedPatients}.");
Console.WriteLine($"Untreated patients: {untreatedPatients}.");
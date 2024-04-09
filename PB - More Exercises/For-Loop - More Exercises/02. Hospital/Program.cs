int period = int.Parse(Console.ReadLine());
int patients = 0, doctors = 7, treatedPatients = 0;
int untreatedPatients = 0;

for (int days = 1; days <= period;days++)
{
    if (days == 3)
    {
        if (untreatedPatients > treatedPatients)
        {
            doctors++;
        }
    }
    patients = int.Parse(Console.ReadLine());
    if (patients < doctors)
    {
        treatedPatients = patients;
    }
    else
    {
        patients -= doctors;
        treatedPatients += doctors;
    }
    
    if (patients>0)
    {
        untreatedPatients += patients;
    }
   
}
Console.WriteLine($"Treated patients: {treatedPatients}.");
Console.WriteLine($"Untreated patients: {untreatedPatients}.");
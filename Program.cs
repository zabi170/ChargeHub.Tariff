Console.WriteLine(Tariff.AcPrice().ToString("F2"));

static decimal SumEnergy(decimal[] kwh)
{
    decimal sum = 0m;
   for (int i = 0; i < kwh.Length; i++)
    {
        sum += kwh[i];
    }
    return sum;
}

Console.WriteLine(SumEnergy(new decimal[] { 20, 20, 12, 40 }));



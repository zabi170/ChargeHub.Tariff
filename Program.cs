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

var stations = new List<Station>
{
    new Station { Name = "Torget" },
    new Station(),
    new Station { Name = "Hamnen" }
};

foreach (var s in stations)
{
    Console.WriteLine("DEBUG: " + s.Name);

    try
    {
        Console.WriteLine(s.Name.ToUpper());
    }
    catch (NullReferenceException)
    {
        Console.WriteLine("Station utan namn");
    }
}

class Station
{
    public string Name { get; set; }
}



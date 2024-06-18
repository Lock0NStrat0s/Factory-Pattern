using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern;

internal class Refrigerator : IAppliances
{
    public int CoolingLevel { get; set; } = 1000;
    public void Start()
    {
        Console.WriteLine($"I cool and preserve food. My cooling level is {CoolingLevel}.");
    }
}

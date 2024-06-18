using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern;

internal class WashingMachine : IAppliances
{
    public int WashingLevel { get; set; } = 10;
    public void Start()
    {
        Console.WriteLine($"I wash clothes. My washing level is {WashingLevel}.");
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern;

internal class Microwave : IAppliances
{
    public int HeatLevel { get; set; } = 100;
    public void Start()
    {
        Console.WriteLine($"I cook and heat food. My cooking level is {HeatLevel}.");
    }
}

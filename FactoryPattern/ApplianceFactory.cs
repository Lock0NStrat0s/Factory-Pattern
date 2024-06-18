using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern;

internal static class ApplianceFactory
{
    public static IAppliances GetAppliance(string applianceType)
    {
        switch (applianceType.ToLower())
        {
            case "fridge":
                return new Refrigerator();
            case "microwave":
                return new Microwave();
            case "wash":
                return new WashingMachine();
            default:
                return new Refrigerator();
        }
    }
}

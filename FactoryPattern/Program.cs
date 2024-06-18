namespace FactoryPattern;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Select an appliance (\"fridge\"(default), \"microwave\", or \"wash\"): ");
        IAppliances appliance = ApplianceFactory.GetAppliance(Console.ReadLine());
        appliance.Start();
    }
}

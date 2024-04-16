using System;

namespace KinetikEnerjiHesaplayici
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cismin kütlesini giriniz (kilogram cinsinden): ");
            double mass = Convert.ToDouble(Console.ReadLine());

            Console.Write("Cismin hızını giriniz (saniyede metre cinsinden): ");
            double velocity = Convert.ToDouble(Console.ReadLine());

            double kineticEnergy = KineticEnergy(mass, velocity);

            Console.WriteLine($"Cismin kinetik enerjisi: {kineticEnergy:n2} joule");
            Console.ReadKey();
        }

        static double KineticEnergy(double mass, double velocity)
        {
            return 0.5 * mass * Math.Pow(velocity, 2);
        }
    }
}

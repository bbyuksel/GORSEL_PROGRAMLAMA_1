using System;
using System.Threading;
using System.IO;
class Program
{
    static void Main()
    {
        Console.WriteLine("Celcius\t\tFahrenheit");
        Console.WriteLine("-----------------------");
        for (int C = 0; C <= 20; C++) 
        {
            double F = (double)9 / 5 * C + 32;
            Console.WriteLine($"{C}\t\t{F:N1}");
        }
    }
}
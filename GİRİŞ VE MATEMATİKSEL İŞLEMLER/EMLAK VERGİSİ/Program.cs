using System;
using System.Reflection.Metadata;
class Program
{
    static void Main(string[] args)
    {
        const double VERGI_ORANI = 0.64;
        int mulkDegeri = Convert.ToInt32(Console.ReadLine());
        double emlakVergisi = mulkDegeri / 100 * VERGI_ORANI;
        Console.WriteLine("Emlak Vergisi: " + emlakVergisi + "TL");
    }
}

using System;
using System.Reflection.Metadata;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kilonuzu giriniz: ");
        double kilo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Boyunuzu giriniz: ");
        double boy = Convert.ToDouble(Console.ReadLine());
        boy /= 100; // boy = boy / 100

        double vki = kilo / (boy * boy);
        Console.WriteLine("Vücut kitle indeksiniz: " + vki.ToString("N2"));
    }
}
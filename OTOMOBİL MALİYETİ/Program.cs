using System;
using System.Reflection.Metadata;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kredi Ödeme tutarini giriniz: ");
        double krediOdemesi = Convert.ToDouble( Console.ReadLine());

        Console.WriteLine("Sigorta Ödeme tutarini giriniz: ");
        double sigorta = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Yakit  tutarini giriniz: ");
        double yakit = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Yag maliyetini tutarini giriniz: ");
        double yag = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Lastik giderlerini giriniz: ");
        double lastikler = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Bakım giderini giriniz: ");
        double bakim = Convert.ToDouble(Console.ReadLine());

        //aylik ve yillik hesapla
        double aylikGider = krediOdemesi + sigorta + yakit + yag + lastikler + bakim;
        double yillikGider = aylikGider * 12;
        
        //Ekrana yaz
        Console.WriteLine("Aylık Maliyet: " + aylikGider.ToString("N2") + "TL");
        Console.WriteLine("Yıllık Maliyet: " + yillikGider.ToString("N2") + "TL");
    }
}
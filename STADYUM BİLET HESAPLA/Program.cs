using System;
using System.Reflection.Metadata;
class Program
{
    static void Main(string[] args)
    {
        const int aSinifiBiletFiyati = 150;
        const int bSinifiBiletFiyati = 120;
        const int cSinifiBiletFiyati = 90;

        Console.WriteLine("A Sınıfı Koltuklar için Satılan Bilet Sayısı Girin: ");
        int aSinifiSatilanBilet = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("B Sınıfı Koltuklar için Satılan Bilet Sayısı Girin: ");
        int bSinifiSatilanBilet = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("C Sınıfı Koltuklar için Satılan Bilet Sayısı Girin: ");
        int cSinifiSatilanBilet = Convert.ToInt32(Console.ReadLine());

        int aSinifiGelir = aSinifiBiletFiyati * aSinifiSatilanBilet;
        int bSinifiGelir = bSinifiBiletFiyati * bSinifiSatilanBilet;
        int cSinifiGelir = cSinifiBiletFiyati * cSinifiSatilanBilet;
        int toplamGelir = aSinifiGelir + bSinifiGelir + cSinifiGelir;

        Console.WriteLine("A sınıf bilet satışından elde edilen gelir: " + aSinifiGelir + "TL");
        Console.WriteLine("B sınıf bilet satışından elde edilen gelir: " + bSinifiGelir + "TL");
        Console.WriteLine("C sınıf bilet satışından elde edilen gelir: " + cSinifiGelir + "TL");
        Console.WriteLine("Toplam Gelir: " + toplamGelir + "TL");

        Console.ReadKey();

    }
}
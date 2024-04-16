using System;

class Program
{
    static void Main()
    {
        const double baslangicOgrenimUcreti = 6000;
        const double artisOrani = 0.02;

        double simdikiOgrenimUcreti = baslangicOgrenimUcreti;

        Console.WriteLine("Yıl\t\tÖğrenim Ücreti");
        Console.WriteLine("-----------------------------------");

        //Sonraki 5 yıl için öğrenim ücretlerini hesapla ve görüntüle
        for (int yil = 1; yil <=5; yil++)
        {
            //Öğrenim ücretini güncelle
            simdikiOgrenimUcreti += simdikiOgrenimUcreti * artisOrani;
            //Sonucu yazdır
            Console.WriteLine($"{yil}\t\t{simdikiOgrenimUcreti:N2} TL");
        }
    }
}

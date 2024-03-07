using System;
using System.Reflection.Metadata;
class Program
{
    static void Main(string[] args)
    {
        const int toplamKurabiyeSayisi = 40; //toplam kurabiye sayısı
        const int porsiyonSayisi = 10; //posette 10  porsiyon var
        const int porsiyonBasinaKurabiye = toplamKurabiyeSayisi / porsiyonSayisi;
        const int porsiyonBasinaKalori = 300;
        double kurabiyeBasinaKalori = (double)porsiyonBasinaKalori / porsiyonBasinaKurabiye;

        Console.WriteLine("Kaç kurabiye yediniz: ");
        // klavyeden girilen değeri oku
        // değeri integer' a dönüştür
        // int' e dönüşen değeri yenilenKurabiye değişkenine ata
        int yenilenKurabiye = Convert.ToInt32(Console.ReadLine());

        double tuketilenKalori = yenilenKurabiye * kurabiyeBasinaKalori;

        Console.WriteLine($"Toplam tüketilen kalori: {tuketilenKalori}"); //aynı
        Console.WriteLine("Toplam tüketilen kalori: " + tuketilenKalori);

    }

}


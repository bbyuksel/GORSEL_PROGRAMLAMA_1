using System;

class Program
{
    static void Main()
    {
        double kaloriYakmaOrani = 3.9; //dakikada yakılan kalori
        Console.WriteLine("Dakika\t\tYakılan Kaloriler");//Başlık satırı
        Console.WriteLine("-----------------------------");//Ayırıcı

        //Belirli dakikalardaki yakılan kalori miktarını hesapla ve görüntüle
        for (int dakika = 10; dakika <=30; dakika+=5)
        {
            double yakilanKaloriler = dakika*kaloriYakmaOrani;
            Console.WriteLine($"{dakika}\t\t{yakilanKaloriler:N2}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO; // Dosya işlemleri için gerekli
class Program
{
    static void Main(string[] args)
    {
        try
        {
            StreamReader sr = new StreamReader("USPopulation.txt");
            List<int> yillar = new List<int>();
            string satir;
            int mevcutArtis;
            int enBuyukArtis;
            int enKucukArtis;
            int enKucukArtisYili = 0;
            int enBuyukArtisYili = 0;
            int artislarinToplami = 0;
            while (!sr.EndOfStream)
            {
                satir = sr.ReadLine();
                yillar.Add(Convert.ToInt32(satir));
            }
            sr.Close();
            enBuyukArtis = 0;
            enKucukArtis = yillar[1] - yillar[0];
            for (int i = 0; i < yillar.Count - 1; i++)
            {
                mevcutArtis = yillar[i + 1] - yillar[i];
                Console.WriteLine("Yıl " + (1950 + i) + " ve " + (1950 + i + 1) + " arasındaki artış: "
               + mevcutArtis);
                artislarinToplami += mevcutArtis;
                if (mevcutArtis <= enKucukArtis)
                {
                    enKucukArtis = mevcutArtis;
                    enKucukArtisYili = 1950 + i;
                }
                if (mevcutArtis >= enBuyukArtis)
                {
                    enBuyukArtis = mevcutArtis;
                    enBuyukArtisYili = 1950 + i;
                }
            }
            double ortalama = (double)artislarinToplami / (yillar.Count);
            Console.WriteLine("Ortalama Artış: " + (ortalama * 1000).ToString("n2"));
            Console.WriteLine("En Büyük Artış: " + (enBuyukArtis * 1000).ToString("n2") + " yılında oldu: " + enBuyukArtisYili);


            Console.WriteLine("En Küçük Artış: " + (enKucukArtis * 1000).ToString("n2") + " yılında oldu: " + enKucukArtisYili);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Bir hata oluştu: " + ex.Message);
        }
        Console.ReadKey();  
    }
}
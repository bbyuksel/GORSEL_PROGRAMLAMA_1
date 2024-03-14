namespace RASTGELE_SAYI_TAHMİN_OYUNU
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();

            while (true)
            {
                int rastgeleSayi = rnd.Next(1, 101);
                int tahminSayisi = 0;
                Console.WriteLine("1 ile 100 arasında bir sayı tahmin edin. Oyunu bitirmek için -1 girin");
                while (true)
                {
                    Console.WriteLine("Tahmininiz: ");
                    int tahmin = Convert.ToInt32(Console.ReadLine());
                    if (tahmin == -1)
                    {
                        Console.WriteLine("Oyun sonlandırıldı..");
                        break;
                    }
                    tahminSayisi++;
                    if (tahmin < rastgeleSayi)
                    {
                        Console.WriteLine("Çok düşük, tekrar dene..");
                    }
                    else if (tahmin > rastgeleSayi)
                    {
                        Console.WriteLine("Çok büyük, tekrar dene..");
                    }
                    else
                    {
                        Console.WriteLine($"Tebrikler bildiniz :) Tahmin sayısı: {tahminSayisi}");
                        break;
                    }
                }
                Console.WriteLine("Yeni bir oyun başlatmak ister misin? (e/h)");
                string cevap = Console.ReadLine();
                if (cevap != "e")
                {
                    Console.WriteLine("Oyun sona erdi. Tekrar oynamak için programı yeniden başlatın..");
                    break;
                }


            }
        }
    }
}

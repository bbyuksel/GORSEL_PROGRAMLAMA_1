namespace EHLİYET_SINAVI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Doğru Cevaplar dizisi
            char[] correctAnswers = { 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'A', 'A', 'A', 'B', 'A', 'A', 'A', 'A', 'A', 'C', 'B', 'D', 'A' };

            //Öğrencinin cevapları dizisi
            char[] studentAnswers = new char[20];

            //dosya yolu
            string dosyaYolu = "StudentAnswers.txt";
            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);
                for (int i = 0; i < satirlar.Length; i++)
                {
                    studentAnswers[i] = Convert.ToChar(satirlar[i].ToUpper());
                }

                //Değerlendirme
                int dogruSayisi = 0;
                int yanlisSayisi = 0;
                List<int> yanlisCevaplar = new List<int>();

                for (int i = 0; i < satirlar.Length; i++)
                {
                    if (studentAnswers[i] == correctAnswers[i])
                    {
                        dogruSayisi++;
                    }
                    else
                    {
                        yanlisSayisi++;
                        yanlisCevaplar.Add(i + 1);
                    }
                }

                // Sonuçları göster
                Console.WriteLine("Doğru cevapların sayısı: " + dogruSayisi);
                Console.WriteLine("Yanlış cevapların sayısı: " + yanlisSayisi);

                Console.WriteLine("Yanlış cevaplanan sorular");
                foreach (var y in yanlisCevaplar)
                {
                    Console.WriteLine(y);
                }

                string sonuc = dogruSayisi > 14 ? "Tebrikler Geçtiniz" : "Maalesef kaldınız";
                Console.WriteLine(sonuc);
            }



        }
    }
}

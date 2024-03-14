namespace TOPLAMA_ÖĞRETMENİ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            while (true)
            {
                int sayi1 = rnd.Next(100, 501); //100 ile 500 arasında rastgele bir sayı
                int sayi2 = rnd.Next(100, 501);//100 ile 500 arasında rastgele bir sayı

                Console.WriteLine($"{sayi1} + {sayi2} = ?");
                Console.WriteLine("Cevabınız: ");

                int cevap = int.Parse(Console.ReadLine());
                if (cevap == sayi1 + sayi2)
                {
                    Console.WriteLine("Tebrikler! Bildiniz..");
                }
                else
                {
                    Console.WriteLine($"Yanlış cevap. Doğru cevap:{sayi1 + sayi2}");
                }
                Console.WriteLine("Yeni bir problem için 'e' tuşuna basınız, çıkmak için herhangi bir tuşa basınız..");
                string giris = Console.ReadLine();
                if (giris.ToLower() != "e")
                    break;
            }
        }
    }
}

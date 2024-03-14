using System;

namespace ZAR_OYUNU
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Zar atmak için herhangi bir tuşa basınız. Çıkış için (q)");
            Random random = new Random();
            while (true) 
            {
                string input  = Console.ReadLine();
                //Çıkış Koşulu
                if (input.ToLower() == "q")
                    break;
                
                //iki zar için rastgele sayı üret
                int zar1 = random.Next(1, 6);
                int zar2 = random.Next(1, 6);

                //Zar değerlerini yazdır
                Console.WriteLine($"Zar 1: {zar1}, Zar 2: {zar2}");
                Console.WriteLine("Zar atmak için herhangi bir tuşa basınız. Çıkış için (q)");
            }
        }
    }
}

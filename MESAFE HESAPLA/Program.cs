using System;
using System.Threading; // Thread.Sleep için gerekli
class Program
{
    static void Main()
    {
        // Kullanıcıdan hızı ve seyahat süresini al
        Console.Write("Lütfen aracın hızını (mil/saat) giriniz: ");
        int hiz = Convert.ToInt32(Console.ReadLine());
        Console.Write("Lütfen seyahat süresini (saat) giriniz: ");
        int zaman = Convert.ToInt32(Console.ReadLine());
        // Her saat için kat edilen mesafeyi hesapla ve görüntüle
        for (int saat = 1; saat <= zaman; saat++)
        {
            int mesafe = hiz * saat;
            Console.WriteLine($"{saat}. saat sonunda kat edilen mesafe: {mesafe} mil");
            // Her çıktı arasında 1 saniye beklet
            Thread.Sleep(1000); // 1000 milisaniye = 1 saniye
        }
    }
}
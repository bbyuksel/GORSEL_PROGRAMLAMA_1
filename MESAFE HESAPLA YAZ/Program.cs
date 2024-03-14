using System;
using System.Threading;
using System.IO;
class Program
{
    static void Main()
    {
        StreamWriter yaz = new StreamWriter("mesafeler.txt");
        Console.WriteLine("Lütfen aracın hızını (km/saat) giriniz:");
        int hiz = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lütfen seyahat süresini (saat) giriniz:");
        int saat = Convert.ToInt32(Console.ReadLine());

        //her saat kat edilen mesafeyi ekrana yaz
        for (int i = 1; i <= saat; i++)
        {
            int mesafe = hiz * i;

            //ekrana yaz
            Console.WriteLine($"{i} saat sonunda gidilen mesafe {mesafe} km");

            //dosyaya yaz
            yaz.WriteLine($"{i} saat sonunda gidilen mesafe {mesafe} km");

            //  Thread.Sleep(1000); // Her çıktı için 1 sn bekle            
        }
        yaz.Close();
    }
}

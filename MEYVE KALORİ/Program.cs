using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEYVE_KALORİ
{
    class Program
    {
        static void Main(string[] args)
        {
            string girdi;
            bool durum = true;
            int toplamKalori = 0;
            while (durum)
            {
                Console.WriteLine("Hangi meyve: (A)rmut - (E)lma - (P)ortakal - (M)uz");
                Console.WriteLine("Çıkış için (X) ");
                girdi = Console.ReadLine();
                switch (girdi)
                {
                    case "A":
                        toplamKalori += 120;
                        break;
                    case "E":
                        toplamKalori += 80;
                        break;
                    case "P":
                        toplamKalori += 90;
                        break;
                    case "M":
                        toplamKalori += 115;
                        break;
                    case "X":
                        durum = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz Değer!");
                        break;
                }
                Console.WriteLine("Toplam Kalori: " + toplamKalori);
            }
            Console.WriteLine("Toplam Kalori: " + toplamKalori);
            Console.ReadKey();
        }
    }
}

using System.IO;
namespace TOPLAM_SATIŞLAR
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dosyaYolu = "Sales.txt";
            
            //Dosyanın varlığını kontrol et
            if (File.Exists(dosyaYolu))
            {
                try
                {
                    double eb = double.MinValue;
                    double ek = double.MaxValue;
                    string[] satisVerileri = File.ReadAllLines(dosyaYolu);
                    double toplamSatis = 0;

                    Console.WriteLine("Satış Miktarları");
                    foreach (string s in satisVerileri) 
                    { 
                        //her satış miktarını ekrana yazdır
                        Console.WriteLine(s + " TL");

                        if (double.Parse(s)> eb)
                        {
                            eb = double.Parse(s);
                        }
                        if (double.Parse(s) < ek)
                        {
                            ek = double.Parse(s);
                        }
                        //satışı toplam miktara ekle
                        toplamSatis += double.Parse(s);
                    }

                    //toplam satış miktarını ekrana yaz
                    Console.WriteLine($"Toplam Satış Miktarı: {toplamSatis:C2} TL");
                    Console.WriteLine($"EB: {eb:n2} TL");
                    Console.WriteLine($"EK: {ek:n2} TL");
                }
                catch (Exception ex)
                {
                    //Hata mesajını görüntüle
                    Console.WriteLine(ex.Message);    
                }
            }
            else 
            {
                Console.WriteLine("Dosya Bulunamadi");
            }
        }
    }
}

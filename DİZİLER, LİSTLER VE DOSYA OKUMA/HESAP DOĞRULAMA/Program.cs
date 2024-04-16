namespace HESAP_DOĞRULAMA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dosyaYolu = "ChargeAccounts.txt";
            // Hesap numaralarını saklayacak bir liste tanımlıyorum

            List<int> hesaplar = new List<int>();

            if (File.Exists(dosyaYolu)) //dosyaYolu var mı yok mu?
            {
                try
                {
                    string[] satirlar = File.ReadAllLines(dosyaYolu);
                    foreach (string s in satirlar)
                    {
                        hesaplar.Add(int.Parse(s));
                    }

                    Console.WriteLine("Lütfen bir hesap numarası giriniz: ");
                    int girilenNumara = int.Parse(Console.ReadLine());

                    if (hesaplar.Contains(girilenNumara))
                    {
                        Console.WriteLine("Girilen numara geçerlidir");
                    }
                    else
                    {
                        Console.WriteLine("Girilen numara geçerli değildir!");
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Dosya Bulunamadı");
            }
        }
    }
}

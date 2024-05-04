using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOBUS_SINIFI
{
    public class Otobus
    {
        public string SeferAdi { get; set; }
        public string SeferSaati { get; set; }
        public string Model { get; set; }
        private int _koltukSayisi;

        public int KoltukSayisi
        {
            get { return _koltukSayisi; }
            set
            {
                if (value < 45 || value > 50)
                    throw new ArgumentOutOfRangeException("KoltukSayisi", "KOLTUK SAYISI GEÇERLİ DEĞİL!");
                _koltukSayisi = value;
            }
        }

        public Otobus(string seferAdi, string seferSaati, string model, int koltukSayisi)
        {
            SeferAdi = seferAdi;
            SeferSaati = seferSaati;
            Model = model;
            KoltukSayisi = koltukSayisi; // set kullanılarak değer atanıyor
        }

        public override string ToString()
        {
            return $"Sefer Adı: {SeferAdi} - Sefer Saati: {SeferSaati} - Model: {Model} - Koltuk Sayısı: {KoltukSayisi}";
        }
    }

}

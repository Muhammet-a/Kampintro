using System;
using System.Collections.Generic;
using System.Text;

namespace Methotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi!:" + urun.Adi);
        }

        public void Ekle2(string urunAdi, String aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi!:" + urunAdi);
        }
    }
}

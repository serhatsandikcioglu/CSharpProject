using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama
{
    public class ÜçgenHesaplama
    {
        public void Çevre(double kenar1,double kenar2,double kenar3)
        {
            double sonuc = kenar1 + kenar2 + kenar3;
            Console.WriteLine("Üçgenin çevresi: " + sonuc);
        }
        public void Alan(double taban,double yükseklik)
        {
            double sonuc = taban * yükseklik / 2;
            Console.WriteLine("Üçgenin alanı: " + sonuc);
        }
        public void Hacim(double taban,double yükseklik)
        {
            double sonuc = taban * taban * yükseklik / 3;
            Console.WriteLine("Üçgenin hacmi: " + sonuc);
        }
    }
}

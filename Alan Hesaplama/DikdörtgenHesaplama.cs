using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama
{
    public class DikdörtgenHesaplama
    {
        public void Çevre(double kenar1,double kenar2)
        {
            double sonuc = kenar1 + kenar1 + kenar2 + kenar2;
            Console.WriteLine("Dikdörtgenin çevresi: " + sonuc);
        }
        public void Alan(double kenar1,double kenar2)
        {
            double sonuc = kenar1 * kenar2;
            Console.WriteLine("Dikdörgenin Alanı: " + sonuc);
        }
        public void Hacim(double kenar1,double kenar2,double yükseklik)
        {
            double sonuc = kenar1 * kenar2 * yükseklik;
            Console.WriteLine("Dikdörgenin hacmi: " + sonuc);
        }
    }
}

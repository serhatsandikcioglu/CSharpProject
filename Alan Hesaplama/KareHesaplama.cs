using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama
{
    public class KareHesaplama
    {
        public void Çevre(double kenar)
        {
            double sonuc = kenar * 4;
            Console.WriteLine("Karenin çevresi: " + sonuc);
        }
        public void Alan(double kenar)
        {
            double sonuc = kenar * kenar;
            Console.WriteLine("Karenin alanı: " + sonuc);
        }
        public void Hacim(double kenar)
        {
            double sonuc = kenar * kenar * kenar;
            Console.WriteLine("Karenin hacmi: " + sonuc);
        }
    }
}

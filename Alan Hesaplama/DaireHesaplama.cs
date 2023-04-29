using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama
{
    public class DaireHesaplama
    {
        public void Alan(double yarıcap)
        {
            double sonuc = 3.14 * yarıcap * yarıcap;
            Console.WriteLine("Dairenin alanı: " + sonuc);
        }
        public void Çevre(double yarıcap)
        {
            double sonuc = 2 * yarıcap * 3.14;
            Console.WriteLine("Dairenin çevresi: " + sonuc);
        }
        public void Hacim(double yarıcap, double yükseklik)
        {
            double sonuc = 3.14 * yarıcap * yarıcap * yükseklik;
            Console.WriteLine("Dairenin hacmi: " + sonuc);
        }
    }
}

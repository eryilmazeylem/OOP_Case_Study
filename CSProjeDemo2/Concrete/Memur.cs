using CSProjeDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Concrete
{
    public class Memur : Personel
    {
        private const int MAKS_CALSIMA_SAATI = 180;
        private const double EK_MESAI_KATSAYI = 1.5;
        private const double DEFAULT_SAATLIK_UCRET = 500;

        public Memur(string adSoyad, int calismaSaati, double saatlikUcret = DEFAULT_SAATLIK_UCRET)
            : base(adSoyad, "Memur", saatlikUcret, calismaSaati)
        {
        }

        public override double MaasHesapla()
        {
            int normalSaatler = Math.Min(CalismaSaati, MAKS_CALSIMA_SAATI);
            int ekMesaiSaatleri = Math.Max(0, CalismaSaati - MAKS_CALSIMA_SAATI);
            double ekMesaiUcreti = ekMesaiSaatleri * (SaatlikUcret * EK_MESAI_KATSAYI);

            return normalSaatler * SaatlikUcret + ekMesaiUcreti;
        }
    }
}

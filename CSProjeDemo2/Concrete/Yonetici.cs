using CSProjeDemo2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Concrete
{
    public class Yonetici : Personel
    {
        private const double MIN_SAATLIK_UCRET = 500;
        public double Bonus { get; set; }

        public Yonetici(string adSoyad, int calismaSaati, double saatlikUcret, double bonus)
            : base(adSoyad, "Yönetici", saatlikUcret >= MIN_SAATLIK_UCRET ? saatlikUcret : MIN_SAATLIK_UCRET, calismaSaati)
        {
            Bonus = bonus;
        }

        public override double MaasHesapla()
        {
            return SaatlikUcret * CalismaSaati + Bonus;
        }
    }
}

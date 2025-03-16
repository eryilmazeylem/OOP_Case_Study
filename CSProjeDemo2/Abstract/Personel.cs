namespace CSProjeDemo2.Abstract
{
    public abstract class Personel
    {
        public string AdSoyad { get; set; }
        public string Unvan { get; set; }
        public double SaatlikUcret { get; set; }
        public int CalismaSaati { get; set; }

        protected Personel(string adSoyad, string unvan, double saatlikUcret, int calismaSaati)
        {
            AdSoyad = adSoyad;
            Unvan = unvan;
            SaatlikUcret = saatlikUcret;
            CalismaSaati = calismaSaati;
        }

        public abstract double MaasHesapla();
    }
}

using CSProjeDemo1.Abstract;
using CSProjeDemo1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Concrete
{
    public class Kutuphane
    {
        public List<Kitap> Kitaplar { get; set; }
        public List<Uye> Uyeler { get; set; }

        public Kutuphane()
        {
            Kitaplar = new List<Kitap>();
            Uyeler = new List<Uye>();
        }

        public void KitapEkle(Kitap kitap)
        {
            Kitaplar.Add(kitap);
        }

        public void UyeEkle(Uye uye)
        {
            Uyeler.Add(uye);
        }

        public List<Kitap> MevcutKitaplariListele()
        {
            return Kitaplar.Where(k => k.KitapDurumu == Durum.OduncAlabilir).ToList();
        }

        public List<Kitap> OduncVerilenKitaplariListele()
        {
            return Kitaplar.Where(k => k.KitapDurumu == Durum.OduncVerildi).ToList();
        }

        public List<Uye> UyeleriListele()
        {
            return Uyeler;
        }

        public void KitapOduncVer(Uye uye, string isbn)
        {
            var kitap = Kitaplar.FirstOrDefault(k => k.ISBN == isbn);
            if (kitap != null && kitap.KitapDurumu == Durum.OduncAlabilir)
            {
                uye.KitapOduncAl(kitap);
            }
        }

        public void KitapIadeAl(Uye uye, string isbn)
        {
            var kitap = uye.OduncAlinanKitaplar.FirstOrDefault(k => k.ISBN == isbn);
            if (kitap != null)
            {
                uye.KitapIadeEt(kitap);
            }
        }

    }
}

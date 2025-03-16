using CSProjeDemo1.Abstract;
using CSProjeDemo1.Enum;
using CSProjeDemo1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Concrete
{
    public class Uye : IUye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int UyeNumarasi { get; set; }
        public List<Kitap> OduncAlinanKitaplar { get; set; }

        public Uye(string ad, string soyad, int uyeNumarasi)
        {
            Ad = ad;
            Soyad = soyad;
            UyeNumarasi = uyeNumarasi;
            OduncAlinanKitaplar = new List<Kitap>();
        }

        public void KitapOduncAl(Kitap kitap)
        {
            if (kitap.KitapDurumu == Durum.OduncAlabilir)
            {
                kitap.KitapDurumu = Durum.OduncVerildi;
                OduncAlinanKitaplar.Add(kitap);
            }
        }

        public void KitapIadeEt(Kitap kitap)
        {
            if (OduncAlinanKitaplar.Contains(kitap))
            {
                kitap.KitapDurumu = Durum.OduncAlabilir;
                OduncAlinanKitaplar.Remove(kitap);
            }
        }
    }
}

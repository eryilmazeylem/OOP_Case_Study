using CSProjeDemo1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Interface
{
    public interface IUye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int UyeNumarasi { get; set; }
        public List<Kitap> OduncAlinanKitaplar { get; set; }

        void KitapOduncAl(Kitap kitap);
        void KitapIadeEt(Kitap kitap);

    }

}

using CSProjeDemo1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Concrete
{
    public class KitapTarih : Kitap
    {
        public KitapTarih(string isbn, string baslik, string yazar, int yayinYili) : base(isbn, baslik, yazar, yayinYili)
        {

        }
    }
}

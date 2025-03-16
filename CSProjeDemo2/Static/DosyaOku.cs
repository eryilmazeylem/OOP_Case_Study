using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSProjeDemo2.Abstract;
using CSProjeDemo2.Concrete;
using Newtonsoft.Json;

namespace CSProjeDemo2.Static
{
    public static class DosyaOku
    {
        public static List<Personel> PersonelListesiOku(string dosyaYolu)
        {
            try
            {
                string jsonVeri = File.ReadAllText(dosyaYolu);
                var personelListesi = JsonConvert.DeserializeObject<List<dynamic>>(jsonVeri);
                List<Personel> personeller = new List<Personel>();

                foreach (var item in personelListesi)
                {
                    string adSoyad = item.name;
                    string unvan = item.title;

                    if (unvan == "Yonetici")
                        personeller.Add(new Yonetici(adSoyad, 160, 500, 2000));
                    else if (unvan == "Memur")
                        personeller.Add(new Memur(adSoyad, 170, 500));
                }

                return personeller;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dosya okuma hatası: " + ex.Message);
                return new List<Personel>();

            }
        }
    }
}

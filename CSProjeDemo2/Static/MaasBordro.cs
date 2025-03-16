using CSProjeDemo2.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Static
{
    public static class MaasBordro
    {
        public static void BordroOlustur(List<Personel> personeller)
        {
            foreach (var personel in personeller)
            {
                string klasorAdi = $"{personel.AdSoyad.Replace(" ", "_")}";
                Directory.CreateDirectory(klasorAdi);

                double toplamMaas = personel.MaasHesapla();

                var bordro = new
                {
                    PersonelIsmi = personel.AdSoyad,
                    personel.CalismaSaati,
                    AnaOdeme = toplamMaas,
                    ToplamOdeme = toplamMaas
                };

                string dosyaAdi = $"{klasorAdi}/Maas_Bordro_{DateTime.Now:yyyy_MM}.json";
                File.WriteAllText(dosyaAdi, JsonConvert.SerializeObject(bordro, Formatting.Indented));

                Console.WriteLine($"Bordro kaydedildi: {dosyaAdi}");
            }
        }
    }
}

using CSProjeDemo2.Abstract;
using CSProjeDemo2.Static;

string dosyaYolu = "personel.json"; // JSON dosya konumu
List<Personel> personeller = DosyaOku.PersonelListesiOku(dosyaYolu);

MaasBordro.BordroOlustur(personeller);

Console.WriteLine("Tüm maaş hesaplamaları tamamlandı!");
Console.WriteLine("150 saatten az çalışan personeller:");
foreach (var p in personeller)
{
    if (p.CalismaSaati < 150)
        Console.WriteLine($"- {p.AdSoyad}: {p.CalismaSaati} saat");
}

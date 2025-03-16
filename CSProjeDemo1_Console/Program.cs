using CSProjeDemo1.Concrete;

var kutuphane = new Kutuphane();

var kitap1 = new KitapBilim("123456", "Bilim Kitabı", "Ahmet Yılmaz", 2020);
var kitap2 = new KitapRoman("654321", "Roman Kitabı", "Mehmet Demir", 2018);

kutuphane.KitapEkle(kitap1);
kutuphane.KitapEkle(kitap2);

var uye = new Uye("Mehtap", "Kaya", 1);
kutuphane.UyeEkle(uye);

kutuphane.KitapOduncVer(uye, "123456");

kutuphane.KutuphaneDurumunuGoster();

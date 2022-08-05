//--------------Generic List---------------------


List<int> sayiListesi = new List<int>();

sayiListesi.Add(23);
sayiListesi.Add(43);
sayiListesi.Add(48);

List<string> renkListesi = new List<string>();

renkListesi.Add("kırmızı");
renkListesi.Add("mavi");
renkListesi.Add("yeşil");

int a = renkListesi.Count;
Console.WriteLine(a);

//----foreach ve List.ForEach ile elemanları ekrana yazdırma

foreach (var sayi in sayiListesi)
{
    Console.WriteLine(sayi);
}
foreach (var renk in renkListesi)
{
    Console.WriteLine(renk);
}

sayiListesi.ForEach(sayi => Console.WriteLine(sayi)); //foreach kısa kullanım hali => öyle ki anlamındadır
renkListesi.ForEach(renk => Console.WriteLine(renk));

//------Listeden Eleman Çıkarma--------------

sayiListesi.Remove(48);
renkListesi.Remove("yeşil");

sayiListesi.RemoveAt(0);

sayiListesi.ForEach(sayi => Console.WriteLine(sayi)); //foreach kısa kullanım hali => öyle ki anlamındadır
renkListesi.ForEach(renk => Console.WriteLine(renk));

//-----Liste İçerisinde Arama-----

if(sayiListesi.Contains(10))
{
    Console.WriteLine("bulundu");
}
else
Console.WriteLine("bulunamadı");

//-----Eleman ile İndexe Erişme---------

Console.WriteLine(renkListesi.BinarySearch("mavi"));

//----Diziyi List'e Çevirme---------

string[] hayvanlar = {"kedi" ,"köpek", "kuş"};

List<string> hayvanlistesi = new List<string>(hayvanlar);


//-----Listeyi Temizleme-------

hayvanlistesi.Clear();

//-------Listeye nesne atamak-----

public class kullanicilar
{
    private string isim;
    private string soyisim;
    private int yas;  //encapsule etmeyi yapamadım net6.0 da

    
}

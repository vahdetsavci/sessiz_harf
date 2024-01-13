using System;

namespace sessiz_harf;

class BL // Business layer
{
    DAL dal;
    string[] ifadeler;
    bool[] sonuclar;

    internal BL() { dal = new DAL(); }

    internal void VeriAl(string[] ifadeler)
    {
        this.ifadeler = ifadeler;
        sonuclar = new bool[ifadeler.Length];
    }

    internal void Duzenle()
    {
        for (int i = 0; i < ifadeler.Length; i++)
        {
            sonuclar[i] = Kontrol(ifadeler[i]);
        }
    }

    internal bool Sonuclandir()
    {
        Array.ForEach(sonuclar, sonuc => Console.Write(sonuc + " "));
        return Yeniden();
    }

    private bool Kontrol(string ifade)
    {
        char karakter; int x = 0, y = 0; // x = sessiz harf sayısı, y = tekrar sayısı
        for (int i = 0; i < ifade.Length; i++)
        {
            y++;
            karakter = ifade[i];
            x += dal.Kontrol(karakter) ? 1 : 0;
            
            if (x == 0)
                y = 0;
            if (y == 2 && x == 2) // Peş peşe iki sessiz harf bulunursa true return edilir.
                return true;
            else if (y == 2)
                { x = 0; y = 0; }
        }
        return false;
    }

    private bool Yeniden()
    {
        Baslangic:
        Console.WriteLine();
        Console.WriteLine("Yeni değer girmek ister misiniz? E: Evet / H: Hayır");
        Console.WriteLine("---------------------------------------------------");
        switch (Console.ReadLine().ToLower())
        {
            case "e":
                return true;
            case "h":
                return false;
            default:
                Console.WriteLine("Geçersiz seçim yaptınız! Lütfen sunulan seçeneklerin dışına çıkmayın");
                goto Baslangic;
        }
    }
}
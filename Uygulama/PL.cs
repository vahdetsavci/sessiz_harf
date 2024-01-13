using System;

namespace sessiz_harf;

class PL // Presentation Layer
{
    BL bl;
    internal PL() { bl = new BL(); }

    internal void VeriAl()
    {
        Console.WriteLine();
        Console.WriteLine("Değer giriniz!");
        Console.WriteLine("---------------------------------------------------");
        bl.VeriAl(Console.ReadLine().ToLower().Split(' '));
    }

    internal void Duzenle() { bl.Duzenle(); }

    internal bool Sonuclandir() { return bl.Sonuclandir(); }
}
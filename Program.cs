using System;
using System.Linq;

namespace sessiz_harf;

class Program
{
    static void Main(string[] args)
    {
        Baslangic:
        PL pL = new PL();
        pL.VeriAl();
        pL.Duzenle();

        if (pL.Sonuclandir())
            goto Baslangic;
    }
}

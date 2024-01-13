using System.Linq;

namespace sessiz_harf;

class DAL // Data Access Layer
{
    char[] chars; // Sessiz harfler için

    internal DAL()
    {
        chars = ['b', 'c', 'ç', 'd', 'f', 'g', 'ğ', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 'ş', 't', 'v', 'y', 'z'];
    }

    internal bool Kontrol(char karakter)
    {
        return chars.Contains(karakter);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Pazar);
            Console.WriteLine((int)HavaDurumu.CokSicak);
            Console.WriteLine(HavaDurumu.CokSicak);

            Console.ReadLine();
        }
    }
    enum Gunler
    {
        Pazartesi=1,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 15,
        Sicak =25,
        CokSicak=40
    }
}

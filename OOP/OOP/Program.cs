using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hayvanlar kus = new Hayvanlar("Maymun","Memeli","Siyah",5);
            kus.hayvanBilgileriGetir();
            Console.WriteLine(kus.Beslenme("Ot"));//Kalıtım yapıldığı için hayvanı çağırınca üst sınıfındaki özellikleride çağırabiliriz.
            Console.WriteLine(kus.Hareket("Uçar"));
            kus.Reflex("iyi");// Polymorphism ile üst sınıfta oluşturulan virtual metodun biçimini değiştirebiliriz


            Console.WriteLine("\n\n\n");

            Bitkiler lale = new Bitkiler("Lale", "Çiçek", "Beyaz", 1);
            lale.bitkiBilgileriniGetir();
            Console.WriteLine(lale.Beslenme("Fotosentez")); 
            Console.WriteLine( lale.Hareket("Pasif Hareket"));
            lale.Reflex("kötü");// Polymorphism ile üst sınıfta oluşturulan virtual metodun biçimini değiştirebiliriz


            Console.ReadLine();
        }
    }
    

    
}

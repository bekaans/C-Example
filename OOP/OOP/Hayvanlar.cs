using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Hayvanlar:Canlilar // : ile kalıtım yapılır kalıtım yapılan sınıfın özelliklerini direkt çekebiliriz .
    {
        String ad;
        String tur;
        String renk;
        int yas;
        public Hayvanlar(string ad, string tur, string renk, int yas)
        {
            this.ad = ad;
            this.tur = tur;
            this.renk = renk;
            this.yas = yas;
           
        }
        public void hayvanBilgileriGetir()
        {
            Console.WriteLine("Hayvan İsmi :" +this.ad);
            Console.WriteLine("-----------------------------");
        }

        
        public override String Reflex(String x)// Polymorphism ile üst sınıfta oluşturulan virtual metodun biçimini değiştirebiliriz
        { Console.WriteLine("Hayvanların Reflexi : "+x);
            return x;
           
        }
    }
}

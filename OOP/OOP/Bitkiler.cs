using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Bitkiler:Canlilar // : ile kalıtım yapılır ve kalıtım yapılan sınıfın özelliklerini direkt çekebiliriz
    {
        String ad;
        String tur;
        String renk;
        int yas;
        public Bitkiler(string ad, string tur, string renk, int yas)
        {
            this.ad = ad;
            this.tur = tur;
            this.renk = renk;
            this.yas = yas;
           
        }

        public void bitkiBilgileriniGetir()
        {
            Console.WriteLine("Bitkinin Adı : "+this.ad);
            Console.WriteLine("-----------------------------");
        }
        public override String Reflex(String x) // Polymorphism ile üst sınıfta oluşturulan virtual metodun biçimini değiştirebiliriz
        {

            Console.WriteLine("Bitkilerin reflexi : "+x);
            return x;
           
        }
    }
}

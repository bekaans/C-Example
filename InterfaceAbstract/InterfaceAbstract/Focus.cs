using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract
{
    internal class Focus : IOtomobil
    {
        public Sabitler.Marka Marka()
        {
            return Sabitler.Marka.Ford;
        }

        public Sabitler.StandartRenk StandartRenk()
        {
            return Sabitler.StandartRenk.Beyaz;
        }

        public int TekerSayisi()
        {
            return 4;
        }
        public void arabaBilgileriniGetir()
        {
            Console.WriteLine("Marka :"+Marka());
            Console.WriteLine("Standart renk :"+StandartRenk());
            Console.WriteLine("Teker Sayısı :"+TekerSayisi());
        }
    }
}

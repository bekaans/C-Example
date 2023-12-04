using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract
{
    internal class Civic : IOtomobil
    {

        public Sabitler.Marka Marka()
        {
            return Sabitler.Marka.Honda;
}
        public Sabitler.StandartRenk StandartRenk()
        {
            return Sabitler.StandartRenk.Gri;
        }
        public int TekerSayisi()
        {
            return 4;
        }
        public void arabaBilgileriniGetir()
        {
            Console.WriteLine("Marka :" + Marka());
            Console.WriteLine("Standart renk :" + StandartRenk());
            Console.WriteLine("Teker Sayısı :" + TekerSayisi());
        }
    }
}

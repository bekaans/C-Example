using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract
{
    internal class NewCivic : Otomobil
    {
        public override Sabitler.Marka Marka()
        {
            return Sabitler.Marka.Honda;
        }
        public void arabaBilgileriniGetir()
        {
            Console.WriteLine("Marka :" + Marka());
            Console.WriteLine("Standart renk :" + StandartRenk());
            Console.WriteLine("Teker Sayısı :" + TekerSayisi());
        }

    }
}

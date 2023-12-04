using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract
{
    internal class NewCorolla:Otomobil
    {
        public override Sabitler.Marka Marka()
        {
            return Sabitler.Marka.Toyota;
        }
        public override Sabitler.StandartRenk StandartRenk()
        {
            return Sabitler.StandartRenk.Gri;
        }
        public void arabaBilgileriniGetir()
        {
            Console.WriteLine("Marka :" + Marka());
            Console.WriteLine("Standart renk :" + StandartRenk());
            Console.WriteLine("Teker Sayısı :" + TekerSayisi());
        }
    }
}

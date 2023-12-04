using static InterfaceAbstract.Sabitler;

namespace InterfaceAbstract
{
    abstract class Otomobil
    {
        public int TekerSayisi()
        {
            return 4;
        }
        public virtual StandartRenk StandartRenk()
        {
            return Sabitler.StandartRenk.Beyaz;
        }
        public abstract Marka Marka();
       

    }
}

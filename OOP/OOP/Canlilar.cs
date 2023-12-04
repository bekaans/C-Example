using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Canlilar
    {
        
        public String Beslenme(String x)    //Kalıtım yapıldığı için canlı nesnesi oluşturmadan direkt canlı özelliklerini çekebiliyoruz
        {
            Console.Write("Beslenme Türü : ");
            return x;
        }
        public String Hareket(String x) //Kalıtım yapıldığı için canlı nesnesi oluşturmadan direkt canlı özelliklerini çekebiliyoruz
        {
            Console.Write("Hareket Türü : ");
            return x;
        }
        public virtual String Reflex(String x)
        {
            return x;
        }

    }
}

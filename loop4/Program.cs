using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kuptoplam = 0;
            int kare;
            int toplam=0;
            int sayilar;
            int kup=1;

            for (int i = 1;i<=5; i++)
            {
                Console.Write(i+". sayıyı gir :");
                sayilar = Convert.ToInt32(Console.ReadLine());

                if (sayilar % 2 == 0)
                {
                    kare = sayilar * sayilar;
                    toplam = +kare;
                }
                if(sayilar %2 !=0)
                {
                 kup = sayilar*sayilar*sayilar;
                    kuptoplam += kup;
                }
           
            }    Console.WriteLine("Çift Sayıların Toplamı :"+toplam);
                Console.WriteLine("Tek Sayıların Toplamı :" + kuptoplam);











            Console.ReadLine();
        }
    }
}

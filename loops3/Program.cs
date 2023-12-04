using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops3
{
    internal class Program
    {
        static void Main(string[] args)
        {   int toplam = 0;
            int sayilar=0;
            int adet=0;

            for (int i = 1; i <= 10; i++)
            {

                Console.Write(i+". Sayıyı Giriniz :");
                sayilar=Convert.ToInt32(Console.ReadLine());


                if (sayilar > 99 && sayilar<1000) 
                {
                    adet++;

                }
                if (sayilar < 100)
                {
                    toplam += sayilar;

                }
            }

            Console.WriteLine("Üç Basamaklı Sayıların Adedi :"+adet);
            Console.WriteLine("Üç Basamaklı Olmayan Sayıların Toplamı :" + toplam);



            Console.ReadLine();
        }
    }
}

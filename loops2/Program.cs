using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bölen sayısını giriniz :");
                int bolen = Convert.ToInt32(Console.ReadLine());
            int adet = 0;

          for (int i = 75;i<300;i++)
            {

               if(i%bolen == 0)
                {
                    adet++; 
                    Console.WriteLine(bolen+" sayisi "+i+" sayisini boler.");
                }
            }
            Console.WriteLine("BÖLEN ADEDİ :"+adet);
            Console.ReadLine();
        
         



        }
    }
}

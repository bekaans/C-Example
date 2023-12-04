using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciOrt
{
    internal class Fibonacci
    {
        public void FibOrt()
        {
            int fibrakam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------");

            int a = 1;
            int b = 1;
            int c;

            Console.WriteLine(a); 
            Console.WriteLine(b); 

            for (int i = 1; i <= fibrakam-2; i++) 
           
            {
                c = a + b;
                a = b;
                b = c;
                double sonuc = a + b +c ;

                 Console.WriteLine(c);
                if (i == fibrakam-2)
                {

               
                    double ort = (sonuc - 1) / fibrakam;
                    Console.WriteLine("Avarage is :"+ort);
                }
              
               
        
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcgenProgram
{
    internal class Ucgen
    {

        public void UcgenOlustur()
        { Console.WriteLine("Üçgen boyutunu giriniz :");
            int boyut = Convert.ToInt32(Console.ReadLine());

          
            {
                Console.Write("*");
            }
            for (int i = 0; i <= boyut; i++)
            {

                Console.WriteLine();

                for (int j = boyut; j > i; j--)
                {
                 
                    Console.Write(" ");
                    
                  
                }for (int k = 0; k <= i; k++)
                {
                    
                    Console.Write("**");
                }
            }


        }
    }
}

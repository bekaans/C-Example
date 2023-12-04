using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpimtablosu
{
    internal class Program
    {
        static void Main(string[] args)
        { int i;
            int rakam;
            int j;
            Console.WriteLine("Rakam :");
            rakam=Convert.ToInt32(Console.ReadLine());

            for(i=1; i <= rakam+1; i++)
            {
                for(j=1; j <= rakam+1; j++)
                {   
                    Console.WriteLine(i+"X"+j+"="+i*j);

                }              
            }

            Console.ReadLine();

        }
    }
}

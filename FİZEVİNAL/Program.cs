using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FİZEVİNAL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int vize;
            int final;

            Console.WriteLine("Vize Notunuzu Giriniz :");
            vize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final Notunuzu Giriniz");
            final = Convert.ToInt32(Console.ReadLine());

            if (vize >= 50 && final >= 70)
            {
                Console.WriteLine("İyi");
            }
            else
            {
                Console.WriteLine("Kötü");
            }

                                            Console.ReadLine();
        }
    }
}

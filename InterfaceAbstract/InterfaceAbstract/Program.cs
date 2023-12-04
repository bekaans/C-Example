using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            focus.arabaBilgileriniGetir();
            Console.WriteLine("------------------------------");
            Civic civic = new Civic();
            civic.arabaBilgileriniGetir();
            Console.WriteLine("-------------------------------");
            Corolla corolla = new Corolla();
            corolla.arabaBilgileriniGetir();
            Console.WriteLine("-------------------------------");
            NewCivic newCivic = new NewCivic();
            newCivic.arabaBilgileriniGetir();
            Console.WriteLine("-------------------------------");
            NewCorolla newCorolla = new NewCorolla();  
            newCorolla. arabaBilgileriniGetir();
            Console.WriteLine("-------------------------------");
            NewFocus newFocus = new NewFocus();
            newFocus.arabaBilgileriniGetir();

            Console.ReadLine();
        }
    }
}

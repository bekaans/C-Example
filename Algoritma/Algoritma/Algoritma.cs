using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma
{
    internal class Algoritma
    {
        public void alg()
        {
            Console.WriteLine("Enter The [String],[int]");
          
           
             string a = Console.ReadLine();
             string b = Console.ReadLine();
            
            List<string> list = new List<string>();
            list.Add(a);
            list.Add(b);
            list.Remove(b);
            foreach (string s in list) 
            Console.WriteLine(s);
    
            Console.ReadKey();
        }
    }
}

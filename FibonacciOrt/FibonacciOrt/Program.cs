using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciOrt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Number : " );
            Fibonacci fibonacci = new Fibonacci();
            fibonacci.FibOrt();

            Console.ReadLine();
        }
    }
}

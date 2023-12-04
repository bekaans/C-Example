using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class Circle
    { 
        public void makeCircle()
        
        {       
            Console.WriteLine("Draw Circle App");
                Console.WriteLine("Enter The r :" );
                int  radius = int.Parse(Console.ReadLine());

            for (double y = -radius; y <= radius; y++)
            {
                for (double x = -radius; x <= radius; x += 0.5)
                {
                    if ((x * x) + (y * y) >= radius * radius)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}

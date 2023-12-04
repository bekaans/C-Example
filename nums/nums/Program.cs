using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class MainClass
{

    public static string CheckNums(int num1, int num2)
    {
    

        // code goes here  
        if (num2 > num1)
        {

            return "true";
        }
        else if (num1 > num2)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("-1");
        }

       
    }

    static void Main()
    {

        // keep this function call here

        Console.WriteLine(CheckNums(Console.ReadLine()));

    }

}
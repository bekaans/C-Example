using System;

internal class MainClassBase
{

    public static int CheckNums(int num1, int num2)
    {

        // code goes here  
        if (num2 > num1)
        {
            Console.WriteLine("true");
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
}
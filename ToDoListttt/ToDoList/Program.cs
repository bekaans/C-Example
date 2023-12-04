using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean select = true;
            Console.WriteLine("Welcome To The [To Do List] . Please choose : ");
            while (select)
            {
               CardMethod card = new CardMethod();
              
                
                Console.WriteLine("1-Add Card\n2-Update Card\n3-Delete Card\n4-Move Card\n5-List Board\n6-Exit");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1: card.AddCardd();
                        break;

                    case 2: card.Update();
                        break;


                    case 3: card.Delete();
                        break;


                    case 4: card.List();
                        break;


                    case 5:
                        break;


                    case 6: select = false;
                        break;



                        default: Console.WriteLine("Wrong Chooice");
                        break;
                }


                Console.ReadLine();
            }

            
        }
    }
}

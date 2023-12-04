using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryApplication
{
    internal class Program
    {
        static void Main(string[] args)
        { Methods methods = new Methods();
           Boolean program = true;
            Console.WriteLine("Welcome to the Directory , Please Choose a Catagory ..");
            while (program==true)
            {
               
                List<User> Person =new List<User>();
                Person.Add(new User("Berke", "Kaan", "544658256"));
                Person.Add(new User("Can", "Atay", "546829632"));
                Person.Add(new User("Necmettin", "Kalın", "84851513135"));
                Person.Add(new User("Fehmi", "Özsoy", "48646156161"));
                Person.Add(new User("Hakan", "Palu", "61651564564"));


                Console.WriteLine("--------Menu----------");
               
                Console.WriteLine("1-Add New Contact\n2-Update Contact\n3-Delete Contact\n4-List Contact\n5-Exit");
                int select = Convert.ToInt32(Console.ReadLine());
              
                switch (select)
                {
                    case 1: methods.addNewContact();     
                        break;


                    case 2:
                        methods.UpdateContact();
                        break;

                    case 3:
                        methods.DeleteContact();
                        break;

                    case 4:
                        methods.ListContact();
                       
                        break;

                    case 5: program = false;
                        break;

                    default: Console.WriteLine("Wrong choose");
                        break;

                }



                
            }

        }



    }
}
    


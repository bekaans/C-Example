using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryApplication
{
    internal class Methods
    {
       
        List<User> Person = new List<User>();
        public Methods()
        {
            Person.Add(new User("Berke", "Kaan", "544658256"));
            Person.Add(new User("Can", "Atay", "546829632"));
            Person.Add(new User("Necmettin", "Kalın", "84851513135"));
            Person.Add(new User("Fehmi", "Özsoy", "48646156161"));
            Person.Add(new User("Hakan", "Palu", "61651564564"));
        }
       
        public void addNewContact()
        {

            Console.WriteLine("Enter the Contact name :");
            string namee = Console.ReadLine();
            Console.WriteLine("Enter the Contact surname :");
            string surnamee = Console.ReadLine();
            Console.WriteLine("Enter the Contact Telno :");
            string telnoe = Console.ReadLine();

            User users = new User(namee, surnamee, telnoe);
            Person.Add(users);
            Console.WriteLine("Saving..");
            Console.ReadLine();
           
            
        }
        public void ListContact()
        {
            foreach(var list in Person)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Name :"+list.name);
            
                Console.WriteLine("Surname :"+list.surname);
               
                Console.WriteLine("Tel No :"+list.telno);
                Console.WriteLine("-------------------------------");


            }
            
        }public void UpdateContact()
        {
            Console.WriteLine("Enter the Name and Surname");
            string nameandsurname = Console.ReadLine(); 
            for(int i = 0; i < Person.Count; i++)
            {
                if(Person[i].name.Equals(nameandsurname)|| Person[i].surname.Equals(nameandsurname))
                {
                    Console.WriteLine("Enter the New Informations :");
                    Console.WriteLine("New Name :");
                    string newname= Console.ReadLine();
                    Person[i].setName(newname);
                    Console.WriteLine("New Surname :");
                    string newsurname = Console.ReadLine();
                    Person[i].setSurname(newsurname);
                    Console.WriteLine("New Tel No :");
                    string newtel = Console.ReadLine();
                    Person[i].setTelno(newtel);
                    Console.WriteLine("Informations changed...");
                    
                }
            }
        }public void DeleteContact()
        {
            Console.WriteLine("Enter the Name :");
            string deletename= Console.ReadLine();
            for (int i = 0;i < Person.Count;i++)
            {

                if (Person[i].name.Equals(deletename))
                {
                    Person.Remove(Person[i]);
                    Console.WriteLine("Contact has been deleted ...");
                }
            }
        }
    }
}

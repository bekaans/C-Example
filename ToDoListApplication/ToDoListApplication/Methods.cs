using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApplication
{
    internal class Methods
    {
        List<Card> ToDo = new List<Card>();
        List<Card> Proggress = new List<Card>();
        List<Card> Done = new List<Card>();
        public Methods()
        {
            ToDo.Add(new Card("Ben", "Sen", "O"));
            ToDo.Add(new Card("Biz", "Siz", "Onlar"));
            ToDo.Add(new Card("Nereye", "Neden", "Nasıl"));
        }
        public void ListBoard()
        {
            Console.WriteLine("-----------ToDo Line----------");
            foreach (var todolist in ToDo)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Baslik : " + todolist.baslik);
                Console.WriteLine();
                Console.WriteLine("Icereik : " + todolist.icerik);
                Console.WriteLine();
                Console.WriteLine("Atanan Kisi : " + todolist.atananKisi);
                Console.WriteLine("------------------------------");
            }
            Console.WriteLine("-----------In Progress Line----------");
            foreach (var progresslist in Proggress)
            {
                Console.WriteLine("Baslik : " + progresslist.baslik);
                Console.WriteLine("Icereik : " + progresslist.icerik);
                Console.WriteLine("Atanan Kisi : " + progresslist.atananKisi);
            }
            Console.WriteLine("-----------Done Line----------");
            foreach (var donelist in Proggress)
            {
                Console.WriteLine("Baslik : "+donelist.baslik);
                Console.WriteLine("Icereik : "+donelist.icerik);
                Console.WriteLine("Atanan Kisi : "+donelist.atananKisi);
            }
        }
        public void Delete()
        {   Header:
            
            Console.WriteLine("Delete From Where ?\n1-To Do Board\n2-In Progress Board\n3-Done Board");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose ==1) { 
            
             Console.WriteLine("Enter The Baslik :");
            string deletebaslik = Console.ReadLine();

            for (int i = 0; i < ToDo.Count; i++)
            {
                if (ToDo[i].baslik.Equals(deletebaslik))
                {
                    ToDo.Remove(ToDo[i]);
                    Console.WriteLine("Card has been deleted...");
                }
            
            }
           
            }
            else if (choose ==2) 
            {

                Console.WriteLine("Enter The Baslik :");
                string deletebaslik = Console.ReadLine();

                for (int i = 0; i < ToDo.Count; i++)
                {
                    if (Proggress[i].baslik.Equals(deletebaslik))
                    {
                        Proggress.Remove(ToDo[i]);
                        Console.WriteLine("Card has been deleted...");
                    }

                }
            }
            else if (choose ==3)
            {

                Console.WriteLine("Enter The Baslik :");
                string deletebaslik = Console.ReadLine();
                for (int i = 0; i < ToDo.Count; i++)
                {
                    if (Done[i].baslik.Equals(deletebaslik))
                    {
                        Done.Remove(ToDo[i]);
                        Console.WriteLine("Card has been deleted...");
                    }

                }
            }
            else
            {
                Console.WriteLine("Wrong Chooice . Please try again..");
                goto Header;
            }
        }
        public void AddCardd()
        {
       

            Console.WriteLine("Enter The Baslik :");
            string baslikk = Console.ReadLine();

            Console.WriteLine("Enter The Icerik :");
            string icerikk = Console.ReadLine();

            Console.WriteLine("Enter The Atanan Kisi :");
            string atanankisii = Console.ReadLine();

            Card card = new Card(baslikk,icerikk,atanankisii);
            ToDo.Add(card);
            
        }
        public void Update()
        {
            Console.WriteLine("Enter The Baslik For Update");
            string baslikk = Console.ReadLine();
            for (int i = 0; i < ToDo.Count; i++)
            {
                if (ToDo[i].baslik.Equals(baslikk))
                {
                    Console.WriteLine("1-Baslik\n2-İcerik\n3-Atanan Kisi");
                    int choose = Convert.ToInt32(Console.ReadLine());
                    if (choose == 1)
                    {
                        Console.WriteLine("Enter The New Baslik :");
                        string newbaslik = Console.ReadLine();
                        ToDo[i].setBaslik(newbaslik);
                        Console.WriteLine("New Baslik :" + newbaslik);
                    }
                    else if (choose == 2)
                    {
                        Console.WriteLine("Enter The New Icerik :");
                        string newicerik = Console.ReadLine();
                        ToDo[i].setIcerik(newicerik);
                        Console.WriteLine("New Icerik :" + newicerik);
                    }
                    else if (choose == 3)
                    {
                        Console.WriteLine("Enter The New Atanan Kisi :");
                        string newatanan = Console.ReadLine();
                        ToDo[i].setAtananKisi(newatanan);
                        Console.WriteLine("New Atanan Kisi :" + newatanan);
                    }
                }
            }
        }
    }
}

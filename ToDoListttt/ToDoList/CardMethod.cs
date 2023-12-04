using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class CardMethod
    {
        
        List<Cards> ToDo = new List<Cards>();
       
      


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
        public void Delete()
        {
            Console.WriteLine("Enter The Baslik :");
            string deletebaslik = Console.ReadLine();

            for (int i = 0; i < ToDo.Count; i++)
            {
                if (ToDo[i].baslik.Equals(deletebaslik))
                {


                    ToDo.Remove(ToDo[i]);
                    Console.WriteLine("Contact has been deleted...");
              
                }
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

           Cards card = new Cards(baslikk,icerikk,atanankisii);
            ToDo.Add(card);
            Console.WriteLine("New Cards Added...");
        }

        public void List()
        {
            foreach (var listed in ToDo)
            {
                Console.WriteLine("Baslik :"+listed.baslik);
                Console.WriteLine("Icerik :"+listed.icerik);
                Console.WriteLine("Atanan Kisi :"+listed.atananKisi);
            }
        }
    }
    
}

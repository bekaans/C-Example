using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndGenericList
{
    internal class Program
    {
    

        static void Main(string[] args)
        {
            
           
            //List <T> class
            //System.Collections.Generic
            // T- Object veri türündedir.
            List<int> sayilar  = new List<int>();
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            sayilar.Add(4);
            sayilar.Add(5);
            sayilar.Add(6);
            sayilar.Remove(5); // Listeden Eleman Çıkarma
            Console.WriteLine(sayilar.Count+" Elemanlı");
         
            sayilar.ForEach(sayi => Console.WriteLine(sayi)); // Foreach ile elemanları yazdırma
            if(sayilar.Contains(4))
                Console.WriteLine("4 Bulundu");
            Console.ReadLine();


            List<string> yazilar = new List<string>();
            yazilar.Add("a");
            yazilar.Add("Berke");
            yazilar.Add("c");
            yazilar.Add("d");
            yazilar.Remove("d"); // Listeden eleman çıkarma
           

            Console.WriteLine(yazilar.Count+" Elemanlı"); // Count - Belirtilen sınıftaki eleman sayısını
           
                yazilar.ForEach(yazi => Console.WriteLine(yazi)); // Foreach ile elemanları yazdırma.
            if (yazilar.Contains("Berke")) // Listede eleman arama
            Console.WriteLine("Berke Bulundu ...");
            Console.ReadLine();


            string[] hayvanlar = new string[5] { "Kuş", "İncik", "Boncuk", "Ceylan", "Kazma" }; 
            List<string> hayvanList = new List<string>(hayvanlar);  // Diziyi Listeye Çevirme
            hayvanList.Add("Anka Kuşu");
            hayvanList.Remove("Kuş");
            hayvanList.ForEach(hayvan => Console.WriteLine(hayvan));
            Console.ReadLine();

            List<Kullanici> Rehber = new List<Kullanici>();
            
            Console.WriteLine("İsim :");
            string name=Console.ReadLine();
            Console.WriteLine("Soyisim :");
            string surname = Console.ReadLine();
            Console.WriteLine("Tel no :");
         
            string telno = Console.ReadLine(); ;
            Kullanici kullanici = new Kullanici(name,surname,telno);
            Rehber.Add(kullanici);
          

          
           
           // foreach(var kullanicilar in Rehber)
            {
                //Console.WriteLine(kullanicilar.name);
                //Console.WriteLine(kullanicilar.surname);
                //Console.WriteLine(kullanicilar.telno);

            }
               

            Console.ReadLine();

            ArrayList liste = new ArrayList();
            List<int> sayilarr = new List<int>() { 21,1, 24, 3, 4, 5, 6, 7 };

            liste.AddRange(sayilarr);
                liste.Sort(); //Küçükten büğüye
            liste.Reverse();//Büyükten küçüğe
            foreach(int i in liste)
                Console.WriteLine(i);


            ArrayList liste1 = new ArrayList();
            List<string> yazilr = new List<string>() { "Berke", "Kaan", "Sarac", "Ayhan", "Ayten", "Maviye", "Zeynep"};
            liste1.AddRange(yazilr);

            liste1.Sort(); // String için A 'dan Z ' ye
            foreach(string ib in liste1)
                Console.WriteLine(ib);

            Console.ReadLine() ;

        }
      
       

     

        
    }
}

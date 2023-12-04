using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            string[] dizi = new string[3] { "Berke", "Kaan", "Saraç" };
            Console.WriteLine(dizi[0]);
           
            
            string[] dizi1;
            dizi1 = new string[3];
            dizi1[0] = "Bekre";
  //Döngülerle Dizi Kullanımı

            int diziUzunlugu;
            Console.WriteLine("Kaç Sayının Ortalaması Alınacak ? :");
            diziUzunlugu = int.Parse(Console.ReadLine());
            int[] ortalama = new int[diziUzunlugu];
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write(i + 1 + ". Sayıyı Giriniz :");
                ortalama[i]=int.Parse(Console.ReadLine());

            }
            int toplam = 0;
            foreach (int sayi in ortalama)
            
                toplam += sayi;
                Console.WriteLine("Sayıların ortalaması :"+toplam/diziUzunlugu);
            */
            
            
           

            //ArrayList
            //Sort = Sıralama 

           
                    //Array Komutları


            int[] sortdizi = { 8, 5, 26, 14, 85, 54, 65 };

    
                    //Sırasız Dizi
            Console.WriteLine("Sırasız Dizi");
            foreach (int sayi in sortdizi)
            Console.WriteLine(sayi);
           
            Console.ReadLine();


                  
            //Sıralı Dizi

            Console.WriteLine("Sıralı Dizi");
            Array.Sort(sortdizi);
            foreach(int sayi1 in sortdizi)
            Console.WriteLine(sayi1);
            Console.ReadLine();


            //Clear Komutu
            Console.WriteLine("Clear Kpmutu");
            Array.Clear(sortdizi, 2, 1); // 2. indexten başlanıp 1 değer silinecek
            foreach(int sayi2 in sortdizi)
                Console.WriteLine(sayi2);
            Console.ReadLine();


            //Reverse
            Console.WriteLine("Reverse Komutu");
            Array.Reverse(sortdizi);
            foreach(int sayi3 in sortdizi)
             Console.WriteLine(sayi3);
            Console.ReadLine();


            //IndexOf Komutu
            Console.WriteLine("IndexOf Komutu");
            Console.WriteLine(Array.IndexOf(sortdizi,5)); // 5 sayısı dizinin kaçıncı indexinde
            Console.ReadLine();

            //Resize Komutu
            Console.WriteLine("Resize Komutu");
            Array.Resize<int>(ref sortdizi, 8); // 7 elemanlı arrayi 8 elemanlı arraye çevir
            sortdizi[7] = 88;  // 7. indexi yani 8. eleman
            foreach(int sayi5 in sortdizi)
                Console.WriteLine(sayi5);
            Console.ReadLine();

        }
    }
}

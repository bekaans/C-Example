using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Ogrenci ogrenci1 = new Ogrenci("Berke Kaan","Saraç",389,12);
            ogrenci1.OgrenciSoyad = "bbb";
            ogrenci1.ogrenciBilgileriniGetir();
            
            
            
            
            
            
            
            
            
            
            
            Console.ReadLine();
        }
    }

    class Ogrenci
    {
        private String ogrenciAdi;
        private String ogrenciSoyad;
        private int ogrenciNo;
        private int sinif;


        public Ogrenci(string ogrenciAdi, string ogrenciSoyad, int ogrenciNo, int sinif)
        {
            this.ogrenciAdi = ogrenciAdi;
            this.ogrenciSoyad = ogrenciSoyad;
            this.ogrenciNo = ogrenciNo;
            this.sinif = sinif;
        }
       
        //2 Parametreli Constructor
        public Ogrenci(string ogrenciAdi,string ogrenciSoyad)
        {
            this.ogrenciAdi= ogrenciAdi;
            this.ogrenciSoyad= ogrenciSoyad;
        }

        //Boş Constructor
        public Ogrenci() { }
        public String OgrenciAdi
        {
            get { return ogrenciAdi; }
            set { ogrenciAdi = value; }
        }
        public String OgrenciSoyad
        {
            get { return ogrenciSoyad;}
            set {  ogrenciSoyad = value; }
        }
        public int OgrenciNo
        { 
            get { return ogrenciNo; } 
            set { ogrenciNo = value; } 
        }
        public int Sinif
        {
            get { return sinif; }
            set { sinif = value; }
        }
        public void ogrenciBilgileriniGetir()
        {
            Console.WriteLine("Ogrenci Adi : "+this.ogrenciAdi);
            Console.WriteLine("Ogrenci Soyad : " + this.ogrenciSoyad);
            Console.WriteLine("Ogrenci No :" + this.ogrenciNo);
            Console.WriteLine("Ogrenci Sinif : " + this.sinif);
          
        }

        
       
       
    } 
}

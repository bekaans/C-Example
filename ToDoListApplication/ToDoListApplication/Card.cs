using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApplication
{
    internal class Card
    {
        public string baslik;
        public string icerik;
        public string atananKisi;


        public Card(string baslik, string icerik, string atananKisi)
        {
            this.baslik = baslik;
            this.icerik = icerik;
            this.atananKisi = atananKisi;

        }
        public string getBaslik()
        {
            return baslik;
        }
        public void setBaslik(string baslik)
        {
            this.baslik = baslik;
        }
        public string getICerik()
        {
            return icerik;
        }
        public void setIcerik(String icerik)
        {
            this.icerik = icerik;
        }

        public string getAtananKisi()
        {
            return atananKisi;
        }
        public void setAtananKisi(string atananKisi)
        {
            this.atananKisi = atananKisi;
        }
    }
}

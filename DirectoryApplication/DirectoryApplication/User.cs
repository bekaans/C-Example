using DirectoryApplication;
using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryApplication
{
    public class User
    {
        public string name;
        public string surname;
        public string telno;
     


        public User(string name, string surname, string telno)
        {
            this.name = name;
            this.surname = surname;
            this.telno = telno;
        }

        public User()
        {
        }

        public string getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public string getSurname()
        {
            return surname;
        }
        public void setSurname(String surname)
        {
            this.surname = surname;
        }
        public string getTelno()
        {
            return telno;
        }
        public void setTelno(String telno)
        {
            this.telno = telno;
        }
      
       
    }

}


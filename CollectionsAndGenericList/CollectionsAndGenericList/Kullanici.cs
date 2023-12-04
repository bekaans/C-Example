using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndGenericList
{
    class Kullanici
    {
        public String name;
        public String surname;
        public string telno;

      
     public Kullanici(String name,String surname,string telno)
        {
            this.name = name;
            this.surname = surname;
            this.telno = telno;
        }
        public String getName
        {
            get { return name; }
        }
        public String getSurname()
        {
            return surname;
        }
        public string getTelno()
        {
            return telno;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public void setSurname(String surname){
            this.surname = surname;
        }
        public void setTelno(string telno)
        {
            this.telno = telno;

        }
      
      
    }

   
    
}

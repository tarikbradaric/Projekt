using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Person
    {
        

       
     

        
        public string Vorname { get; }
        public string Nachname { get; }

        public Person(string vname, string nname)
        {
            Vorname = vname;
            Nachname = nname;
        }
    }
}

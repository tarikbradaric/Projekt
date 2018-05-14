using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Trainer : Person
    {
        
        private string vname;
        private string nname;

        public Trainer(string vname, string nname)
        {
            
            this.vname = vname;
            this.nname = nname;
        }

        
        public new string Vorname { get { return vname; } }
        public new string Nachname { get { return nname; } }

        public override string ToString()
        {
            return Vorname + " " + Nachname;
        }
    }
}

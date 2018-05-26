using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Spieler : Person
    {

        public string SpielerVon { get; }


        public Spieler(string vname, string nname, string spielv): base(vname,nname)
        {
            SpielerVon = spielv;
            
        }




        public override string ToString()
        {
            return Vorname + " " + Nachname + "(" + "Spieler von " + SpielerVon + ")";
        }



    }
}

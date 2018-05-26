using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Trainer : Person
    {

        public string TrainerVon { get; }


        public Trainer(string vname, string nname, string trainv): base(vname,nname)
        {
            TrainerVon = trainv;

        }



        public override string ToString()
        {
            return Vorname + " " + Nachname + "(" + "Trainer von " + TrainerVon + ")";
        }
    }
}

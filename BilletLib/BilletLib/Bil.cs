using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Bil : Køretøjer
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        public override string Køretøj()
        {
            return "bil";
        }

        public override int Pris()
        {
            return 240;
        }

        public override string NummerPladeBegrænsing()
        {
            if (Nummerplade.Length < 7)
            {
                throw new ArgumentException("Ops din nummerplade indeholder mere end 7 cifre");
            }

            return Nummerplade;
        }
    }
}

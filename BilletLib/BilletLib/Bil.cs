using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class Bil : Køretøjer
    {
        public override int KøretøjPris { get; set; }
        public override string Nummerplade { get; set; }
        public override DayOfWeek Dato { get; set; }
        public override bool BrobizzBrugt { get; set; }


        public override string KøretøjType()
        {
            if (Øresundsbroen)
            {
                return "Øresund Bil";
            }

            return "Bil";
        }

        public override bool Øresundsbroen { get; set; }

        public override void NummerPladeBegrænsing()
        {
            
            if (Nummerplade.Length > 7)
            {
                throw new ArgumentException("Ops din nummerplade indeholder mere end 7 cifre");
            }

          
        }

        public int WeekendRabat()
        {
            int mellemRegning = 0;
            if (!Øresundsbroen)
            {
                KøretøjPris = 240;
            }
           
            if (Dato == DayOfWeek.Saturday || Dato == DayOfWeek.Sunday)
            {
                
                if (!BrobizzBrugt)
                {
                    return KøretøjPris - (20 * KøretøjPris / 100);
                }

                if (BrobizzBrugt && !Øresundsbroen)
                {
                    mellemRegning = KøretøjPris - (20 * KøretøjPris / 100);
                    KøretøjPris = mellemRegning - (5 * mellemRegning / 100);
                    return KøretøjPris;
                }
            }


            return KøretøjPris;
        }

        public Bil()
        {
            Dato = DateTime.Now.DayOfWeek;
        }
     
    }
}

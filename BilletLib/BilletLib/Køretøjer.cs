using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public abstract class Køretøjer
    {
        public abstract string KøretøjType();
        public abstract bool Øresundsbroen { get; set; }
        public abstract int NummerPladeBegrænsing();

        public abstract bool BrobizzBrugt { get; set; }
        public abstract int KøretøjPris { get; set; }
        public abstract string Nummerplade { get; set; }

        public abstract DayOfWeek Dato { get; set; }


        public int Pris()
        {
            int køretøjsPris = 0;
            if (KøretøjType() == "MC")
            {
                køretøjsPris = 125;
            }

            if (KøretøjType() == "Bil")
            {
                køretøjsPris = 240;
            }

            if (KøretøjType() == "Øresund MC")
            {
                køretøjsPris = 210;
            }

            if (KøretøjType() == "Øresund Bil")
            {
                køretøjsPris = 410;
            }

            if (Øresundsbroen && BrobizzBrugt)
            {
                if (KøretøjType() == "Øresund MC")
                {
                    return 73;
                }

                if (KøretøjType() == "Øresund Bil")
                {
                    return 161;
                }
            }
            

            if (BrobizzBrugt)
            {
                return køretøjsPris - (køretøjsPris * 5 / 100);
            }
            return køretøjsPris;
        }

      




    }
}

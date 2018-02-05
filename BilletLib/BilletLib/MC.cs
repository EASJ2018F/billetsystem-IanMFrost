using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class MC : Køretøjer
    {
        public override int KøretøjPris { get; set; }
        public  override string Nummerplade { get; set; }
        public override DayOfWeek Dato { get; set; }
        

        public override bool BrobizzBrugt { get; set; }

        public override string KøretøjType()
        {
            if (Øresundsbroen)
            {
                return "Øresund MC";
            }

            return "MC";
        }

        public override bool Øresundsbroen { get; set; }

        /// <summary>
        /// Sikrer sig at der kun kan oprettes en nummerplade med 7 cifre. Er den længere end 7 cifre smider den en exception
        /// </summary>
        public override void NummerPladeBegrænsing()
        {
            
            if (Nummerplade.Length > 7)
            {
                throw new ArgumentException("Nummerplade er længere end 7 cifrer");
            }

            
        }
    }
}

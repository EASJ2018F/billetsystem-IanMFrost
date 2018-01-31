using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class MC : Køretøjer
    {

        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        public override string Køretøj()
        {
            return "MC";
        }

        public override int Pris()
        {
            return 125;
        }

        /// <summary>
        /// Sikrer sig at der kun kan oprettes en nummerplade med 7 cifre. Er den længere end 7 cifre smider den en exception
        /// </summary>
        public override int NummerPladeBegrænsing()
        {
            
            if (Nummerplade.Length > 7)
            {
                throw new ArgumentException("Nummerplade er længere end 7 cifrer");
            }

            return Nummerplade.Length;
        }
    }
}

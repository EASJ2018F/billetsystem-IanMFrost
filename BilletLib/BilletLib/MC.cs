using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class MC
    {

        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        public int Pris()
        {
            return 125;
        }

        public string køretøj()
        {
            return "MC";
        }

    }
}

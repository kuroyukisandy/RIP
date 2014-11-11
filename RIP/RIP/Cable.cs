using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIP
{
    class Cable
    {

        public double delay { get; set; }

        public double v { get; set; }

        public double traf { get; set; }


      public void cable( double velocidad, double trafico, double retardo)
        {
            delay = retardo;
            v = velocidad;
            traf= trafico;

        }


    }


}

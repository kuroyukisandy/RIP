using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIP
{
    public class Cable
    {

        public double delay { get; set; }

        public double v { get; set; }

        public double traf { get; set; }

        public string origen { get; set; }

        public string destino { get; set; }


      public void cable( double velocidad, double trafico, double retardo, String canal1, String canal2)
        {
            delay = retardo;
            v = velocidad;
            traf= trafico;
            origen = canal1;
            destino = canal2;
        }




    }


}

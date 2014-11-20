using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIP
{
    public class Estadisticas
    {
        public int hop { get; set; }

        public double vel { get; set; }

        public double traf { get; set; }

        public double delay { get; set; }
        
        public String rts { get; set; }

        public void stats(int saltos, double promvel, double promtraf, double promret, String rutas )
        {
            rts = rutas;
            hop = saltos;
            vel = promret;
            traf = promtraf;
            delay = promret;
        }


        
    }
}

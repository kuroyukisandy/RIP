using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIP
{
    public class Ruteo
    {
        public int nsalto { get; set; }

        public ArrayList lruta { get; set; }

        public string begin { get; set; }

        public string end { get; set; }

        public void ruteo(ArrayList rutas,int saltos,String inicio,String final)
        {
            begin = inicio;
            end = final;
            nsalto =saltos;
            lruta = rutas;
        }

        public void calculoruta(Ruteo ruts)
        {
            
        }

    }


}

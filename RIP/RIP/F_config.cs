using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIP
{
    public partial class F_config : Form
    {
        ArrayList lCable = new ArrayList();
        Cable c = new Cable();
        F_RIP rip = new F_RIP();
        int[] v1 = new int[2];
        int[] v2 = new int[2];

        public F_config(Cable cable,int[]vec1,int[]vec2/*String origen, String destino,int trafico,int retardo*/)
        {
            InitializeComponent();
            TB_origen.Text = cable.origen.ToString();
            TB_destino.Text = cable.destino.ToString();
            TB_trafico.Text = cable.traf.ToString();
            TB_retardo.Text = cable.delay.ToString();
            c = cable;
            v1 = vec1;
            v2 = vec2;

         }
           private void B_aceptar_Click(object sender, EventArgs e)
        {
            F_config formulario = new F_config(c,v1,v2);
            Double velocidad = double.Parse(TB_velocidad.Text);
            c.v = velocidad;
            lCable.Add(c);
            rip.cableado(true,v1,v2);
            formulario.Close();
       }

           private void B_cancelar_Click(object sender, EventArgs e)
           {
               rip.cableado(false, v1, v2);
           }
        
    }
}

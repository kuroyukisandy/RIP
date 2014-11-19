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

        public F_config(Cable cable/*String origen, String destino,int trafico,int retardo*/)
        {
            InitializeComponent();
            TB_origen.Text = cable.origen.ToString();
            TB_destino.Text = cable.destino.ToString();
            TB_trafico.Text = cable.traf.ToString();
            TB_retardo.Text = cable.delay.ToString();
         }
        private void B_aceptar_Click(object sender, EventArgs e)
        {            
            Double velocidad = double.Parse(TB_velocidad.Text);
        }

    }
}

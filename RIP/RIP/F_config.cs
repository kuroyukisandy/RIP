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
        int[] v1 = new int[2];
        int[] v2 = new int[2];
        public int velocidad = 0;

        public F_config( ref Cable cable,int[]vec1,int[]vec2/*String origen, String destino,int trafico,int retardo*/)
        {
            InitializeComponent();
            TB_origen.Text = cable.origen.ToString();
            TB_destino.Text = cable.destino.ToString();
            TB_trafico.Text = cable.traf.ToString();
            TB_retardo.Text = cable.delay.ToString();

         }
        private void B_aceptar_Click(object sender, EventArgs e)
        {
            velocidad = int.Parse(TB_velocidad.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void B_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        
    }
}

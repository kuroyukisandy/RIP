using System;
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
    public partial class F_Ping : Form
    {
         public String origenp;
         public String destinop;
        public F_Ping()
        {
            InitializeComponent();
        }

        private void B_aceptar_Click(object sender, EventArgs e)
        {
            origenp = TB_origen.Text;
            destinop = TB_destino.Text;
            this.DialogResult = DialogResult.OK;
        }

    }
}

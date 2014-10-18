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
    public partial class F_RIP : Form
    {
        int nrouter = 0, npc = 0, i=0;
        String selec;
        List<Point> lista = new List<Point>();
        public F_RIP()
        {
            InitializeComponent();

        }

        private void B_router_Click(object sender, EventArgs e)
        {
            selec = "router";
        }

        private void B_pc_Click(object sender, EventArgs e)
        {
            selec = "pc";
        }

        private void B_cable_Click(object sender, EventArgs e)
        {
            selec = "cable";
        }

        private void P_protocolo_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = P_protocolo.CreateGraphics();
             try
                {
/*                    if (i >= 1)
                    {
                        selec = null;
                        i = 0;
                    }
                    else
                    {*/


                    if (selec.Equals("router"))
                    {
                        if (nrouter < 8)
                        {
                            i++;
                            nrouter++;
                            g.DrawImage(Image.FromFile(@"C:\Users\SANDRA\Documents\GitHub\RIP\RIP\RIP\Router.png"), new Rectangle(e.X, e.Y, 50, 50));
                        }else
                        {
                            MessageBox.Show("Ha excedido el numero de routers 8");
                        }
                    }
                       if (selec.Equals("pc"))
                        {
                            if (npc < 3)
                            {
                                npc++;
                                i++;
                                g.DrawImage(Image.FromFile(@"C:\Users\SANDRA\Documents\GitHub\RIP\RIP\RIP\Pc.png"), new Rectangle(e.X, e.Y, 50, 50));
                            }
                            else {
                                MessageBox.Show("Ha excedido el numero de pc's 3");
                            }
                        }

                        if (selec.Equals("cable"))
                        {
                            i++;
                            Pen lapiz = new Pen(Color.Blue, 2);
                            g.DrawRectangle(lapiz, new Rectangle(e.X, e.Y, 3, 3));
                            
                        }

                }catch(Exception){

                    MessageBox.Show("Elija una Herramienta");      
                
            }

             selec = null;
             i = 0;
        }



    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIP
{

    public partial class F_RIP : Form
    {
        int nrouter = 0, npc = 0, i=0,l=0, j=0 , k = 0, n=0;
        String selec;
        List<Point> lista = new List<Point>();
        String rutaAssets = String.Empty;
        int[] vector1 = new int[2];
        int[] vector2 = new int[2];
        Cable cable = new Cable();
        Random rnd = new Random();
        public F_RIP()
        {
            InitializeComponent();
            rutaAssets = Path.GetFullPath(ConfigurationSettings.AppSettings["assets"]);

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
            //Graphics g = P_protocolo.CreateGraphics();
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
                            PictureBox pbr = new PictureBox();
                            
                            pbr.Image = Image.FromFile(rutaAssets + "\\Router.png");
                            pbr.Location = new Point(e.X, e.Y);
                            pbr.Name="Router"+nrouter;
                            pbr.Size = new System.Drawing.Size(65, 50);
                            pbr.Click += new EventHandler(PB_Click);
                            pbr.DoubleClick += new EventHandler(PB_DoubleClick);
                            P_protocolo.Controls.Add(pbr);
                            //g.DrawImage(Image.FromFile(rutaAssets+"\\Router.png"), new Rectangle(e.X, e.Y, 50, 50));
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
                                PictureBox pbc = new PictureBox();

                                pbc.Image = Image.FromFile(rutaAssets + "\\Pc.png");
                                pbc.Location = new Point(e.X, e.Y);
                                pbc.Name = "Pc" + npc;
                                pbc.Size = new System.Drawing.Size(60, 50);
                                pbc.Click += new EventHandler(PB_Click);
                                pbc.DoubleClick += new EventHandler(PB_DoubleClick);
                                P_protocolo.Controls.Add(pbc);
                            }
                            else {
                                MessageBox.Show("Ha excedido el numero de pc's 3");
                            }
                        }

                        if (selec.Equals("cable"))
                        {
                            
                          //  i++;
                           // Pen lapiz = new Pen(Color.Blue, 2);
                           // g.DrawRectangle(lapiz, new Rectangle(e.X, e.Y, 3, 3));
                            
                        }

                }catch(Exception){

                    MessageBox.Show("Elija una Herramienta");      
                
            }

             selec = null;
             i = 0;
        }


       private void PB_Click(object sender, EventArgs e)
       {
           
           l++;
           

           PictureBox pb;
           pb = (PictureBox)sender;
           bool cond=true;

           if (l == 1)
               {

                   String nombre1 = pb.Name.ToString();
                   vector1[0] = pb.Bounds.X + 25;
                   vector1[1] = pb.Bounds.Y + 25;
                   cable.origen = nombre1;
                   //MessageBox.Show("click uno");
               }

                if (l == 2)
               {
                   String nombre2 = pb.Name.ToString();

                       if (cable.origen.StartsWith("Pc") && nombre2.StartsWith("Pc"))
                       {
                           MessageBox.Show("No puede conectar 2 pc directamente");
                           cond = false;
                           l = 0;
                           vector1[0] = 0;
                           vector2[1] = 0;
                           vector1[0] = 0;
                           vector2[1] = 0;
                           cable.destino = null;
                           cable.origen = null;
                           return;
                        }

                       if (cable.origen.StartsWith("Pc") && nombre2.StartsWith("Router"))
                       {
                           j++;
                           if (j==2)
                           {
                               MessageBox.Show("  ya tiene una conexion");
                               cond = false;
                               l = 0;
                               vector1[0] = 0;
                               vector2[1] = 0;
                               vector1[0] = 0;
                               vector2[1] = 0;
                               cable.destino = null;
                               cable.origen = null;
                           }
                       }

                       if (cable.origen.StartsWith("Router") && nombre2.StartsWith("Router"))
                       {
                           k++;
                           if (k==4)
                           {
                               MessageBox.Show("  ya tiene una conexion");
                               cond = false;
                               l = 0;
                               vector1[0] = 0;
                               vector2[1] = 0;
                               vector1[0] = 0;
                               vector2[1] = 0;
                               cable.destino = null;
                               cable.origen = null;
                           }
                       }

                       if (cable.origen.StartsWith("Router") && nombre2.StartsWith("Pc"))
                       {
                           n++;
                           if (n==4)
                           {
                               MessageBox.Show("  ya tiene una conexion");
                               cond = false;
                               l = 0;
                               vector1[0] = 0;
                               vector2[1] = 0;
                               vector1[0] = 0;
                               vector2[1] = 0;
                               cable.destino = null;
                               cable.origen = null;
                           }
                       }

                   if (cond)
                   {
                       vector2[0] = pb.Bounds.X + 25;
                       vector2[1] = pb.Bounds.Y + 25;
                       cable.destino = nombre2;
                       int trafic = trafico();
                       int delay = retardo();
                       cable.traf = trafic;
                       cable.delay = delay;

                       F_config config = new F_config(cable,vector1,vector2);
                       config.ShowDialog();

                       l = 0;
                       vector1[0] = 0;
                       vector2[1] = 0;
                       vector1[0] = 0;
                       vector2[1] = 0;
                       cable.destino = null;
                       cable.origen = null;
                   }
               }

       }
        private void PB_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show("Dobleclick");
        }

        public int trafico()
        {
            
            int traf= rnd.Next(1, 10);
            return traf;
        }

        public int retardo()
        {
            
            int delay = rnd.Next(1, 10);
            return delay;
        }

        public void cableado(bool valida,int[] vector1,int[]vector2) 
        {
            if (valida)
            {
                Graphics g = P_protocolo.CreateGraphics();
                Pen lapiz = new Pen(Color.Blue, 2);
                g.DrawLine(lapiz, vector1[0], vector1[1], vector2[0], vector2[1]);
            }
            
        }
    }

}

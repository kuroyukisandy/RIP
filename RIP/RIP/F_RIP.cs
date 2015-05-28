using System;
using System.Collections;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RIP
{

    public partial class F_RIP : Form
    {
        int nrouter = 0, npc = 0, i = 0, l = 0, j = 0, n = 0, tr=0;
        ArrayList cables = new ArrayList();
        ArrayList conec = new ArrayList();
        ArrayList rutas = new ArrayList();
        ArrayList numrutas = new ArrayList();
        ArrayList auxrutas = new ArrayList();
        ArrayList estadisticas = new ArrayList();
        String selec;
        String rutaAssets = String.Empty;
        int[] vector1 = new int[2];
        int[] vector2 = new int[2];
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
            
        }

        private void P_protocolo_MouseDown(object sender, MouseEventArgs e)
        {
            //Graphics g = P_protocolo.CreateGraphics();
             try
                {
                    //Dibujado del router
                    if (selec.Equals("router"))
                    {
                        if (nrouter < 8)
                        {
                            i++;
                            nrouter++;
                            PictureBox pbr = new PictureBox();
                            Label lblR = new Label();
                            pbr.Image = Image.FromFile(rutaAssets + "\\Router.png");
                            pbr.Location = new Point(e.X, e.Y);
                            pbr.Name="Router"+nrouter;
                            lblR.Text = pbr.Name;
                            lblR.Location = new Point(e.X, (e.Y-15));
                            pbr.Size = new System.Drawing.Size(65, 50);
                            pbr.Click += new EventHandler(PB_Click);
                            pbr.DoubleClick += new EventHandler(PB_DoubleClick);
                            P_protocolo.Controls.Add(pbr);
                            P_protocolo.Controls.Add(lblR);
                            //g.DrawImage(Image.FromFile(rutaAssets+"\\Router.png"), new Rectangle(e.X, e.Y, 50, 50));
                        }else
                        {
                            MessageBox.Show("Ha excedido el numero de routers 8");
                        }
                    }

                    //Dibujado del PC
                    if (selec.Equals("pc"))
                    {
                        if (npc < 5)
                        {
                            npc++;
                            i++;
                            PictureBox pbc = new PictureBox();
                            Label lblC = new Label();
                            pbc.Image = Image.FromFile(rutaAssets + "\\Pc.png");
                            pbc.Location = new Point(e.X, e.Y);
                            pbc.Name = "Pc" + npc;
                            lblC.Text = pbc.Name;
                            lblC.Location = new Point(e.X, (e.Y-15));
                            pbc.Size = new System.Drawing.Size(60, 50);
                            pbc.Click += new EventHandler(PB_Click);
                            pbc.DoubleClick += new EventHandler(PB_DoubleClick);
                            P_protocolo.Controls.Add(pbc);
                            P_protocolo.Controls.Add(lblC);
                        }
                        else {
                            MessageBox.Show("Ha excedido el numero de pc's 5");
                        }
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
           Cable cable;

           if (l == 1)
               {
                   cables.Add(new Cable());
                   String nombre1 = pb.Name.ToString();
                   vector1[0] = pb.Bounds.X + 25;
                   vector1[1] = pb.Bounds.Y + 25;
                   cable = (Cable)cables[cables.Count - 1];
                   cable.origen = nombre1;
                   cables[cables.Count - 1] = cable;
                   //MessageBox.Show("click uno");
               }

            if (l == 2)
            {
                cable = (Cable)cables[cables.Count - 1];
                String nombre2 = pb.Name.ToString();

                    if (cable.origen.StartsWith("Pc") && nombre2.StartsWith("Pc"))
                    {
                        if (cable.origen.Equals(nombre2))
                        {
                            //ver datos del PC actual
                            MessageBox.Show("este es el equipo " + cable.origen);
                            cond = false;
                            l = 0;
                            cables.RemoveAt(cables.Count - 1);
                            return;
                        }
                        MessageBox.Show("No puede conectar 2 pc directamente");
                        cond = false;
                        l = 0;
                        cables.RemoveAt(cables.Count - 1);
                        return;
                    }
                    if (cable.origen.Equals(nombre2)) { 
                        //ver datos del Router actual
                        MessageBox.Show("este es el equipo "+cable.origen);
                        cond = false;
                        l = 0;
                        cables.RemoveAt(cables.Count - 1);
                        return;
                    }
                    if (cable.origen.StartsWith("Pc") && nombre2.StartsWith("Router"))
                    {
                        //j++;
                        foreach (Cable c in cables)
                        {
                            if (c.origen.Equals(cable.origen))
                            {
                                if (c.destino != null)
                                {
                                    MessageBox.Show("Conex Pc router ya existe");
                                    cond = false;
                                    cables.RemoveAt(cables.Count-1);
                                    l = 0;
                                    break;
                                }
                            }
                        }
                    }

                    if (cable.origen.StartsWith("Router") && nombre2.StartsWith("Pc"))
                    {
                        foreach (Cable c in cables)
                        {
                            if (c.origen!=null&&c.destino!=null)
                            {
                                if (c.destino.Equals(cable.origen) && c.origen.Equals(nombre2))
                                {
                                    MessageBox.Show("Esta conexion ya existe");
                                    cond = false;
                                    cables.RemoveAt(cables.Count - 1);
                                    l = 0;
                                    break;
                                } 
                                if(c.origen.Equals(nombre2))
                                {
                                    MessageBox.Show("Ese pc ya tiene una conexión activa");
                                    cond = false;
                                    cables.RemoveAt(cables.Count - 1);
                                    l = 0;
                                    break;
                                }
                            }
                        }
                    }

                    if (cable.origen.StartsWith("Router") && nombre2.StartsWith("Router"))
                    {
                        foreach (Cable c in cables)
                        {
                            if (c.destino != null)
                            {
                                if ((c.destino.Equals(cable.origen)&&c.origen.Equals(nombre2))||(c.destino.Equals(nombre2) && c.origen.Equals(cable.origen)))
                                {
                                    MessageBox.Show("Conex Router-Router ya existe");
                                    cond = false;
                                    cables.RemoveAt(cables.Count - 1);
                                    l = 0;
                                    break;
                                }
                            }
                        }
                    }

                    if (cable.origen.StartsWith("Router") || nombre2.StartsWith("Router"))
                    {
                        int suma = 0;
                        foreach (Cable c in cables)
                        {
                            if (c.destino != null)
                            {
                                suma = 0;
                                string nomb = c.origen;
                                foreach (Cable cab in cables)
                                {
                                    if (cab.origen.Equals(nomb) || (cab.destino != null && cab.destino.Equals(nomb)) || nombre2.Equals(nomb))
                                        {
                                            suma++;
                                        }
                                }
                            }
                            if (suma > 4)
                            {
                                MessageBox.Show("Ha excedido la cantidad de conexiones por router 4");
                                cond = false; 
                                cables.RemoveAt(cables.Count - 1);
                                l = 0;
                                break;
                            }
                        }

                        
                    }

                

                if (cond)
                {
                    cable=(Cable)cables[cables.Count - 1];

                    vector2[0] = pb.Bounds.X + 25;
                    vector2[1] = pb.Bounds.Y + 25;
                    cable.destino = nombre2;
                    string trafic = trafico();
                    int delay = retardo();
                    cable.traf = trafic;
                    cable.delay = delay;

                    F_config config = new F_config(ref cable,vector1,vector2);
                    config.ShowDialog();
                    if (config.DialogResult == DialogResult.OK)
                    {
                        cable.v = config.velocidad;
                        config.Dispose();
                        Graphics g = P_protocolo.CreateGraphics();
                        Pen lapiz = new Pen(Color.Blue, 2);
                        g.DrawLine(lapiz, vector1[0], vector1[1], vector2[0], vector2[1]);
                        cables[cables.Count - 1] = cable;
                    }
                    else
                    {
                        cables.RemoveAt(cables.Count-1);
                    }

                    l = 0;
                    vector1[0] = 0;
                    vector2[1] = 0;
                    vector1[0] = 0;
                    vector2[1] = 0;
                }
            }

       }
        private void PB_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show("Dobleclick");
        }

        public String trafico()
        {
            
            int t= rnd.Next(1,3);
            string traf="";
            switch (t)
            {
                case 3: traf = "alto";
                break;
                case 2: traf = "medio";
                break;
                case 1: traf = "bajo";
                break;
                   
            }


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

        private void B_Ping_Click(object sender, EventArgs e)
        {
            F_Ping ping = new F_Ping();
            ping.ShowDialog();
            if (ping.DialogResult == DialogResult.OK)
            {
                String origen = ping.origenp;
                String destino = ping.destinop;
                CreaRutas(origen,destino);               
            }
        }

        private void CreaRutas(String origen,String destino)
        {
           
           String des="",org=origen;
           bool valid=true;
            
            while(des!=destino)
            {
                ArrayList al=listarconec(org);
                foreach (Cable r in al)
                {
                    if (al.Count > 1)
                    {
                        if (numrutas.Count > 0)
                        {
                            foreach (Cable z in rutas)
                            {
                                if (auxrutas.IndexOf(r) != -1 || r == z || r.destino == org)
                                {
                                    if (r.destino != destino)
                                    {
                                        valid = false;
                                    }
                                    else { valid = true;}
                                }
                                else { valid = true; }
                            }
                            
                        }
                        else {
                            foreach (Cable z in rutas)
                            {
                                if (r == z || r.destino == org)
                                {
                                    valid = false;
                                }
                                else { valid = true; }
                            }
                            
                        
                        }

                        if(valid)
                        {
                            rutas.Add(r);
                            auxrutas.Add(r);
                            org = r.destino;
                            des = r.destino;
                            break;
                        }
                        
                    }
                    else {
                        rutas.Add(r);
                        org = r.destino;
                    }
                    des = r.destino;
                }

                
            }
            ArrayList aux = new ArrayList(rutas);
            Ruteo routs = new Ruteo();
            routs.begin = origen;
            routs.end = destino;
            routs.lruta=aux;
            routs.nsalto = rutas.Count-1;
            numrutas.Add(routs);
            rutas.Clear();
/*          routs.begin =null;
            routs.end = null;            
            routs.nsalto = 0;*/
            
            if (auxrutas.Count < (Math.Pow(2, numrutas.Count)))//--------------
            {
                CreaRutas(origen, destino);
            }
            else {
                 calculoruta(numrutas);
            }
            
        }

        private ArrayList listarconec(String origen) {

            conec.Clear();
            foreach (Cable c in cables)
            {
                if (c.origen == origen || c.destino == origen)
                {
                    conec.Add(c);
                }
            }

            return conec;
        }

        public void calculoruta(ArrayList ruts)
        {
            estadisticas.Clear();
            Estadisticas estads = new Estadisticas();
            String camino="";
            int i;
            double sumavel = 0;
            double sumatraf = 0;
            double sumaret = 0;
            double mayvel=0;
            double mintraf=11;
            double minret=11;
            int jmp=11;
            



            foreach (Ruteo c in ruts)
            {
                i = 0;
                sumavel = 0;
                sumatraf = 0;
                sumaret = 0;
                camino = "";
                foreach (Cable k in c.lruta)
                {
                    switch (k.traf)
                    {
                        case "alto": tr = 3;
                        break;
                        case "medio": tr = 2;
                        break;
                        case "bajo": tr = 1;
                        break;
                    }
                    sumaret += k.delay;
                    sumatraf += tr;
                    sumavel += k.v;
                    i++;
                    camino += (k.origen + "-" + k.destino);
                }


                estads.hop = c.nsalto;
                estads.vel = sumavel / i;
                estads.traf = sumatraf / i;
                estads.delay = sumaret / i;

                estadisticas.Add(estads);
            }
                foreach (Estadisticas s in estadisticas) {
                    if (s.vel > mayvel) {

                        mayvel = s.vel;
                        estads.rts=camino;

                        if (s.delay < minret)
                        {
                            minret = s.delay;

                            if (s.traf < mintraf)
                            {
                                mintraf = s.traf;
                                if (s.hop < jmp) 
                                {
                                    jmp = s.hop;
                                }
                            }
                        }
                    }

                }
                MessageBox.Show("La mejor ruta es: " +camino );
            }

    }

}

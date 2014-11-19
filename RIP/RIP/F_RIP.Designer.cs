namespace RIP
{
    partial class F_RIP
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_RIP));
            this.B_Ping = new System.Windows.Forms.Button();
            this.P_protocolo = new System.Windows.Forms.Panel();
            this.B_pc = new System.Windows.Forms.Button();
            this.B_router = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Ping
            // 
            this.B_Ping.Location = new System.Drawing.Point(190, 12);
            this.B_Ping.Name = "B_Ping";
            this.B_Ping.Size = new System.Drawing.Size(72, 62);
            this.B_Ping.TabIndex = 2;
            this.B_Ping.Text = "Ping";
            this.B_Ping.UseVisualStyleBackColor = true;
            this.B_Ping.Click += new System.EventHandler(this.B_Ping_Click);
            // 
            // P_protocolo
            // 
            this.P_protocolo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P_protocolo.Location = new System.Drawing.Point(34, 80);
            this.P_protocolo.Name = "P_protocolo";
            this.P_protocolo.Size = new System.Drawing.Size(1062, 483);
            this.P_protocolo.TabIndex = 3;
            this.P_protocolo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_protocolo_MouseDown);
            // 
            // B_pc
            // 
            this.B_pc.Image = ((System.Drawing.Image)(resources.GetObject("B_pc.Image")));
            this.B_pc.Location = new System.Drawing.Point(112, 12);
            this.B_pc.Name = "B_pc";
            this.B_pc.Size = new System.Drawing.Size(72, 62);
            this.B_pc.TabIndex = 1;
            this.B_pc.UseVisualStyleBackColor = true;
            this.B_pc.Click += new System.EventHandler(this.B_pc_Click);
            // 
            // B_router
            // 
            this.B_router.Image = ((System.Drawing.Image)(resources.GetObject("B_router.Image")));
            this.B_router.Location = new System.Drawing.Point(34, 12);
            this.B_router.Name = "B_router";
            this.B_router.Size = new System.Drawing.Size(72, 62);
            this.B_router.TabIndex = 0;
            this.B_router.UseVisualStyleBackColor = true;
            this.B_router.Click += new System.EventHandler(this.B_router_Click);
            // 
            // F_RIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 575);
            this.Controls.Add(this.P_protocolo);
            this.Controls.Add(this.B_Ping);
            this.Controls.Add(this.B_pc);
            this.Controls.Add(this.B_router);
            this.Name = "F_RIP";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_router;
        private System.Windows.Forms.Button B_pc;
        private System.Windows.Forms.Button B_Ping;
        private System.Windows.Forms.Panel P_protocolo;
    }
}


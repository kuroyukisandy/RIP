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
            this.B_cable = new System.Windows.Forms.Button();
            this.P_protocolo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.B_pc = new System.Windows.Forms.Button();
            this.B_router = new System.Windows.Forms.Button();
            this.P_protocolo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // B_cable
            // 
            this.B_cable.Location = new System.Drawing.Point(190, 12);
            this.B_cable.Name = "B_cable";
            this.B_cable.Size = new System.Drawing.Size(72, 62);
            this.B_cable.TabIndex = 2;
            this.B_cable.Text = "Cableado";
            this.B_cable.UseVisualStyleBackColor = true;
            this.B_cable.Click += new System.EventHandler(this.B_cable_Click);
            // 
            // P_protocolo
            // 
            this.P_protocolo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P_protocolo.Controls.Add(this.pictureBox1);
            this.P_protocolo.Location = new System.Drawing.Point(34, 80);
            this.P_protocolo.Name = "P_protocolo";
            this.P_protocolo.Size = new System.Drawing.Size(1062, 483);
            this.P_protocolo.TabIndex = 3;
            this.P_protocolo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_protocolo_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.Controls.Add(this.B_cable);
            this.Controls.Add(this.B_pc);
            this.Controls.Add(this.B_router);
            this.Name = "F_RIP";
            this.Text = "Form1";
            this.P_protocolo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_router;
        private System.Windows.Forms.Button B_pc;
        private System.Windows.Forms.Button B_cable;
        private System.Windows.Forms.Panel P_protocolo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


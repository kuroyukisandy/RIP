namespace RIP
{
    partial class F_Ping
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_origen = new System.Windows.Forms.TextBox();
            this.TB_destino = new System.Windows.Forms.TextBox();
            this.B_aceptar = new System.Windows.Forms.Button();
            this.B_cancelar = new System.Windows.Forms.Button();
            this.L_origen = new System.Windows.Forms.Label();
            this.L_destino = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_origen
            // 
            this.TB_origen.Location = new System.Drawing.Point(87, 31);
            this.TB_origen.Name = "TB_origen";
            this.TB_origen.Size = new System.Drawing.Size(100, 20);
            this.TB_origen.TabIndex = 0;
            // 
            // TB_destino
            // 
            this.TB_destino.Location = new System.Drawing.Point(87, 57);
            this.TB_destino.Name = "TB_destino";
            this.TB_destino.Size = new System.Drawing.Size(100, 20);
            this.TB_destino.TabIndex = 1;
            // 
            // B_aceptar
            // 
            this.B_aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.B_aceptar.Location = new System.Drawing.Point(29, 93);
            this.B_aceptar.Name = "B_aceptar";
            this.B_aceptar.Size = new System.Drawing.Size(75, 23);
            this.B_aceptar.TabIndex = 2;
            this.B_aceptar.Text = "Aceptar";
            this.B_aceptar.UseVisualStyleBackColor = true;
            this.B_aceptar.Click += new System.EventHandler(this.B_aceptar_Click);
            // 
            // B_cancelar
            // 
            this.B_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.B_cancelar.Location = new System.Drawing.Point(162, 93);
            this.B_cancelar.Name = "B_cancelar";
            this.B_cancelar.Size = new System.Drawing.Size(75, 23);
            this.B_cancelar.TabIndex = 3;
            this.B_cancelar.Text = "Cancelar";
            this.B_cancelar.UseVisualStyleBackColor = true;
            // 
            // L_origen
            // 
            this.L_origen.AutoSize = true;
            this.L_origen.Location = new System.Drawing.Point(13, 31);
            this.L_origen.Name = "L_origen";
            this.L_origen.Size = new System.Drawing.Size(38, 13);
            this.L_origen.TabIndex = 4;
            this.L_origen.Text = "Origen";
            // 
            // L_destino
            // 
            this.L_destino.AutoSize = true;
            this.L_destino.Location = new System.Drawing.Point(13, 57);
            this.L_destino.Name = "L_destino";
            this.L_destino.Size = new System.Drawing.Size(43, 13);
            this.L_destino.TabIndex = 5;
            this.L_destino.Text = "Destino";
            // 
            // F_Ping
            // 
            this.AcceptButton = this.B_aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.B_cancelar;
            this.ClientSize = new System.Drawing.Size(284, 143);
            this.Controls.Add(this.L_destino);
            this.Controls.Add(this.L_origen);
            this.Controls.Add(this.B_cancelar);
            this.Controls.Add(this.B_aceptar);
            this.Controls.Add(this.TB_destino);
            this.Controls.Add(this.TB_origen);
            this.Name = "F_Ping";
            this.Text = "F_Ping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_origen;
        private System.Windows.Forms.TextBox TB_destino;
        private System.Windows.Forms.Button B_aceptar;
        private System.Windows.Forms.Button B_cancelar;
        private System.Windows.Forms.Label L_origen;
        private System.Windows.Forms.Label L_destino;
    }
}
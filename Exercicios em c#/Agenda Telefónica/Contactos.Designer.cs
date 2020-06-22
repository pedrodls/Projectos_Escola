namespace Agenda_Telefónica
{
    partial class Contactos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contactos));
            this.cmd_voltar = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new ns1.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox2 = new ns1.BunifuMaterialTextbox();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gravar = new ns1.BunifuThinButton2();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd_voltar
            // 
            this.cmd_voltar.AutoSize = true;
            this.cmd_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_voltar.Location = new System.Drawing.Point(4, 2);
            this.cmd_voltar.Name = "cmd_voltar";
            this.cmd_voltar.Size = new System.Drawing.Size(40, 30);
            this.cmd_voltar.TabIndex = 6;
            this.cmd_voltar.Text = "←";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Mistral", 15F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.bunifuMaterialTextbox1.LineThickness = 4;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(27, 39);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(185, 30);
            this.bunifuMaterialTextbox1.TabIndex = 7;
            this.bunifuMaterialTextbox1.Text = "Nome";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Mistral", 15F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.SeaGreen;
            this.bunifuMaterialTextbox2.LineThickness = 4;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(27, 67);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(185, 35);
            this.bunifuMaterialTextbox2.TabIndex = 8;
            this.bunifuMaterialTextbox2.Text = "Número";
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-1, 177);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(261, 35);
            this.bunifuSeparator1.TabIndex = 9;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gravar);
            this.groupBox1.Controls.Add(this.bunifuMaterialTextbox1);
            this.groupBox1.Controls.Add(this.bunifuMaterialTextbox2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Mistral", 17F);
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(10, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 146);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Contacto";
            // 
            // gravar
            // 
            this.gravar.ActiveBorderThickness = 1;
            this.gravar.ActiveCornerRadius = 20;
            this.gravar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.gravar.ActiveForecolor = System.Drawing.Color.White;
            this.gravar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.gravar.BackColor = System.Drawing.Color.White;
            this.gravar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gravar.BackgroundImage")));
            this.gravar.ButtonText = "Gravar";
            this.gravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gravar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.gravar.ForeColor = System.Drawing.Color.SeaGreen;
            this.gravar.IdleBorderThickness = 1;
            this.gravar.IdleCornerRadius = 20;
            this.gravar.IdleFillColor = System.Drawing.Color.White;
            this.gravar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.gravar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.gravar.Location = new System.Drawing.Point(136, 112);
            this.gravar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gravar.Name = "gravar";
            this.gravar.Size = new System.Drawing.Size(75, 30);
            this.gravar.TabIndex = 11;
            this.gravar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Contactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(261, 411);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.cmd_voltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contactos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactos";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cmd_voltar;
        private ns1.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private ns1.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private ns1.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ns1.BunifuThinButton2 gravar;
    }
}
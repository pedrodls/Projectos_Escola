namespace agendaBD
{
    partial class stuus
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
            this.listaContacto = new System.Windows.Forms.ListBox();
            this.EditarContacto = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalbl = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnApagarTudo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaContacto
            // 
            this.listaContacto.FormattingEnabled = true;
            this.listaContacto.Location = new System.Drawing.Point(18, 26);
            this.listaContacto.Name = "listaContacto";
            this.listaContacto.Size = new System.Drawing.Size(284, 251);
            this.listaContacto.TabIndex = 1;
            this.listaContacto.SelectedIndexChanged += new System.EventHandler(this.listaContacto_SelectedIndexChanged);
            // 
            // EditarContacto
            // 
            this.EditarContacto.Location = new System.Drawing.Point(14, 431);
            this.EditarContacto.Name = "EditarContacto";
            this.EditarContacto.Size = new System.Drawing.Size(80, 23);
            this.EditarContacto.TabIndex = 2;
            this.EditarContacto.Text = "Editar";
            this.EditarContacto.UseVisualStyleBackColor = true;
            this.EditarContacto.Click += new System.EventHandler(this.EditarContacto_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Apagar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total de Contactos:";
            // 
            // totalbl
            // 
            this.totalbl.AutoSize = true;
            this.totalbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.totalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalbl.Location = new System.Drawing.Point(128, 307);
            this.totalbl.Name = "totalbl";
            this.totalbl.Size = new System.Drawing.Size(16, 13);
            this.totalbl.TabIndex = 5;
            this.totalbl.Text = "...";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(94, 353);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(208, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(94, 386);
            this.txtNumero.MaxLength = 24;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(208, 20);
            this.txtNumero.TabIndex = 7;
            // 
            // btnApagarTudo
            // 
            this.btnApagarTudo.Location = new System.Drawing.Point(218, 431);
            this.btnApagarTudo.Name = "btnApagarTudo";
            this.btnApagarTudo.Size = new System.Drawing.Size(84, 23);
            this.btnApagarTudo.TabIndex = 8;
            this.btnApagarTudo.Text = "Apagar todos";
            this.btnApagarTudo.UseVisualStyleBackColor = true;
            this.btnApagarTudo.Click += new System.EventHandler(this.btnApagarTudo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Número:";
            // 
            // stuus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 493);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnApagarTudo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.totalbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EditarContacto);
            this.Controls.Add(this.listaContacto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "stuus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Contactos";
            this.Load += new System.EventHandler(this.stuus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listaContacto;
        private System.Windows.Forms.Button EditarContacto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalbl;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnApagarTudo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
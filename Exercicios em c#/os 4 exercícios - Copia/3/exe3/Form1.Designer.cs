namespace exe3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_entrada_sequencia = new System.Windows.Forms.TextBox();
            this.btnProsseguir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_entrada_N = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lbl_verfcar_seqcia = new System.Windows.Forms.Label();
            this.lbl_verificar_N = new System.Windows.Forms.Label();
            this.lbxVetor = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaior = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira a sequência:";
            // 
            // txt_entrada_sequencia
            // 
            this.txt_entrada_sequencia.BackColor = System.Drawing.Color.SaddleBrown;
            this.txt_entrada_sequencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_entrada_sequencia.Location = new System.Drawing.Point(221, 71);
            this.txt_entrada_sequencia.MaxLength = 10;
            this.txt_entrada_sequencia.Name = "txt_entrada_sequencia";
            this.txt_entrada_sequencia.Size = new System.Drawing.Size(243, 24);
            this.txt_entrada_sequencia.TabIndex = 0;
            this.txt_entrada_sequencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_entrada_sequencia_KeyPress);
            // 
            // btnProsseguir
            // 
            this.btnProsseguir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProsseguir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProsseguir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnProsseguir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProsseguir.Location = new System.Drawing.Point(221, 184);
            this.btnProsseguir.Name = "btnProsseguir";
            this.btnProsseguir.Size = new System.Drawing.Size(86, 23);
            this.btnProsseguir.TabIndex = 2;
            this.btnProsseguir.Text = "Prosseguir";
            this.btnProsseguir.UseVisualStyleBackColor = true;
            this.btnProsseguir.Click += new System.EventHandler(this.btnProsseguir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insira a sequência de N:";
            // 
            // txt_entrada_N
            // 
            this.txt_entrada_N.BackColor = System.Drawing.Color.SaddleBrown;
            this.txt_entrada_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_entrada_N.Location = new System.Drawing.Point(221, 128);
            this.txt_entrada_N.MaxLength = 3;
            this.txt_entrada_N.Name = "txt_entrada_N";
            this.txt_entrada_N.Size = new System.Drawing.Size(243, 24);
            this.txt_entrada_N.TabIndex = 1;
            this.txt_entrada_N.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_entrada_sequencia_KeyPress);
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(582, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(20, 22);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lbl_verfcar_seqcia
            // 
            this.lbl_verfcar_seqcia.AutoSize = true;
            this.lbl_verfcar_seqcia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_verfcar_seqcia.Location = new System.Drawing.Point(217, 99);
            this.lbl_verfcar_seqcia.Name = "lbl_verfcar_seqcia";
            this.lbl_verfcar_seqcia.Size = new System.Drawing.Size(0, 20);
            this.lbl_verfcar_seqcia.TabIndex = 6;
            // 
            // lbl_verificar_N
            // 
            this.lbl_verificar_N.AutoSize = true;
            this.lbl_verificar_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_verificar_N.Location = new System.Drawing.Point(217, 151);
            this.lbl_verificar_N.Name = "lbl_verificar_N";
            this.lbl_verificar_N.Size = new System.Drawing.Size(0, 20);
            this.lbl_verificar_N.TabIndex = 7;
            // 
            // lbxVetor
            // 
            this.lbxVetor.BackColor = System.Drawing.Color.SaddleBrown;
            this.lbxVetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxVetor.FormattingEnabled = true;
            this.lbxVetor.ItemHeight = 20;
            this.lbxVetor.Location = new System.Drawing.Point(332, 184);
            this.lbxVetor.Name = "lbxVetor";
            this.lbxVetor.Size = new System.Drawing.Size(132, 224);
            this.lbxVetor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Maior da sequência:";
            // 
            // lblMaior
            // 
            this.lblMaior.AutoSize = true;
            this.lblMaior.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaior.Location = new System.Drawing.Point(334, 422);
            this.lblMaior.Name = "lblMaior";
            this.lblMaior.Size = new System.Drawing.Size(0, 22);
            this.lblMaior.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(607, 452);
            this.Controls.Add(this.lblMaior);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxVetor);
            this.Controls.Add(this.lbl_verificar_N);
            this.Controls.Add(this.lbl_verfcar_seqcia);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txt_entrada_N);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProsseguir);
            this.Controls.Add(this.txt_entrada_sequencia);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_entrada_sequencia;
        private System.Windows.Forms.Button btnProsseguir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_entrada_N;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lbl_verfcar_seqcia;
        private System.Windows.Forms.Label lbl_verificar_N;
        private System.Windows.Forms.ListBox lbxVetor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaior;
    }
}


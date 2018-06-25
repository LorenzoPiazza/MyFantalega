namespace Client.View
{
    partial class HomeMercatoAdmin
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
            this.listBoxAcquisti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCrediti = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAttesa = new System.Windows.Forms.Label();
            this.buttonCrea = new System.Windows.Forms.Button();
            this.buttonPartecipa = new System.Windows.Forms.Button();
            this.textBoxOfferta = new System.Windows.Forms.TextBox();
            this.textBoxGiocatore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonIndietro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxAcquisti
            // 
            this.listBoxAcquisti.FormattingEnabled = true;
            this.listBoxAcquisti.ItemHeight = 16;
            this.listBoxAcquisti.Location = new System.Drawing.Point(47, 106);
            this.listBoxAcquisti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxAcquisti.Name = "listBoxAcquisti";
            this.listBoxAcquisti.ScrollAlwaysVisible = true;
            this.listBoxAcquisti.Size = new System.Drawing.Size(713, 116);
            this.listBoxAcquisti.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "I tuoi Acquisti";
            // 
            // textBoxCrediti
            // 
            this.textBoxCrediti.Location = new System.Drawing.Point(148, 233);
            this.textBoxCrediti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCrediti.Name = "textBoxCrediti";
            this.textBoxCrediti.ReadOnly = true;
            this.textBoxCrediti.Size = new System.Drawing.Size(100, 22);
            this.textBoxCrediti.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "I tuoi Crediti:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAttesa);
            this.groupBox1.Controls.Add(this.buttonCrea);
            this.groupBox1.Controls.Add(this.buttonPartecipa);
            this.groupBox1.Controls.Add(this.textBoxOfferta);
            this.groupBox1.Controls.Add(this.textBoxGiocatore);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(245, 278);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(357, 153);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // labelAttesa
            // 
            this.labelAttesa.AutoSize = true;
            this.labelAttesa.BackColor = System.Drawing.Color.Transparent;
            this.labelAttesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttesa.ForeColor = System.Drawing.Color.DarkRed;
            this.labelAttesa.Location = new System.Drawing.Point(89, 98);
            this.labelAttesa.Name = "labelAttesa";
            this.labelAttesa.Size = new System.Drawing.Size(185, 17);
            this.labelAttesa.TabIndex = 15;
            this.labelAttesa.Text = "...In attesa di un turno...";
            // 
            // buttonCrea
            // 
            this.buttonCrea.Location = new System.Drawing.Point(201, 98);
            this.buttonCrea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCrea.Name = "buttonCrea";
            this.buttonCrea.Size = new System.Drawing.Size(125, 48);
            this.buttonCrea.TabIndex = 14;
            this.buttonCrea.Text = "Crea un\'Asta";
            this.buttonCrea.UseVisualStyleBackColor = true;
            this.buttonCrea.Click += new System.EventHandler(this.buttonCrea_Click);
            // 
            // buttonPartecipa
            // 
            this.buttonPartecipa.Location = new System.Drawing.Point(29, 98);
            this.buttonPartecipa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPartecipa.Name = "buttonPartecipa";
            this.buttonPartecipa.Size = new System.Drawing.Size(125, 48);
            this.buttonPartecipa.TabIndex = 13;
            this.buttonPartecipa.Text = "Partecipa all\'Asta";
            this.buttonPartecipa.UseVisualStyleBackColor = true;
            // 
            // textBoxOfferta
            // 
            this.textBoxOfferta.Location = new System.Drawing.Point(201, 62);
            this.textBoxOfferta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOfferta.Name = "textBoxOfferta";
            this.textBoxOfferta.ReadOnly = true;
            this.textBoxOfferta.Size = new System.Drawing.Size(64, 22);
            this.textBoxOfferta.TabIndex = 12;
            // 
            // textBoxGiocatore
            // 
            this.textBoxGiocatore.Location = new System.Drawing.Point(201, 21);
            this.textBoxGiocatore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGiocatore.Name = "textBoxGiocatore";
            this.textBoxGiocatore.ReadOnly = true;
            this.textBoxGiocatore.Size = new System.Drawing.Size(151, 22);
            this.textBoxGiocatore.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Offerta attuale:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 18);
            this.label9.TabIndex = 1;
            this.label9.Text = "Giocatore all\'Asta:";
            // 
            // buttonIndietro
            // 
            this.buttonIndietro.Location = new System.Drawing.Point(47, 23);
            this.buttonIndietro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIndietro.Name = "buttonIndietro";
            this.buttonIndietro.Size = new System.Drawing.Size(75, 23);
            this.buttonIndietro.TabIndex = 34;
            this.buttonIndietro.Text = "Indietro";
            this.buttonIndietro.UseVisualStyleBackColor = true;
            this.buttonIndietro.Click += new System.EventHandler(this.buttonIndietro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(217, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 37);
            this.label2.TabIndex = 36;
            this.label2.Text = "Home Mercato Admin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(635, 23);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 48);
            this.button4.TabIndex = 37;
            this.button4.Text = "Gestione Mercato";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // HomeMercatoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonIndietro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxCrediti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxAcquisti);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomeMercatoAdmin";
            this.Text = "MyFantalega";
            this.Load += new System.EventHandler(this.HomeMercatoAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxAcquisti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCrediti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCrea;
        private System.Windows.Forms.Button buttonPartecipa;
        private System.Windows.Forms.TextBox textBoxOfferta;
        private System.Windows.Forms.TextBox textBoxGiocatore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonIndietro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelAttesa;
    }
}
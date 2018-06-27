namespace Client.View
{
    partial class SvincolaGiocatore
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.svincolaButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxGiocatori = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(277, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 38);
            this.label2.TabIndex = 21;
            this.label2.Text = "Svincola Giocatori";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "La tua Rosa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Prezzo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 386);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 22);
            this.textBox1.TabIndex = 25;
            // 
            // svincolaButton
            // 
            this.svincolaButton.Location = new System.Drawing.Point(284, 373);
            this.svincolaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.svincolaButton.Name = "svincolaButton";
            this.svincolaButton.Size = new System.Drawing.Size(87, 35);
            this.svincolaButton.TabIndex = 26;
            this.svincolaButton.Text = "Svincola";
            this.svincolaButton.UseVisualStyleBackColor = true;
            this.svincolaButton.Click += new System.EventHandler(this.svincolaButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 21);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Indietro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxGiocatori
            // 
            this.comboBoxGiocatori.DisplayMember = "NomeLega";
            this.comboBoxGiocatori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGiocatori.FormattingEnabled = true;
            this.comboBoxGiocatori.Location = new System.Drawing.Point(55, 124);
            this.comboBoxGiocatori.Name = "comboBoxGiocatori";
            this.comboBoxGiocatori.Size = new System.Drawing.Size(728, 26);
            this.comboBoxGiocatori.TabIndex = 41;
            this.comboBoxGiocatori.Tag = "";
            this.comboBoxGiocatori.Text = "Scegli il giocatore da svincolare";
            this.comboBoxGiocatori.ValueMember = "NomeLega";
            this.comboBoxGiocatori.SelectedIndexChanged += new System.EventHandler(this.comboBoxGiocatori_SelectedIndexChanged);
            // 
            // SvincolaGiocatore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(827, 465);
            this.Controls.Add(this.comboBoxGiocatori);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.svincolaButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SvincolaGiocatore";
            this.Text = "MyFantalega";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button svincolaButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxGiocatori;
    }
}
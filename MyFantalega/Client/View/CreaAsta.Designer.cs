﻿namespace Client.View
{
    partial class CreaAsta
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOfferta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOffri = new System.Windows.Forms.Button();
            this.buttonIndietro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxGiocatore = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Scegli un Giocatore:";
            // 
            // textBoxOfferta
            // 
            this.textBoxOfferta.Location = new System.Drawing.Point(457, 154);
            this.textBoxOfferta.Name = "textBoxOfferta";
            this.textBoxOfferta.Size = new System.Drawing.Size(64, 22);
            this.textBoxOfferta.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "La tua Offerta:";
            // 
            // buttonOffri
            // 
            this.buttonOffri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOffri.Location = new System.Drawing.Point(457, 211);
            this.buttonOffri.Name = "buttonOffri";
            this.buttonOffri.Size = new System.Drawing.Size(114, 35);
            this.buttonOffri.TabIndex = 3;
            this.buttonOffri.Text = "Offri";
            this.buttonOffri.UseVisualStyleBackColor = true;
            this.buttonOffri.Click += new System.EventHandler(this.buttonOffri_Click);
            // 
            // buttonIndietro
            // 
            this.buttonIndietro.Location = new System.Drawing.Point(55, 21);
            this.buttonIndietro.Name = "buttonIndietro";
            this.buttonIndietro.Size = new System.Drawing.Size(75, 23);
            this.buttonIndietro.TabIndex = 33;
            this.buttonIndietro.Text = "Indietro";
            this.buttonIndietro.UseVisualStyleBackColor = true;
            this.buttonIndietro.Click += new System.EventHandler(this.buttonIndietro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(334, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 37);
            this.label3.TabIndex = 36;
            this.label3.Text = "Crea Asta";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxGiocatore
            // 
            this.comboBoxGiocatore.DisplayMember = "NomeLega";
            this.comboBoxGiocatore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGiocatore.FormattingEnabled = true;
            this.comboBoxGiocatore.Location = new System.Drawing.Point(61, 117);
            this.comboBoxGiocatore.MaxDropDownItems = 15;
            this.comboBoxGiocatore.Name = "comboBoxGiocatore";
            this.comboBoxGiocatore.Size = new System.Drawing.Size(331, 26);
            this.comboBoxGiocatore.TabIndex = 1;
            this.comboBoxGiocatore.Tag = "";
            this.comboBoxGiocatore.Text = "Seleziona il giocatore che vuoi acquistare";
            this.comboBoxGiocatore.ValueMember = "NomeLega";
            // 
            // CreaAsta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxGiocatore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonIndietro);
            this.Controls.Add(this.buttonOffri);
            this.Controls.Add(this.textBoxOfferta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "CreaAsta";
            this.Text = "MyFantalega";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOfferta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOffri;
        private System.Windows.Forms.Button buttonIndietro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxGiocatore;
    }
}
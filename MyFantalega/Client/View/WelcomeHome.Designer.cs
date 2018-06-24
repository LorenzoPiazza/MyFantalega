using ServerLega.Dominio;
using System.Collections.Generic;

namespace Client.View
{
    partial class WelcomeHome
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
            this.components = new System.ComponentModel.Container();
            this.cambioPassButton = new System.Windows.Forms.Button();
            this.creazioneLegaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.indietroButton = new System.Windows.Forms.Button();
            this.textBoxBenvenuto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAccedi = new System.Windows.Forms.Button();
            this.groupBoxLeghe = new System.Windows.Forms.GroupBox();
            this.listBoxLeghe = new System.Windows.Forms.ListBox();
            this.legaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxLeghe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.legaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cambioPassButton
            // 
            this.cambioPassButton.Location = new System.Drawing.Point(55, 388);
            this.cambioPassButton.Name = "cambioPassButton";
            this.cambioPassButton.Size = new System.Drawing.Size(169, 36);
            this.cambioPassButton.TabIndex = 15;
            this.cambioPassButton.Text = "Cambia la tua password";
            this.cambioPassButton.UseVisualStyleBackColor = true;
            this.cambioPassButton.Click += new System.EventHandler(this.cambioPassButton_Click);
            // 
            // creazioneLegaButton
            // 
            this.creazioneLegaButton.Location = new System.Drawing.Point(580, 388);
            this.creazioneLegaButton.Name = "creazioneLegaButton";
            this.creazioneLegaButton.Size = new System.Drawing.Size(163, 36);
            this.creazioneLegaButton.TabIndex = 14;
            this.creazioneLegaButton.Text = "Crea una nuova Lega";
            this.creazioneLegaButton.UseVisualStyleBackColor = true;
            this.creazioneLegaButton.Click += new System.EventHandler(this.creazioneLegaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Le tue leghe:";
            // 
            // indietroButton
            // 
            this.indietroButton.Location = new System.Drawing.Point(55, 21);
            this.indietroButton.Name = "indietroButton";
            this.indietroButton.Size = new System.Drawing.Size(75, 23);
            this.indietroButton.TabIndex = 34;
            this.indietroButton.Text = "Indietro";
            this.indietroButton.UseVisualStyleBackColor = true;
            this.indietroButton.Click += new System.EventHandler(this.indietroButton_Click);
            // 
            // textBoxBenvenuto
            // 
            this.textBoxBenvenuto.Location = new System.Drawing.Point(580, 22);
            this.textBoxBenvenuto.Name = "textBoxBenvenuto";
            this.textBoxBenvenuto.Size = new System.Drawing.Size(183, 22);
            this.textBoxBenvenuto.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 19.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(250, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 37);
            this.label2.TabIndex = 36;
            this.label2.Text = "Welcome Home";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonAccedi
            // 
            this.buttonAccedi.Location = new System.Drawing.Point(346, 271);
            this.buttonAccedi.Name = "buttonAccedi";
            this.buttonAccedi.Size = new System.Drawing.Size(155, 36);
            this.buttonAccedi.TabIndex = 38;
            this.buttonAccedi.Text = "Accedi alla Lega";
            this.buttonAccedi.UseVisualStyleBackColor = true;
            this.buttonAccedi.Click += new System.EventHandler(this.buttonAccedi_Click);
            // 
            // groupBoxLeghe
            // 
            this.groupBoxLeghe.Location = new System.Drawing.Point(346, 129);
            this.groupBoxLeghe.Name = "groupBoxLeghe";
            this.groupBoxLeghe.Size = new System.Drawing.Size(287, 127);
            this.groupBoxLeghe.TabIndex = 37;
            this.groupBoxLeghe.TabStop = false;
            this.groupBoxLeghe.Text = "Le tue Leghe";
            // 
            // listBoxLeghe
            // 
            this.listBoxLeghe.DataSource = this.legaBindingSource1;
            this.listBoxLeghe.FormattingEnabled = true;
            this.listBoxLeghe.ItemHeight = 16;
            this.listBoxLeghe.Location = new System.Drawing.Point(134, 210);
            this.listBoxLeghe.Name = "listBoxLeghe";
            this.listBoxLeghe.Size = new System.Drawing.Size(120, 84);
            this.listBoxLeghe.TabIndex = 39;
            this.listBoxLeghe.ValueMember = "NomeLega";
            this.listBoxLeghe.SelectedIndexChanged += new System.EventHandler(this.listBoxLeghe_SelectedIndexChanged);
            // 
            // legaBindingSource1
            // 
            this.legaBindingSource1.DataSource = typeof(Client.ServerLega.Lega);
            // 
            // comboBoxLeghe
            // 
            this.comboBoxLeghe.DisplayMember = "NomeLega";
            this.comboBoxLeghe.FormattingEnabled = true;
            this.comboBoxLeghe.Location = new System.Drawing.Point(346, 340);
            this.comboBoxLeghe.Name = "comboBoxLeghe";
            this.comboBoxLeghe.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLeghe.TabIndex = 40;
            this.comboBoxLeghe.ValueMember = "NomeLega";
            // 
            // WelcomeHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxLeghe);
            this.Controls.Add(this.listBoxLeghe);
            this.Controls.Add(this.buttonAccedi);
            this.Controls.Add(this.groupBoxLeghe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBenvenuto);
            this.Controls.Add(this.indietroButton);
            this.Controls.Add(this.cambioPassButton);
            this.Controls.Add(this.creazioneLegaButton);
            this.Controls.Add(this.label1);
            this.Name = "WelcomeHome";
            this.Text = "WelcomeHome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WelcomeHome_FormClosed);
            this.Load += new System.EventHandler(this.WelcomeHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.legaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cambioPassButton;
        private System.Windows.Forms.Button creazioneLegaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button indietroButton;
        private System.Windows.Forms.TextBox textBoxBenvenuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAccedi;
        private System.Windows.Forms.GroupBox groupBoxLeghe;
        private System.Windows.Forms.ListBox listBoxLeghe;
        private System.Windows.Forms.ComboBox comboBoxLeghe;
        public System.Windows.Forms.BindingSource legaBindingSource1;
    }
}
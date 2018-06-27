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
            this.cambioPassButton = new System.Windows.Forms.Button();
            this.creazioneLegaButton = new System.Windows.Forms.Button();
            this.indietroButton = new System.Windows.Forms.Button();
            this.textBoxBenvenuto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAccedi = new System.Windows.Forms.Button();
            this.groupBoxLeghe = new System.Windows.Forms.GroupBox();
            this.comboBoxLeghe = new System.Windows.Forms.ComboBox();
            this.groupBoxLeghe.SuspendLayout();
            this.SuspendLayout();
            // 
            // cambioPassButton
            // 
            this.cambioPassButton.Location = new System.Drawing.Point(55, 377);
            this.cambioPassButton.Name = "cambioPassButton";
            this.cambioPassButton.Size = new System.Drawing.Size(104, 50);
            this.cambioPassButton.TabIndex = 15;
            this.cambioPassButton.Text = "Cambia la tua password";
            this.cambioPassButton.UseVisualStyleBackColor = true;
            this.cambioPassButton.Click += new System.EventHandler(this.cambioPassButton_Click);
            // 
            // creazioneLegaButton
            // 
            this.creazioneLegaButton.Location = new System.Drawing.Point(403, 300);
            this.creazioneLegaButton.Name = "creazioneLegaButton";
            this.creazioneLegaButton.Size = new System.Drawing.Size(155, 50);
            this.creazioneLegaButton.TabIndex = 14;
            this.creazioneLegaButton.Text = "Crea una nuova Lega";
            this.creazioneLegaButton.UseVisualStyleBackColor = true;
            this.creazioneLegaButton.Click += new System.EventHandler(this.creazioneLegaButton_Click);
            // 
            // indietroButton
            // 
            this.indietroButton.Location = new System.Drawing.Point(55, 21);
            this.indietroButton.Name = "indietroButton";
            this.indietroButton.Size = new System.Drawing.Size(104, 38);
            this.indietroButton.TabIndex = 34;
            this.indietroButton.Text = "Logout";
            this.indietroButton.UseVisualStyleBackColor = true;
            this.indietroButton.Click += new System.EventHandler(this.indietroButton_Click);
            // 
            // textBoxBenvenuto
            // 
            this.textBoxBenvenuto.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBenvenuto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBenvenuto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBoxBenvenuto.Location = new System.Drawing.Point(552, 40);
            this.textBoxBenvenuto.Name = "textBoxBenvenuto";
            this.textBoxBenvenuto.ReadOnly = true;
            this.textBoxBenvenuto.Size = new System.Drawing.Size(213, 15);
            this.textBoxBenvenuto.TabIndex = 35;
            this.textBoxBenvenuto.TextChanged += new System.EventHandler(this.textBoxBenvenuto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 19.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(259, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 37);
            this.label2.TabIndex = 36;
            this.label2.Text = "Welcome Home";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonAccedi
            // 
            this.buttonAccedi.Location = new System.Drawing.Point(227, 300);
            this.buttonAccedi.Name = "buttonAccedi";
            this.buttonAccedi.Size = new System.Drawing.Size(155, 50);
            this.buttonAccedi.TabIndex = 38;
            this.buttonAccedi.Text = "Accedi alla Lega";
            this.buttonAccedi.UseVisualStyleBackColor = true;
            this.buttonAccedi.Click += new System.EventHandler(this.buttonAccedi_Click);
            // 
            // groupBoxLeghe
            // 
            this.groupBoxLeghe.Controls.Add(this.comboBoxLeghe);
            this.groupBoxLeghe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLeghe.Location = new System.Drawing.Point(227, 109);
            this.groupBoxLeghe.Name = "groupBoxLeghe";
            this.groupBoxLeghe.Size = new System.Drawing.Size(331, 185);
            this.groupBoxLeghe.TabIndex = 37;
            this.groupBoxLeghe.TabStop = false;
            this.groupBoxLeghe.Text = "Le tue Leghe";
            // 
            // comboBoxLeghe
            // 
            this.comboBoxLeghe.DisplayMember = "NomeLega";
            this.comboBoxLeghe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLeghe.FormattingEnabled = true;
            this.comboBoxLeghe.Location = new System.Drawing.Point(0, 46);
            this.comboBoxLeghe.Name = "comboBoxLeghe";
            this.comboBoxLeghe.Size = new System.Drawing.Size(331, 26);
            this.comboBoxLeghe.TabIndex = 40;
            this.comboBoxLeghe.Tag = "";
            this.comboBoxLeghe.Text = "Seleziona qui la lega a cui vuoi accedere";
            this.comboBoxLeghe.ValueMember = "NomeLega";
            this.comboBoxLeghe.SelectedIndexChanged += new System.EventHandler(this.comboBoxLeghe_SelectedIndexChanged);
            // 
            // WelcomeHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAccedi);
            this.Controls.Add(this.groupBoxLeghe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBenvenuto);
            this.Controls.Add(this.indietroButton);
            this.Controls.Add(this.cambioPassButton);
            this.Controls.Add(this.creazioneLegaButton);
            this.Name = "WelcomeHome";
            this.Text = "WelcomeHome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WelcomeHome_FormClosed);
            this.Load += new System.EventHandler(this.WelcomeHome_Load);
            this.groupBoxLeghe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cambioPassButton;
        private System.Windows.Forms.Button creazioneLegaButton;
        private System.Windows.Forms.Button indietroButton;
        private System.Windows.Forms.TextBox textBoxBenvenuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAccedi;
        private System.Windows.Forms.GroupBox groupBoxLeghe;
        private System.Windows.Forms.ComboBox comboBoxLeghe;
    }
}
using Client.Dominio;

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
            this.label1 = new System.Windows.Forms.Label();
            this.legheListBox = new System.Windows.Forms.CheckedListBox();
            this.indietroButton = new System.Windows.Forms.Button();
            this.textBoxBenvenuto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cambioPassButton
            // 
            this.cambioPassButton.Location = new System.Drawing.Point(55, 393);
            this.cambioPassButton.Name = "cambioPassButton";
            this.cambioPassButton.Size = new System.Drawing.Size(169, 31);
            this.cambioPassButton.TabIndex = 15;
            this.cambioPassButton.Text = "Cambia la tua password";
            this.cambioPassButton.UseVisualStyleBackColor = true;
            this.cambioPassButton.Click += new System.EventHandler(this.cambioPassButton_Click);
            // 
            // creazioneLegaButton
            // 
            this.creazioneLegaButton.Location = new System.Drawing.Point(363, 272);
            this.creazioneLegaButton.Name = "creazioneLegaButton";
            this.creazioneLegaButton.Size = new System.Drawing.Size(163, 29);
            this.creazioneLegaButton.TabIndex = 14;
            this.creazioneLegaButton.Text = "Crea una nuova Lega";
            this.creazioneLegaButton.UseVisualStyleBackColor = true;
            this.creazioneLegaButton.Click += new System.EventHandler(this.creazioneLegaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Le tue leghe:";
            // 
            // legheListBox
            // 
            this.legheListBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.legheListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.legheListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legheListBox.FormattingEnabled = true;
            Client.ServerLegaUtente.GestioneUtenteControllerSoapClient myGestioneUtenteController = new Client.ServerLegaUtente.GestioneUtenteControllerSoapClient();
            Lega[] leghe = myGestioneUtenteController.getLeghe(_utenteNav);
            for (int i = 0; i < leghe.Length; i++)
            {
                this.legheListBox.Items.Add(leghe.GetValue(i));           
            }
            this.legheListBox.Location = new System.Drawing.Point(383, 154);
            this.legheListBox.Name = "legheListBox";
            this.legheListBox.Size = new System.Drawing.Size(109, 66);
            this.legheListBox.TabIndex = 16;
            this.legheListBox.SelectedIndexChanged += new System.EventHandler(this.legheListBox_SelectedIndexChanged);
            // 
            // indietroButton
            // 
            this.indietroButton.Location = new System.Drawing.Point(55, 21);
            this.indietroButton.Name = "indietroButton";
            this.indietroButton.Size = new System.Drawing.Size(75, 23);
            this.indietroButton.TabIndex = 34;
            this.indietroButton.Text = "Indietro";
            this.indietroButton.UseVisualStyleBackColor = true;
            this.indietroButton.Click += new System.EventHandler(this.creazioneLegaButton_Click);
            // 
            // textBoxBenvenuto
            // 
            this.textBoxBenvenuto.Location = new System.Drawing.Point(580, 22);
            this.textBoxBenvenuto.Name = "textBoxBenvenuto";
            this.textBoxBenvenuto.Size = new System.Drawing.Size(183, 22);
            this.textBoxBenvenuto.TabIndex = 35;
            this.textBoxBenvenuto.TextChanged += new System.EventHandler(this.textBoxBenvenuto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 19.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(250, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 38);
            this.label2.TabIndex = 36;
            this.label2.Text = "Welcome Home";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WelcomeHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBenvenuto);
            this.Controls.Add(this.indietroButton);
            this.Controls.Add(this.legheListBox);
            this.Controls.Add(this.cambioPassButton);
            this.Controls.Add(this.creazioneLegaButton);
            this.Controls.Add(this.label1);
            this.Name = "WelcomeHome";
            this.Text = "WelcomeHome";
            this.Load += new System.EventHandler(this.WelcomeHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cambioPassButton;
        private System.Windows.Forms.Button creazioneLegaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox legheListBox;
        private System.Windows.Forms.Button indietroButton;
        private System.Windows.Forms.TextBox textBoxBenvenuto;
        private System.Windows.Forms.Label label2;
    }
}
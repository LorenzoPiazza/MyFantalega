namespace Client.View
{
    partial class HomeLegaUtente
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.unioneMercatoButton = new System.Windows.Forms.Button();
            this.squadraTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.indietroButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 57);
            this.button1.TabIndex = 15;
            this.button1.Text = "Proponi uno Scambio";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 57);
            this.button2.TabIndex = 16;
            this.button2.Text = "Rispondi a uno Scambio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(185, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 57);
            this.button3.TabIndex = 17;
            this.button3.Text = "Svincola un Giocatore";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // unioneMercatoButton
            // 
            this.unioneMercatoButton.Location = new System.Drawing.Point(460, 304);
            this.unioneMercatoButton.Name = "unioneMercatoButton";
            this.unioneMercatoButton.Size = new System.Drawing.Size(125, 57);
            this.unioneMercatoButton.TabIndex = 18;
            this.unioneMercatoButton.Text = "Unisciti a un Mercato";
            this.unioneMercatoButton.UseVisualStyleBackColor = true;
            this.unioneMercatoButton.Click += new System.EventHandler(this.unioneMercatoButton_Click);
            // 
            // squadraTextBox
            // 
            this.squadraTextBox.Location = new System.Drawing.Point(382, 120);
            this.squadraTextBox.MaxLength = 32;
            this.squadraTextBox.Name = "squadraTextBox";
            this.squadraTextBox.Size = new System.Drawing.Size(203, 22);
            this.squadraTextBox.TabIndex = 20;
            this.squadraTextBox.TextChanged += new System.EventHandler(this.squadraTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Inserisci il nome della tua squadra:";
            // 
            // indietroButton
            // 
            this.indietroButton.Location = new System.Drawing.Point(33, 21);
            this.indietroButton.Name = "indietroButton";
            this.indietroButton.Size = new System.Drawing.Size(75, 23);
            this.indietroButton.TabIndex = 34;
            this.indietroButton.Text = "Indietro";
            this.indietroButton.UseVisualStyleBackColor = true;
            this.indietroButton.Click += new System.EventHandler(this.indietroButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(265, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 37);
            this.label3.TabIndex = 36;
            this.label3.Text = "Home Lega Utente";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomeLegaUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.indietroButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.squadraTextBox);
            this.Controls.Add(this.unioneMercatoButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "HomeLegaUtente";
            this.Text = "MyFantalega";
            this.Load += new System.EventHandler(this.HomeLegaUtente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button unioneMercatoButton;
        private System.Windows.Forms.TextBox squadraTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button indietroButton;
        private System.Windows.Forms.Label label3;
    }
}
namespace Client.View
{
    partial class CambioPassword
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vecchiaPassTextBox = new System.Windows.Forms.TextBox();
            this.nuovaPassTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.domandaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rispostaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cambiaPassButton = new System.Windows.Forms.Button();
            this.buttonIndietro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(250, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 38);
            this.label3.TabIndex = 37;
            this.label3.Text = "Cambio Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Vecchia Password";
            // 
            // vecchiaPassTextBox
            // 
            this.vecchiaPassTextBox.Location = new System.Drawing.Point(340, 106);
            this.vecchiaPassTextBox.Name = "vecchiaPassTextBox";
            this.vecchiaPassTextBox.Size = new System.Drawing.Size(264, 22);
            this.vecchiaPassTextBox.TabIndex = 39;
            this.vecchiaPassTextBox.TextChanged += new System.EventHandler(this.vecchiaPassTextBox_TextChanged);
            // 
            // nuovaPassTextBox
            // 
            this.nuovaPassTextBox.Location = new System.Drawing.Point(340, 169);
            this.nuovaPassTextBox.Name = "nuovaPassTextBox";
            this.nuovaPassTextBox.Size = new System.Drawing.Size(264, 22);
            this.nuovaPassTextBox.TabIndex = 41;
            this.nuovaPassTextBox.TextChanged += new System.EventHandler(this.nuovaPassTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nuova Password";
            // 
            // domandaTextBox
            // 
            this.domandaTextBox.Location = new System.Drawing.Point(340, 238);
            this.domandaTextBox.Name = "domandaTextBox";
            this.domandaTextBox.Size = new System.Drawing.Size(264, 22);
            this.domandaTextBox.TabIndex = 43;
            this.domandaTextBox.TextChanged += new System.EventHandler(this.domandaTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Domanda di Sicurezza";
            // 
            // rispostaTextBox
            // 
            this.rispostaTextBox.Location = new System.Drawing.Point(340, 308);
            this.rispostaTextBox.Name = "rispostaTextBox";
            this.rispostaTextBox.Size = new System.Drawing.Size(264, 22);
            this.rispostaTextBox.TabIndex = 45;
            this.rispostaTextBox.TextChanged += new System.EventHandler(this.rispostaTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Risposta";
            // 
            // cambiaPassButton
            // 
            this.cambiaPassButton.Location = new System.Drawing.Point(528, 394);
            this.cambiaPassButton.Name = "cambiaPassButton";
            this.cambiaPassButton.Size = new System.Drawing.Size(141, 23);
            this.cambiaPassButton.TabIndex = 46;
            this.cambiaPassButton.Text = "Cambia Password";
            this.cambiaPassButton.UseVisualStyleBackColor = true;
            this.cambiaPassButton.Click += new System.EventHandler(this.cambiaPassButton_Click);
            // 
            // buttonIndietro
            // 
            this.buttonIndietro.Location = new System.Drawing.Point(27, 24);
            this.buttonIndietro.Name = "buttonIndietro";
            this.buttonIndietro.Size = new System.Drawing.Size(84, 26);
            this.buttonIndietro.TabIndex = 47;
            this.buttonIndietro.Text = "Indietro";
            this.buttonIndietro.UseVisualStyleBackColor = true;
            this.buttonIndietro.Click += new System.EventHandler(this.buttonIndietro_Click);
            // 
            // CambioPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIndietro);
            this.Controls.Add(this.cambiaPassButton);
            this.Controls.Add(this.rispostaTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.domandaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nuovaPassTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vecchiaPassTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "CambioPassword";
            this.Text = "CambioPassword";
            this.Load += new System.EventHandler(this.CambioPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vecchiaPassTextBox;
        private System.Windows.Forms.TextBox nuovaPassTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox domandaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rispostaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cambiaPassButton;
        private System.Windows.Forms.Button buttonIndietro;
    }
}
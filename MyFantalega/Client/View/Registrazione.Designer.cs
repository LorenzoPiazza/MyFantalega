namespace Client.View
{
    partial class Registrazione
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDomanda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRisposta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonRegistrati = new System.Windows.Forms.Button();
            this.buttonIndietro = new System.Windows.Forms.Button();
            this.passwordAlert = new System.Windows.Forms.Label();
            this.emailAlert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 19.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(398, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 74);
            this.label2.TabIndex = 2;
            this.label2.Text = "MyFantalega\r\nRegistrazione";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(279, 130);
            this.textBoxUsername.MaxLength = 20;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(505, 24);
            this.textBoxUsername.TabIndex = 5;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(148, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:\r\n";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(279, 191);
            this.textBoxEmail.MaxLength = 80;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(505, 24);
            this.textBoxEmail.TabIndex = 7;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(173, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-mail:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(279, 256);
            this.textBoxPassword.MaxLength = 20;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(505, 24);
            this.textBoxPassword.TabIndex = 9;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(143, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Risposta:";
            // 
            // textBoxDomanda
            // 
            this.textBoxDomanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDomanda.Location = new System.Drawing.Point(279, 317);
            this.textBoxDomanda.Name = "textBoxDomanda";
            this.textBoxDomanda.Size = new System.Drawing.Size(505, 24);
            this.textBoxDomanda.TabIndex = 11;
            this.textBoxDomanda.Text = "Il nome del tuo migliore amico d\'infanzia?";
            this.textBoxDomanda.TextChanged += new System.EventHandler(this.textBoxDomanda_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(59, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Domanda di sicurezza:";
            // 
            // textBoxRisposta
            // 
            this.textBoxRisposta.Location = new System.Drawing.Point(279, 378);
            this.textBoxRisposta.MaxLength = 30;
            this.textBoxRisposta.Name = "textBoxRisposta";
            this.textBoxRisposta.Size = new System.Drawing.Size(505, 24);
            this.textBoxRisposta.TabIndex = 13;
            this.textBoxRisposta.TextChanged += new System.EventHandler(this.textBoxRisposta_TextChanged);
            this.textBoxRisposta.Leave += new System.EventHandler(this.textBoxRisposta_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(81, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password:\r\n(Almeno 8 caratteri)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonRegistrati
            // 
            this.buttonRegistrati.Location = new System.Drawing.Point(681, 431);
            this.buttonRegistrati.Name = "buttonRegistrati";
            this.buttonRegistrati.Size = new System.Drawing.Size(102, 34);
            this.buttonRegistrati.TabIndex = 14;
            this.buttonRegistrati.Text = "Registrati";
            this.buttonRegistrati.UseVisualStyleBackColor = true;
            this.buttonRegistrati.Click += new System.EventHandler(this.buttonRegistrati_Click);
            // 
            // buttonIndietro
            // 
            this.buttonIndietro.Location = new System.Drawing.Point(62, 24);
            this.buttonIndietro.Name = "buttonIndietro";
            this.buttonIndietro.Size = new System.Drawing.Size(84, 26);
            this.buttonIndietro.TabIndex = 34;
            this.buttonIndietro.Text = "Indietro";
            this.buttonIndietro.UseVisualStyleBackColor = true;
            this.buttonIndietro.Click += new System.EventHandler(this.buttonIndietro_Click);
            // 
            // passwordAlert
            // 
            this.passwordAlert.AutoSize = true;
            this.passwordAlert.ForeColor = System.Drawing.Color.DarkRed;
            this.passwordAlert.Location = new System.Drawing.Point(796, 259);
            this.passwordAlert.Name = "passwordAlert";
            this.passwordAlert.Size = new System.Drawing.Size(163, 18);
            this.passwordAlert.TabIndex = 35;
            this.passwordAlert.Text = "Password troppo corta!";
            // 
            // emailAlert
            // 
            this.emailAlert.AutoSize = true;
            this.emailAlert.ForeColor = System.Drawing.Color.DarkRed;
            this.emailAlert.Location = new System.Drawing.Point(796, 195);
            this.emailAlert.Name = "emailAlert";
            this.emailAlert.Size = new System.Drawing.Size(181, 18);
            this.emailAlert.TabIndex = 36;
            this.emailAlert.Text = "Indirizzo e-mail non valido!";
            // 
            // Registrazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(988, 510);
            this.Controls.Add(this.emailAlert);
            this.Controls.Add(this.passwordAlert);
            this.Controls.Add(this.buttonIndietro);
            this.Controls.Add(this.buttonRegistrati);
            this.Controls.Add(this.textBoxRisposta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDomanda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Registrazione";
            this.Text = "Registrazione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDomanda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRisposta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonRegistrati;
        private System.Windows.Forms.Button buttonIndietro;
        private System.Windows.Forms.Label passwordAlert;
        private System.Windows.Forms.Label emailAlert;
    }
}
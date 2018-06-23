namespace Client.View
{
    partial class CreazioneLega
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
            this.NomeDellaLegatextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NPartTrackBar = new System.Windows.Forms.TrackBar();
            this.indietroButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CreaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NPartTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // NomeDellaLegatextBox
            // 
            this.NomeDellaLegatextBox.Location = new System.Drawing.Point(271, 137);
            this.NomeDellaLegatextBox.MaxLength = 20;
            this.NomeDellaLegatextBox.Name = "NomeDellaLegatextBox";
            this.NomeDellaLegatextBox.Size = new System.Drawing.Size(449, 22);
            this.NomeDellaLegatextBox.TabIndex = 1;
            this.NomeDellaLegatextBox.TextChanged += new System.EventHandler(this.NomeDellaLegatextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(70, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome della Lega:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Numero di partecipanti:";
            // 
            // NPartTrackBar
            // 
            this.NPartTrackBar.LargeChange = 1;
            this.NPartTrackBar.Location = new System.Drawing.Point(271, 199);
            this.NPartTrackBar.Maximum = 12;
            this.NPartTrackBar.Minimum = 4;
            this.NPartTrackBar.Name = "NPartTrackBar";
            this.NPartTrackBar.Size = new System.Drawing.Size(449, 56);
            this.NPartTrackBar.TabIndex = 2;
            this.NPartTrackBar.Value = 4;
            this.NPartTrackBar.Scroll += new System.EventHandler(this.NPartTrackBar_Scroll);
            // 
            // indietroButton
            // 
            this.indietroButton.Location = new System.Drawing.Point(38, 21);
            this.indietroButton.Name = "indietroButton";
            this.indietroButton.Size = new System.Drawing.Size(75, 23);
            this.indietroButton.TabIndex = 34;
            this.indietroButton.Text = "Indietro";
            this.indietroButton.UseVisualStyleBackColor = true;
            this.indietroButton.Click += new System.EventHandler(this.indietroButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(280, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 37);
            this.label2.TabIndex = 36;
            this.label2.Text = "Creazione Lega";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreaButton
            // 
            this.CreaButton.Location = new System.Drawing.Point(271, 289);
            this.CreaButton.Name = "CreaButton";
            this.CreaButton.Size = new System.Drawing.Size(104, 47);
            this.CreaButton.TabIndex = 3;
            this.CreaButton.Text = "Crea";
            this.CreaButton.UseVisualStyleBackColor = true;
            this.CreaButton.Click += new System.EventHandler(this.CreaButton_Click);
            // 
            // CreazioneLega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreaButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.indietroButton);
            this.Controls.Add(this.NPartTrackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NomeDellaLegatextBox);
            this.Controls.Add(this.label1);
            this.Name = "CreazioneLega";
            this.Text = "MyFantalega";
            this.Load += new System.EventHandler(this.CreazioneLega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NPartTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomeDellaLegatextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar NPartTrackBar;
        private System.Windows.Forms.Button indietroButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreaButton;
    }
}
namespace ofis2
{
    partial class frmGiris
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
            this.btngiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKad = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btngiris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btngiris.Location = new System.Drawing.Point(314, 249);
            this.btngiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(141, 48);
            this.btngiris.TabIndex = 9;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(217, 175);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(236, 24);
            this.txtSifre.TabIndex = 8;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // txtKad
            // 
            this.txtKad.Location = new System.Drawing.Point(217, 101);
            this.txtKad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKad.Name = "txtKad";
            this.txtKad.Size = new System.Drawing.Size(236, 24);
            this.txtKad.TabIndex = 7;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(111, 185);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(38, 18);
            this.lblSifre.TabIndex = 6;
            this.lblSifre.Text = "Şifre";
            // 
            // lblKad
            // 
            this.lblKad.AutoSize = true;
            this.lblKad.Location = new System.Drawing.Point(111, 101);
            this.lblKad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKad.Name = "lblKad";
            this.lblKad.Size = new System.Drawing.Size(86, 18);
            this.lblKad.TabIndex = 5;
            this.lblKad.Text = "Kullanıcı Adı";
            // 
            // frmGiris
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(615, 367);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKad);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKad;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKad;
    }
}


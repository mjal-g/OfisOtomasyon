namespace ofis2
{
    partial class Proje
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
            this.grpProje = new System.Windows.Forms.GroupBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.dateBas = new System.Windows.Forms.DateTimePicker();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblBit = new System.Windows.Forms.Label();
            this.lblBas = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.dataProje = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStajyer = new System.Windows.Forms.Label();
            this.cmbStajyer = new System.Windows.Forms.ComboBox();
            this.grpProje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProje)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProje
            // 
            this.grpProje.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpProje.Controls.Add(this.cmbStajyer);
            this.grpProje.Controls.Add(this.lblStajyer);
            this.grpProje.Controls.Add(this.lblAd);
            this.grpProje.Controls.Add(this.btnKaydet);
            this.grpProje.Controls.Add(this.dateBitis);
            this.grpProje.Controls.Add(this.dateBas);
            this.grpProje.Controls.Add(this.txtAciklama);
            this.grpProje.Controls.Add(this.txtAd);
            this.grpProje.Controls.Add(this.lblBit);
            this.grpProje.Controls.Add(this.lblBas);
            this.grpProje.Controls.Add(this.lblAciklama);
            this.grpProje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpProje.Location = new System.Drawing.Point(22, 12);
            this.grpProje.Name = "grpProje";
            this.grpProje.Size = new System.Drawing.Size(397, 504);
            this.grpProje.TabIndex = 0;
            this.grpProje.TabStop = false;
            this.grpProje.Text = "Proje";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(43, 147);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(67, 18);
            this.lblAd.TabIndex = 11;
            this.lblAd.Text = "Proje Adı";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKaydet.Location = new System.Drawing.Point(239, 431);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(119, 46);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dateBitis
            // 
            this.dateBitis.Location = new System.Drawing.Point(174, 264);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(184, 24);
            this.dateBitis.TabIndex = 9;
            // 
            // dateBas
            // 
            this.dateBas.Location = new System.Drawing.Point(174, 205);
            this.dateBas.Name = "dateBas";
            this.dateBas.Size = new System.Drawing.Size(184, 24);
            this.dateBas.TabIndex = 8;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(174, 319);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(184, 87);
            this.txtAciklama.TabIndex = 7;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(174, 141);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(184, 24);
            this.txtAd.TabIndex = 1;
            // 
            // lblBit
            // 
            this.lblBit.AutoSize = true;
            this.lblBit.Location = new System.Drawing.Point(43, 264);
            this.lblBit.Name = "lblBit";
            this.lblBit.Size = new System.Drawing.Size(75, 18);
            this.lblBit.TabIndex = 5;
            this.lblBit.Text = "Proje Bitis";
            // 
            // lblBas
            // 
            this.lblBas.AutoSize = true;
            this.lblBas.Location = new System.Drawing.Point(43, 211);
            this.lblBas.Name = "lblBas";
            this.lblBas.Size = new System.Drawing.Size(111, 18);
            this.lblBas.TabIndex = 4;
            this.lblBas.Text = "Proje Başlangıç";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(43, 319);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(118, 18);
            this.lblAciklama.TabIndex = 3;
            this.lblAciklama.Text = "Proje Açıklaması";
            // 
            // dataProje
            // 
            this.dataProje.AllowUserToOrderColumns = true;
            this.dataProje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProje.ContextMenuStrip = this.contextMenuStrip1;
            this.dataProje.Location = new System.Drawing.Point(435, 16);
            this.dataProje.Name = "dataProje";
            this.dataProje.Size = new System.Drawing.Size(403, 500);
            this.dataProje.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // lblStajyer
            // 
            this.lblStajyer.AutoSize = true;
            this.lblStajyer.Location = new System.Drawing.Point(43, 88);
            this.lblStajyer.Name = "lblStajyer";
            this.lblStajyer.Size = new System.Drawing.Size(53, 18);
            this.lblStajyer.TabIndex = 12;
            this.lblStajyer.Text = "Stajyer";
            // 
            // cmbStajyer
            // 
            this.cmbStajyer.FormattingEnabled = true;
            this.cmbStajyer.Location = new System.Drawing.Point(174, 85);
            this.cmbStajyer.Name = "cmbStajyer";
            this.cmbStajyer.Size = new System.Drawing.Size(186, 26);
            this.cmbStajyer.TabIndex = 13;
            // 
            // Proje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(850, 559);
            this.Controls.Add(this.dataProje);
            this.Controls.Add(this.grpProje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proje";
            this.Text = "Proje";
            this.Load += new System.EventHandler(this.Proje_Load);
            this.grpProje.ResumeLayout(false);
            this.grpProje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProje)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProje;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblBas;
        private System.Windows.Forms.Label lblBit;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private System.Windows.Forms.DateTimePicker dateBas;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dataProje;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.Label lblStajyer;
        private System.Windows.Forms.ComboBox cmbStajyer;
    }
}
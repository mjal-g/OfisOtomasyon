namespace ofis2
{
    partial class GelirGider
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
            this.gBoxGelir = new System.Windows.Forms.GroupBox();
            this.cmbDonem = new System.Windows.Forms.ComboBox();
            this.lblDonem = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblGad = new System.Windows.Forms.Label();
            this.dtpKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.numMiktar = new System.Windows.Forms.NumericUpDown();
            this.txtGiderAd = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.dataGider = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBoxGelir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGider)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxGelir
            // 
            this.gBoxGelir.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gBoxGelir.Controls.Add(this.cmbDonem);
            this.gBoxGelir.Controls.Add(this.lblDonem);
            this.gBoxGelir.Controls.Add(this.btnKaydet);
            this.gBoxGelir.Controls.Add(this.lblGad);
            this.gBoxGelir.Controls.Add(this.dtpKayitTarihi);
            this.gBoxGelir.Controls.Add(this.txtAciklama);
            this.gBoxGelir.Controls.Add(this.numMiktar);
            this.gBoxGelir.Controls.Add(this.txtGiderAd);
            this.gBoxGelir.Controls.Add(this.lblAciklama);
            this.gBoxGelir.Controls.Add(this.lblTarih);
            this.gBoxGelir.Controls.Add(this.lblMiktar);
            this.gBoxGelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBoxGelir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gBoxGelir.Location = new System.Drawing.Point(12, 12);
            this.gBoxGelir.Name = "gBoxGelir";
            this.gBoxGelir.Size = new System.Drawing.Size(383, 526);
            this.gBoxGelir.TabIndex = 1;
            this.gBoxGelir.TabStop = false;
            this.gBoxGelir.Text = "Gelir Gider İşlemleri";
            // 
            // cmbDonem
            // 
            this.cmbDonem.FormattingEnabled = true;
            this.cmbDonem.Location = new System.Drawing.Point(127, 199);
            this.cmbDonem.Name = "cmbDonem";
            this.cmbDonem.Size = new System.Drawing.Size(176, 24);
            this.cmbDonem.TabIndex = 14;
            // 
            // lblDonem
            // 
            this.lblDonem.AutoSize = true;
            this.lblDonem.Location = new System.Drawing.Point(24, 199);
            this.lblDonem.Name = "lblDonem";
            this.lblDonem.Size = new System.Drawing.Size(52, 16);
            this.lblDonem.TabIndex = 13;
            this.lblDonem.Text = "Dönem";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnKaydet.Location = new System.Drawing.Point(245, 429);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(109, 42);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblGad
            // 
            this.lblGad.AutoSize = true;
            this.lblGad.Location = new System.Drawing.Point(24, 60);
            this.lblGad.Name = "lblGad";
            this.lblGad.Size = new System.Drawing.Size(64, 16);
            this.lblGad.TabIndex = 11;
            this.lblGad.Text = "Gider Adı";
            // 
            // dtpKayitTarihi
            // 
            this.dtpKayitTarihi.Location = new System.Drawing.Point(127, 253);
            this.dtpKayitTarihi.Name = "dtpKayitTarihi";
            this.dtpKayitTarihi.Size = new System.Drawing.Size(176, 22);
            this.dtpKayitTarihi.TabIndex = 2;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(112, 308);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(242, 96);
            this.txtAciklama.TabIndex = 10;
            this.txtAciklama.Text = "";
            // 
            // numMiktar
            // 
            this.numMiktar.Location = new System.Drawing.Point(127, 129);
            this.numMiktar.Name = "numMiktar";
            this.numMiktar.Size = new System.Drawing.Size(176, 22);
            this.numMiktar.TabIndex = 9;
            // 
            // txtGiderAd
            // 
            this.txtGiderAd.Location = new System.Drawing.Point(127, 60);
            this.txtGiderAd.Name = "txtGiderAd";
            this.txtGiderAd.Size = new System.Drawing.Size(176, 22);
            this.txtGiderAd.TabIndex = 6;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(24, 308);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(64, 16);
            this.lblAciklama.TabIndex = 5;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(24, 259);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(97, 16);
            this.lblTarih.TabIndex = 4;
            this.lblTarih.Text = "Ödenme Tarihi";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(24, 129);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(39, 16);
            this.lblMiktar.TabIndex = 3;
            this.lblMiktar.Text = "Tutar";
            // 
            // dataGider
            // 
            this.dataGider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGider.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGider.Location = new System.Drawing.Point(412, 21);
            this.dataGider.Name = "dataGider";
            this.dataGider.Size = new System.Drawing.Size(425, 284);
            this.dataGider.TabIndex = 2;
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
            // GelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(859, 550);
            this.Controls.Add(this.dataGider);
            this.Controls.Add(this.gBoxGelir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GelirGider";
            this.Text = "GelirGider";
            this.Load += new System.EventHandler(this.GelirGider_Load);
            this.gBoxGelir.ResumeLayout(false);
            this.gBoxGelir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGider)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxGelir;
        private System.Windows.Forms.ComboBox cmbDonem;
        private System.Windows.Forms.Label lblDonem;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblGad;
        private System.Windows.Forms.DateTimePicker dtpKayitTarihi;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.NumericUpDown numMiktar;
        private System.Windows.Forms.TextBox txtGiderAd;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.DataGridView dataGider;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
    }
}
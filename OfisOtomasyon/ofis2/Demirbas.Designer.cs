namespace ofis2
{
    partial class Demirbas
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
            this.grpDemirbas = new System.Windows.Forms.GroupBox();
            this.btnDemirbasEkle = new System.Windows.Forms.Button();
            this.numAdet = new System.Windows.Forms.NumericUpDown();
            this.txtEsyaAdi = new System.Windows.Forms.TextBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblEsyaAdi = new System.Windows.Forms.Label();
            this.dataDemirbas = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDemirbas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDemirbas)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDemirbas
            // 
            this.grpDemirbas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grpDemirbas.Controls.Add(this.btnDemirbasEkle);
            this.grpDemirbas.Controls.Add(this.numAdet);
            this.grpDemirbas.Controls.Add(this.txtEsyaAdi);
            this.grpDemirbas.Controls.Add(this.lblAdet);
            this.grpDemirbas.Controls.Add(this.lblEsyaAdi);
            this.grpDemirbas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpDemirbas.Location = new System.Drawing.Point(51, 36);
            this.grpDemirbas.Name = "grpDemirbas";
            this.grpDemirbas.Size = new System.Drawing.Size(404, 249);
            this.grpDemirbas.TabIndex = 4;
            this.grpDemirbas.TabStop = false;
            this.grpDemirbas.Text = "Demirbaş İşlemleri";
            // 
            // btnDemirbasEkle
            // 
            this.btnDemirbasEkle.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnDemirbasEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDemirbasEkle.Location = new System.Drawing.Point(159, 171);
            this.btnDemirbasEkle.Name = "btnDemirbasEkle";
            this.btnDemirbasEkle.Size = new System.Drawing.Size(90, 35);
            this.btnDemirbasEkle.TabIndex = 7;
            this.btnDemirbasEkle.Text = "Kaydet";
            this.btnDemirbasEkle.UseVisualStyleBackColor = false;
            this.btnDemirbasEkle.Click += new System.EventHandler(this.btnDemirbasEkle_Click);
            // 
            // numAdet
            // 
            this.numAdet.Location = new System.Drawing.Point(109, 114);
            this.numAdet.Name = "numAdet";
            this.numAdet.Size = new System.Drawing.Size(140, 24);
            this.numAdet.TabIndex = 5;
            // 
            // txtEsyaAdi
            // 
            this.txtEsyaAdi.Location = new System.Drawing.Point(109, 54);
            this.txtEsyaAdi.Name = "txtEsyaAdi";
            this.txtEsyaAdi.Size = new System.Drawing.Size(140, 24);
            this.txtEsyaAdi.TabIndex = 3;
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(35, 116);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(37, 18);
            this.lblAdet.TabIndex = 2;
            this.lblAdet.Text = "Adet";
            // 
            // lblEsyaAdi
            // 
            this.lblEsyaAdi.AutoSize = true;
            this.lblEsyaAdi.Location = new System.Drawing.Point(35, 57);
            this.lblEsyaAdi.Name = "lblEsyaAdi";
            this.lblEsyaAdi.Size = new System.Drawing.Size(65, 18);
            this.lblEsyaAdi.TabIndex = 1;
            this.lblEsyaAdi.Text = "Eşya Adı";
            // 
            // dataDemirbas
            // 
            this.dataDemirbas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDemirbas.ContextMenuStrip = this.contextMenuStrip1;
            this.dataDemirbas.Location = new System.Drawing.Point(482, 36);
            this.dataDemirbas.Name = "dataDemirbas";
            this.dataDemirbas.Size = new System.Drawing.Size(342, 249);
            this.dataDemirbas.StandardTab = true;
            this.dataDemirbas.TabIndex = 5;
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
            // Demirbas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(859, 550);
            this.Controls.Add(this.dataDemirbas);
            this.Controls.Add(this.grpDemirbas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Demirbas";
            this.Text = "Demirbas";
            this.Load += new System.EventHandler(this.Demirbas_Load);
            this.grpDemirbas.ResumeLayout(false);
            this.grpDemirbas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDemirbas)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDemirbas;
        private System.Windows.Forms.Button btnDemirbasEkle;
        private System.Windows.Forms.NumericUpDown numAdet;
        private System.Windows.Forms.TextBox txtEsyaAdi;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblEsyaAdi;
        private System.Windows.Forms.DataGridView dataDemirbas;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;

    }
}
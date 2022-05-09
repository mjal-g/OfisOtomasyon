namespace ofis2
{
    partial class frmIslemler
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btncikis = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stajyerİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stajyerEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.projeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirGiderİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demirbaşBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAnaSayfa = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlMenu.Controls.Add(this.btncikis);
            this.pnlMenu.Controls.Add(this.menuStrip1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(855, 92);
            this.pnlMenu.TabIndex = 9;
            // 
            // btncikis
            // 
            this.btncikis.AutoEllipsis = true;
            this.btncikis.BackColor = System.Drawing.SystemColors.Info;
            this.btncikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.Location = new System.Drawing.Point(805, 31);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(38, 35);
            this.btncikis.TabIndex = 1;
            this.btncikis.Text = "çıkış";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stajyerİşlemleriToolStripMenuItem,
            this.gelirGiderİşlemleriToolStripMenuItem,
            this.demirbaşBilgileriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(228, 18);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(550, 59);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stajyerİşlemleriToolStripMenuItem
            // 
            this.stajyerİşlemleriToolStripMenuItem.AutoSize = false;
            this.stajyerİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stajyerEkleToolStripMenuItem,
            this.toolStripSeparator1,
            this.projeToolStripMenuItem});
            this.stajyerİşlemleriToolStripMenuItem.Name = "stajyerİşlemleriToolStripMenuItem";
            this.stajyerİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(150, 55);
            this.stajyerİşlemleriToolStripMenuItem.Text = "Stajyer İşlemleri";
            // 
            // stajyerEkleToolStripMenuItem
            // 
            this.stajyerEkleToolStripMenuItem.Name = "stajyerEkleToolStripMenuItem";
            this.stajyerEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stajyerEkleToolStripMenuItem.Text = "Stajyer Kayıt";
            this.stajyerEkleToolStripMenuItem.Click += new System.EventHandler(this.stajyerEkleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // projeToolStripMenuItem
            // 
            this.projeToolStripMenuItem.Name = "projeToolStripMenuItem";
            this.projeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.projeToolStripMenuItem.Text = "Proje";
            this.projeToolStripMenuItem.Click += new System.EventHandler(this.projeToolStripMenuItem_Click);
            // 
            // gelirGiderİşlemleriToolStripMenuItem
            // 
            this.gelirGiderİşlemleriToolStripMenuItem.AutoSize = false;
            this.gelirGiderİşlemleriToolStripMenuItem.Name = "gelirGiderİşlemleriToolStripMenuItem";
            this.gelirGiderİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(150, 55);
            this.gelirGiderİşlemleriToolStripMenuItem.Text = "Gelir-Gider İşlemleri";
            this.gelirGiderİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.gelirGiderİşlemleriToolStripMenuItem_Click);
            // 
            // demirbaşBilgileriToolStripMenuItem
            // 
            this.demirbaşBilgileriToolStripMenuItem.AutoSize = false;
            this.demirbaşBilgileriToolStripMenuItem.Name = "demirbaşBilgileriToolStripMenuItem";
            this.demirbaşBilgileriToolStripMenuItem.Size = new System.Drawing.Size(150, 55);
            this.demirbaşBilgileriToolStripMenuItem.Text = "Demirbaş Bilgileri";
            this.demirbaşBilgileriToolStripMenuItem.Click += new System.EventHandler(this.demirbaşBilgileriToolStripMenuItem_Click);
            // 
            // pnlAnaSayfa
            // 
            this.pnlAnaSayfa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlAnaSayfa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAnaSayfa.Location = new System.Drawing.Point(0, 92);
            this.pnlAnaSayfa.Name = "pnlAnaSayfa";
            this.pnlAnaSayfa.Size = new System.Drawing.Size(855, 554);
            this.pnlAnaSayfa.TabIndex = 2;
            this.pnlAnaSayfa.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAnaSayfa_Paint);
            // 
            // frmIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 646);
            this.Controls.Add(this.pnlAnaSayfa);
            this.Controls.Add(this.pnlMenu);
            this.IsMdiContainer = true;
            this.Name = "frmIslemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlemler";
            this.pnlMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stajyerİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stajyerEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem projeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirGiderİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demirbaşBilgileriToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAnaSayfa;
    }
}
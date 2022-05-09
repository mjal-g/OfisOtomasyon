using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ofis2
{
    public partial class frmIslemler : Form
    {
        public frmIslemler()
        {
            InitializeComponent();
        }

        private void stajyerEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StajyerKayit s = new StajyerKayit();
            s.MdiParent = this;
            s.Dock = DockStyle.Fill;
            pnlAnaSayfa.Visible = false;
            s.Show();

        }

        private void projeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proje p = new Proje();
            p.MdiParent = this;
            p.Dock = DockStyle.Fill;
            pnlAnaSayfa.Visible = false;
            p.Show();
        }

        private void gelirGiderİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GelirGider g = new GelirGider();
            g.MdiParent = this;
            g.Dock = DockStyle.Fill;
            pnlAnaSayfa.Visible = false;
            g.Show();
        }

        private void demirbaşBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Demirbas d = new Demirbas();
            d.MdiParent = this;
            d.Dock = DockStyle.Fill;
            pnlAnaSayfa.Visible = false;
            d.Show();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void pnlAnaSayfa_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

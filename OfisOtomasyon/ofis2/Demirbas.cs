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
    public partial class Demirbas : Form
    {
        public Demirbas()
        {
            InitializeComponent();
        }
        OfisDBEntities db = new OfisDBEntities();
        void listele()
        {
            dataDemirbas.DataSource = db.Demirbas.ToList();
        }
        private void Demirbas_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnDemirbasEkle_Click(object sender, EventArgs e)
        {
            Demirba malzeme = new Demirba();
            malzeme.esyaAdi = txtEsyaAdi.Text;
            malzeme.adet = Convert.ToInt32(numAdet.Value);
            db.Demirbas.Add(malzeme);
            db.SaveChanges();
            listele();
            txtEsyaAdi.Text = "";
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataDemirbas.CurrentRow.Cells[0].Value);
            var sil = db.Demirbas.Where(x => x.demirbasID == id).FirstOrDefault();
            db.Demirbas.Remove(sil);
            db.SaveChanges();
            listele();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataDemirbas.CurrentRow.Cells[0].Value);
            var güncelle = db.Demirbas.Where(x => x.demirbasID == id).FirstOrDefault();
            güncelle.esyaAdi = txtEsyaAdi.Text;
            güncelle.adet = (int)numAdet.Value;
            db.SaveChanges();
            listele();
        }

    }
}

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
    public partial class GelirGider : Form
    {
        public GelirGider()
        {
            InitializeComponent();
        }
        OfisDBEntities db = new OfisDBEntities();
        void listele()
        {
            dataGider.DataSource = db.Giders.ToList();
        }
        private void GelirGider_Load(object sender, EventArgs e)
        {
            cmbDonem.DataSource = Enum.GetValues(typeof(enumDonem));
            listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Gider g = new Gider();
            g.giderAdi = txtGiderAd.Text;
            g.giderMiktari = numMiktar.Value.ToString();
            g.tarih = dtpKayitTarihi.Value;
            g.aciklama = txtAciklama.Text;
            db.Giders.Add(g);
            db.SaveChanges();
            listele();
            txtGiderAd.Text = "";
            txtAciklama.Text = "";
            dtpKayitTarihi.Value = DateTime.Now;

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGider.CurrentRow.Cells[0].Value);
            var sil = db.Giders.Where(x => x.giderID == id).FirstOrDefault();
            db.Giders.Remove(sil);
            db.SaveChanges();
            listele();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGider.CurrentRow.Cells[0].Value);
            var güncelle = db.Giders.Where(x => x.giderID == id).FirstOrDefault();
            güncelle.giderAdi = txtGiderAd.Text;
            güncelle.aciklama = txtAciklama.Text;
            güncelle.donem = cmbDonem.SelectedValue.ToString();
            güncelle.tarih = dtpKayitTarihi.Value;
            db.SaveChanges();
            listele();
        }

    }
}

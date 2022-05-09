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
    public partial class Proje : Form
    {
        public Proje()
        {
            InitializeComponent();
        }
        OfisDBEntities db = new OfisDBEntities();
        void listele()
        {
            dataProje.DataSource = db.Projelers.ToList();

        }
        private void Proje_Load(object sender, EventArgs e)
        {
            listele();
            dataProje.Columns[0].Visible = false;
            dataProje.Columns[1].HeaderText = "Proje Adı";
            dataProje.Columns[2].HeaderText = "Proje Başlangıç";
            dataProje.Columns[3].HeaderText = "Proje Bitiş";
            dataProje.Columns[4].HeaderText = "Proje Açıklaması";
            dataProje.Columns[6].Visible = false;
            cmbStajyer.DataSource = db.Stajyers.ToList();
            cmbStajyer.DisplayMember = "adsoyad";
            cmbStajyer.ValueMember = "stajyerID";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        { 
            Projeler p = new Projeler();
            p.stajyerID = (int)cmbStajyer.SelectedValue;
            p.projeAdi = txtAd.Text;
            p.projeAciklamasi = txtAciklama.Text;
            p.projeBaslangic = dateBas.Value;
            p.projeBitis = dateBitis.Value;
            db.Projelers.Add(p);
            db.SaveChanges();
            listele();
            txtAd.Text = "";
            txtAciklama.Text = "";
            dateBitis.Value = DateTime.Now;
            dateBas.Value = DateTime.Now;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dataProje.CurrentRow.Cells[0].Value;
            var sil = db.Projelers.Where(x => x.projeID == id).FirstOrDefault();
            db.Projelers.Remove(sil);
            db.SaveChanges();
            listele();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dataProje.CurrentRow.Cells[0].Value;
            var güncelle = db.Projelers.Where(x => x.projeID == id).FirstOrDefault();
            güncelle.projeAdi = txtAd.Text;
            güncelle.projeAciklamasi = txtAciklama.Text;
            güncelle.projeBaslangic = dateBas.Value;
            güncelle.projeBitis = dateBitis.Value;
            db.SaveChanges();
            listele();
          
        }

    }
}

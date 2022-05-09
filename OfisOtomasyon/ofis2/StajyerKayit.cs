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
    public partial class StajyerKayit : Form
    {
        public StajyerKayit()
        {
            InitializeComponent();
        }
        OfisDBEntities db = new OfisDBEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                List<Stajyer> stajyerler = new List<Stajyer>();
                Stajyer s = new Stajyer();
                s.adsoyad = txtAd.Text;
                s.TCNO = txtTc.Text;
                s.TC = s.TCNO;
                foreach(var s1 in stajyerler)
                {
                    if(s1.TC==txtTc.Text)
                    {
                        throw new Exception("Farklı bir Tc giriniz");
                    }

                }
                s.telefonNo = txtTelNo.Text;
                s.universite = txtÜniversite.Text;
                s.eposta = txtEposta.Text;
                s.stajBaslangic = dtpBaslangic.Value;
                s.stajBitis = dtpBitis.Value;
                db.Stajyers.Add(s);
                db.SaveChanges();
                listele();
                txtAd.Text = "";
                txtTc.Text = "";
                txtTelNo.Text = "";
                txtÜniversite.Text = "";
                txtEposta.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void listele()
        {
            dataStajyer.DataSource = db.Stajyers.ToList();
        }

        private void StajyerKayit_Load(object sender, EventArgs e)
        {
            
            listele();
            dataStajyer.Columns[0].Visible = false;
            dataStajyer.Columns[8].Visible = false;
            dataStajyer.Columns[9].Visible = false;
            dataStajyer.Columns[10].Visible = false;
            dataStajyer.Columns[11].Visible = false;
            dataStajyer.Columns[1].HeaderText = "AD";
            dataStajyer.Columns[2].HeaderText = "TC";
            dataStajyer.Columns[3].HeaderText = "TELEFON";
            dataStajyer.Columns[4].HeaderText = "E-POSTA";
            dataStajyer.Columns[5].HeaderText = "ÜNİVERSİTE";
            dataStajyer.Columns[6].HeaderText = "BAŞLAMA";
            dataStajyer.Columns[7].HeaderText = "BİTİŞ";

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataStajyer.CurrentRow.Cells[0].Value);
            var sil = db.Stajyers.Where(x => x.stajyerID == id).FirstOrDefault();
            db.Stajyers.Remove(sil);
            db.SaveChanges();
            listele();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(dataStajyer.CurrentRow.Cells[0].Value);
                var güncelle = db.Stajyers.Where(x => x.stajyerID == id).FirstOrDefault();
                güncelle.adsoyad = txtAd.Text;
                güncelle.TCNO = txtTc.Text;
                güncelle.telefonNo = txtTelNo.Text;
                güncelle.universite = txtÜniversite.Text;
                güncelle.stajBaslangic = dtpBaslangic.Value;
                güncelle.stajBitis = dtpBitis.Value;
                db.SaveChanges();
                listele();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
                
        }
    }
}

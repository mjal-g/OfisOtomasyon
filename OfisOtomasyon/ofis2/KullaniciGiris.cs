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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        OfisDBEntities db = new OfisDBEntities();
        private void btngiris_Click(object sender, EventArgs e)
        {
            string ad;
            string sifre;
            ad = txtKad.Text;
            sifre = txtSifre.Text;
            var login1 = login(ad,sifre);
            if(login1)
            {
                frmIslemler frm = new frmIslemler();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Yanlış kulanıcı adı veya şifre girdiniz");
            }
            txtKad.Text = "";
            txtSifre.Text = "";
        }
        public bool login (string ad,string sifre)
        {
            var giris=(from k in db.Kullanicis where k.kullaniciAdi==ad && k.kullaniciSifre==sifre select k).FirstOrDefault();
            if(giris!= null)
            {
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran_Otomasyonu
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMasaSiparis_Click(object sender, EventArgs e)
        {
            frmMasalar frm = new frmMasalar();
            this.Close();
            frm.Show();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            frmRezervasyon frm = new frmRezervasyon();
            this.Close();
            frm.Show();
        }

        private void btnPaketServis_Click(object sender, EventArgs e)
        {
            frmSiparis frm = new frmSiparis();
            this.Close();
            frm.Show();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            frmMusteriler frm = new frmMusteriler();
            this.Close();
            frm.Show();
        }

        private void btnKasaIslemleri_Click(object sender, EventArgs e)
        {
            frmKasaIslemleri frm = new frmKasaIslemleri();
            this.Close();
            frm.Show();
        }

        private void btnMutfak_Click(object sender, EventArgs e)
        {
            frmMutfak frm = new frmMutfak();
            this.Close();
            frm.Show();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            frmRaporlar frm = new frmRaporlar();
            this.Close();
            frm.Show();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            frmSetting frm = new frmSetting();
            this.Close();
            frm.Show();
        }

        private void btnKilit_Click(object sender, EventArgs e)
        {
            frmLock frm = new frmLock();
            this.Close();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Uyarı!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();//Çıkış yapar.
            }
            // 10.video 3.12'de kaldım
        }
    }
}

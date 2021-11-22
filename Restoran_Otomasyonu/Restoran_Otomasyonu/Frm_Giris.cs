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
    public partial class Frm_Giris : Form
    {
       
        public Frm_Giris()
        {
            
            InitializeComponent();
            cPersoneller p = new cPersoneller();
            p.personelGetbyInformation(cb_kullanici);

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            cGeneral gnl = new cGeneral();
            cPersoneller p = new cPersoneller();//Nesne oluşturdum
            bool result = p.personelEntryControl(txt_sifre.Text, cGeneral._personelId);
            if (result)
            {
                cPersonelHareketleri ch = new cPersonelHareketleri();
                ch.PersonelId = cGeneral._personelId;
                ch.Islem = "Giriş Yaptı";
                ch.Tarih = DateTime.Now;
                ch.PersonelActionSave(ch);//Veritabanına ekler. Fonksiyona gider

                this.Hide();
                frmMenu menu= new frmMenu();
                menu.Show();
            }
        }

        private void cb_kullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller p = (cPersoneller)cb_kullanici.SelectedItem;
            cGeneral._personelId = p.PersonelId;
            cGeneral._gorevId = p.PersonelGorevId;
            /*Kullanııc adı ve şifreyi yazınca diğer forma geçiş yapıyor.*/
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?","Uyarı!!!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();//Çıkış yapar.
            }
        }
    }
}

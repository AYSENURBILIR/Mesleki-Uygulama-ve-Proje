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
        cGeneral gnl = new cGeneral();
        public Frm_Giris()
        {
            
            InitializeComponent();
            cPersoneller p = new cPersoneller();
            p.personelGetbyInformation(cb_kullanici);

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            
            cPersoneller p = new cPersoneller();//Nesne oluşturdum
            bool result = p.personelEntryControl(txt_sifre.Text,gnl._personelId);
            if (result)
            {
                this.Hide();
                frmMenu menu= new frmMenu();
                menu.Show();
            }
        }

        private void cb_kullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller p = (cPersoneller)cb_kullanici.SelectedItem;
            gnl._personelId = p.PersonelId;
            gnl._gorevId = p.PersonelGorevId;
            /*Kullanııc adı ve şifreyi yazınca diğer forma geçiş yapıyor.*/
        }
    }
}

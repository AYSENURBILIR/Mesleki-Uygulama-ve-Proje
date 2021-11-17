using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace Restoran_Otomasyonu
{
    class cPersoneller
    {
        cGeneral gnl = new cGeneral();
        #region Field
        private int _PersonelId;
        private int _PersonelGorevId;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _PersonelParola;
        private string _PersonelKullaniciAdi;
        private bool _Personel_Durum;
        private object sqlConnection;
        #endregion

        #region Properties
        public int PersonelId
        {
            get => _PersonelId;
            set => _PersonelId = value;
        }
        public int PersonelGorevId
        {
            get => _PersonelGorevId;
            set => _PersonelGorevId = value;
        }
        public string PersonelAd
        {
            get => _PersonelAd;
            set => _PersonelAd = value;
        }
        public string PersonelSoyad
        {
            get => _PersonelSoyad;
            set => _PersonelSoyad = value;
        }
        public string PersonelParola
        {
            get => _PersonelParola;
            set => _PersonelParola = value;
        }
        public string PersonelKullaniciAdi
        {
            get => _PersonelKullaniciAdi;
            set => _PersonelKullaniciAdi = value;
        }
        public bool Personel_Durum
        {
            get => _Personel_Durum;
            set => _Personel_Durum = value;
        } 
        #endregion

        public bool personelEntryControl(string password,int UserId)
        {
            bool result = false;


            SqlConnection con = new SqlConnection(gnl.conString);//Veritabanına bağladım.
            SqlCommand cmd = new SqlCommand("Select * From personeller where ID=@Id and PAROLA=@password", con);//Gelen parola ve şifreyi kontrol ettim.
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = UserId;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;


            try
            {
                if (con.State==ConnectionState.Closed)
                {
                    con.Open();//Eğer veritabanı kapalıysa bağlantıyı aç
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());//Cmd'deki gelen değeri bool'e çevirdim.
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            return result;
        }
        public void personelGetbyInformation(ComboBox cb)
        {

            cb.Items.Clear();

            SqlConnection con = new SqlConnection(gnl.conString);//Veritabanına bağladım.
            SqlCommand cmd = new SqlCommand("Select * From personeller", con);//Bilgileri getirdim
           
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();//Eğer veritabanı kapalıysa bağlantıyı aç
                }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cPersoneller p = new cPersoneller();
                //Combobox'ın içine class göndermiş oluyoruz.
                p._PersonelId = Convert.ToInt32(dr["ID"]);
                p._PersonelGorevId = Convert.ToInt32(dr["GOREVID"]);
                p._PersonelAd = Convert.ToString(dr["AD"]);
                p._PersonelSoyad = Convert.ToString(dr["SOYAD"]);
                p._PersonelParola = Convert.ToString(dr["PAROLA"]);
                p._PersonelKullaniciAdi = Convert.ToString(dr["KULLANICIADI"]);
                p._Personel_Durum= Convert.ToBoolean(dr["DURUM"]);
                cb.Items.Add(p);
               
            }
            dr.Close();
            con.Close();

        }
        public override string ToString()
        {
            return PersonelAd +" "+PersonelSoyad;
        }
    }
}

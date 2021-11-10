using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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


            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * From personeller where ID=@Id and PAROLA=@password", con);
            //Personelller tablosundaki ıd ve şifreyi karşılaştıracak
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = UserId;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;


            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AracKiralama
{
    public partial class FrmMusteriGiris : Form
    {
        public FrmMusteriGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            //Tbl_Musteri tablosundan gerekli verilerin çekilmesi.
            SqlCommand komut = new SqlCommand("Select * from Tbl_Musteri where MusteriKullaniciAd=@p1 and MusteriSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            //Textboxlara girilen verilerle Tablodaki verilerin kıyaslanması.
            if (dr.Read())
            {
                FrmMusteriEkrani frmmusteriekrani = new FrmMusteriEkrani();
                //Kullanıcı adı bilgisini FrmMusteriEkranı'da oluşturulan string değişkene aktarıyoruz.
                frmmusteriekrani.musterikullaniciad = TxtKullaniciAdi.Text;
                frmmusteriekrani.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girişi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Üye ol'a basılırsa kayıt olma ekranının açılışı.
            FrmMusteriKayitEtme frmmusterikayit = new FrmMusteriKayitEtme();
            frmmusterikayit.Show();
        }
    }
}

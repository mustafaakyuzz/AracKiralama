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
    public partial class FrmMusteriKayitEtme : Form
    {
        public FrmMusteriKayitEtme()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void temizle()
        {
            //Textboxları temizleme işlemi
            TxtKullaniciAd.Text = "";
            TxtSifre.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtMail.Text = "";
            MskTC.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            MskTelefon.Text = "";
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            //Insert komutu ile girilen verilerin Tbl_Musteri tablosuna eklenmesi işlemi
            SqlCommand komut = new SqlCommand("Insert into Tbl_Musteri (MusteriKullaniciAd,MusteriSifre,MusteriAd,MusteriSoyad,MusteriMail,MusteriTC,MusteriCinsiyet,MusteriTelefon) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p3", TxtAd.Text);
            komut.Parameters.AddWithValue("@p4", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p5", TxtMail.Text);
            komut.Parameters.AddWithValue("@p6", MskTC.Text);

            //Hangi radiobutton'a tıklanıldıysa label10'a onu yazdırdık.
            if (radioButton1.Checked == true)
            {
                label10.Text = "Erkek";
            }
            else if (radioButton2.Checked == true)
            {
                label10.Text = "Kadın";
            }
            komut.Parameters.AddWithValue("@p7", label10.Text);
            komut.Parameters.AddWithValue("@p8", MskTelefon.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            temizle();
            MessageBox.Show("Kayıt Olma İşleminiz Başarıyla Tamamlandı. Giriş Yapabilirsiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

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
    public partial class FrmMusteriIslemleri : Form
    {
        public FrmMusteriIslemleri()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            //Müşteri bilgilerini datagridview'de listeleme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Musteri", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void temizle()
        {
            //Textboxları temizleme işlemi
            TxtId.Text = "";
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
        private void FrmMusteriIslemleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Tıklanılan satırdaki verileri textboxlara taşıma işlemi
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtKullaniciAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtMail.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            MskTC.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[7].Value.ToString() == "Erkek")
            {
                radioButton1.Checked = true;
            }
            else if (dataGridView1.Rows[secilen].Cells[7].Value.ToString() == "Kadın")
            {
                radioButton2.Checked = true;
            }
            MskTelefon.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Delete komutu ile silme işlemi.Öncelikle messagebox ile sorulacak eğer evet butonuna basılırsa silinme işlemi tamamlanacak.
            DialogResult result = MessageBox.Show("Müşteri Bilgileri Kalıcı Olarak Silinecek. Devam Etmek İstiyor musunuz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlCommand komutsil = new SqlCommand("Delete from Tbl_Musteri where MusteriId=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", TxtId.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                listele();
                temizle();
                MessageBox.Show("Müşteri Bilgileri Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Update komutu ile güncelleme işlemi.
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Musteri set MusteriKullaniciAd=@p1,MusteriSifre=@p2,MusteriAd=@p3,MusteriSoyad=@p4,MusteriMail=@p5,MusteriTC=@p6,MusteriCinsiyet=@p7,MusteriTelefon=@p8 where MusteriId=@p9", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            komutguncelle.Parameters.AddWithValue("@p2", TxtSifre.Text);
            komutguncelle.Parameters.AddWithValue("@p3", TxtAd.Text);
            komutguncelle.Parameters.AddWithValue("@p4", TxtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@p5", TxtMail.Text);
            komutguncelle.Parameters.AddWithValue("@p6", MskTC.Text);
            if (radioButton1.Checked == true)
            {
                label13.Text = "Erkek";
            }
            else if (radioButton2.Checked == true)
            {
                label13.Text = "Kadın";
            }
            komutguncelle.Parameters.AddWithValue("@p7", label13.Text);
            komutguncelle.Parameters.AddWithValue("@p8", MskTelefon.Text);
            komutguncelle.Parameters.AddWithValue("@p9", TxtId.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            temizle();
            MessageBox.Show("Müşteri Bilgileri Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

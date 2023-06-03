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
    public partial class FrmYoneticiAyarlar : Form
    {
        public FrmYoneticiAyarlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            //Listeleme işlemi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select YoneticiKullaniciAd,YoneticiSifre from Tbl_Yonetici", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void temizle()
        {
            // Textboxları temizleme işlemi
            TxtKullaniciAdi.Text = "";
            TxtSifre.Text = "";
        }
        private void FrmYoneticiAyarlar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Tıklanılan satırları textboxlara getirme işlemi
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtKullaniciAdi.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Yönetici bilgilerini güncelleme işlemi
            SqlCommand komut = new SqlCommand("Update Tbl_Yonetici set YoneticiSifre=@p1 where YoneticiKullaniciAd=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p2", TxtKullaniciAdi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            temizle();
            MessageBox.Show("Yönetici Bilgileri Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

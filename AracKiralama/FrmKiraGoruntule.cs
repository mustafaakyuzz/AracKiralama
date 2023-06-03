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
    public partial class FrmKiraGoruntule : Form
    {
        public FrmKiraGoruntule()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            //Kira bilgilerini datagridviewde listeleme işlemi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select KiraId as 'Kira ID',IDMusteri as 'Müşteri', IDAraba as 'Araba',TarihVerilis as 'Veriliş',TarihTeslim as 'Teslim' from Tbl_Kira", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void musteriliste()
        {
            //Müşteri listesini gösterme işlemi.
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select MusteriId as 'ID',MusteriAd as 'Ad',MusteriSoyad as 'Soyad' from Tbl_Musteri", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }
        void arabaliste()
        {
            //Araba listesini gösterme işlemi.
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Select ArabaId as 'ID',ArabaMarka as 'Marka',ArabaModel as 'Model' from Tbl_Araba", bgl.baglanti());
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;
        }
        void temizle()
        {
            //temizleme işlemi.
            TxtKira.Text = "";
            TxtMusteri.Text = "";
            TxtAraba.Text = "";
            TxtVerilis.Text = "";
            TxtTeslim.Text = "";
        }
        private void FrmKiraGoruntule_Load(object sender, EventArgs e)
        {
            listele();
            musteriliste();
            arabaliste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Tıklanılan satırdaki verilerin textboxlara taşınma işlemi
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtKira.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtMusteri.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtAraba.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtVerilis.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtTeslim.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Araç teslim alındıktan sonra Bilgiler kira tablosundan silinir.
            SqlCommand komut = new SqlCommand("Delete from Tbl_Kira where KiraId=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKira.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            //Müşteri uygunluk tekrardan Update komutu ile 'True' olur.
            SqlCommand komut1 = new SqlCommand("Update Tbl_Musteri set MusteriUygunluk=1 where MusteriId=@a1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@a1", TxtMusteri.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();

            //Araba uygunluk tekrardan Update komutu ile 'True' olur.
            SqlCommand komut2 = new SqlCommand("Update Tbl_Araba set ArabaUygunluk=1 where ArabaId=@b1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@b1", TxtAraba.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

            listele();
            temizle();
            MessageBox.Show("Araç Başarıyla Teslim Alındı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

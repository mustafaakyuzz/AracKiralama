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
    public partial class FrmTalepGoruntule : Form
    {
        public FrmTalepGoruntule()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            //Talepleri listeleme işlemi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Talep", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void temizle()
        {
            //textboxları temizleme işlemi
            TxtTalep.Text = "";
            TxtMusteri.Text = "";
            TxtAraba.Text = "";
            TxtVerilis.Text = "";
            TxtTeslim.Text = "";
        }
        void musteriliste()
        {
            //Müşteri listeleme işlemi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select MusteriId as 'ID',MusteriAd as 'Ad',MusteriSoyad as 'Soyad' from Tbl_Musteri", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        void arabaliste()
        {
            //Arabaları listeleme işlemi
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select ArabaId as 'ID',ArabaMarka as 'Marka',ArabaModel as 'Model' from Tbl_Araba", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView3.DataSource = dt2;
        }
        private void FrmTalepGoruntule_Load(object sender, EventArgs e)
        {
            listele();
            musteriliste();
            arabaliste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //tıklanılan satırdaki bilgileri textboxlara taşıma işlemi
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtTalep.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtMusteri.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtAraba.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtVerilis.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtTeslim.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Talep reddedilme durumu
            SqlCommand komutsil = new SqlCommand("Delete from Tbl_Talep where TalepId=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", TxtTalep.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();

            //Araba uygunluk tekrardan Update komutu ile 'True' olur.
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Araba set ArabaUygunluk=1 where ArabaId=@a1", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@a1", TxtAraba.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();

            //Müşteri uygunluk tekrardan Update komutu ile 'True' olur.
            SqlCommand komutguncelle2 = new SqlCommand("Update Tbl_Musteri set MusteriUygunluk=1 where MusteriId=@b1", bgl.baglanti());
            komutguncelle2.Parameters.AddWithValue("@b1", TxtMusteri.Text);
            komutguncelle2.ExecuteNonQuery();
            bgl.baglanti().Close();

            listele();
            temizle();
            MessageBox.Show("Talep Reddedildi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Talep kabul edilme durumu
            SqlCommand komutekle = new SqlCommand("Insert into Tbl_Kira (IDMusteri,IDAraba,TarihVerilis,TarihTeslim) values (@c1,@c2,@c3,@c4)", bgl.baglanti());
            komutekle.Parameters.AddWithValue("@c1", TxtMusteri.Text);
            komutekle.Parameters.AddWithValue("@c2", TxtAraba.Text);
            komutekle.Parameters.AddWithValue("@c3", TxtVerilis.Text);
            komutekle.Parameters.AddWithValue("@c4", TxtTeslim.Text);
            komutekle.ExecuteNonQuery();
            bgl.baglanti().Close();

            //Bilgilerin talep listesinden silinmesi
            SqlCommand komut2 = new SqlCommand("Delete from Tbl_Talep where TalepId=@e1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@e1", TxtTalep.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

            listele();
            temizle();
            MessageBox.Show("Talep Kabul Edildi! Kira Takip Ekranında Görüntüleyebilirsiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

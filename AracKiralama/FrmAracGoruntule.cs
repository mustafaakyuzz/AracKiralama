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
    public partial class FrmAracGoruntule : Form
    {
        public FrmAracGoruntule()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            //araba listesini datagridview'e taşıma işlemi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Araba", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void temizle()
        {
            //Textboxları temizleme işlemi
            TxtId.Text = "";
            TxtMarka.Text = "";
            TxtModel.Text = "";
            CmbRenk.Text = "";
            TxtPlaka.Text = "";
            MskYil.Text = "";
        }
        private void FrmAracGoruntule_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Tıklanılan satırdaki verileri Textboxlara taşıma işlemi.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtMarka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtModel.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbRenk.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtPlaka.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            MskYil.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Önce messagebox ile emin misiniz sorusu sorulur, evet'e basıldığı takdirde delete komutu ile silinir.
            DialogResult result = MessageBox.Show("Araç Bilgileri Kalıcı Olarak Silinecek. Devam Etmek İstiyor musunuz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SqlCommand komutsil = new SqlCommand("Delete from Tbl_Araba where ArabaId=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", TxtId.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                listele();
                temizle();
                MessageBox.Show("Araç Bilgileri Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Update komutu ile arabaların güncellenme işlemi.
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Araba set ArabaMarka=@p1,ArabaModel=@p2,ArabaRenk=@p3,ArabaPlaka=@p4,ArabaYil=@p5 where ArabaId=@p6", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", TxtMarka.Text);
            komutguncelle.Parameters.AddWithValue("@p2", TxtModel.Text);
            komutguncelle.Parameters.AddWithValue("@p3", CmbRenk.Text);
            komutguncelle.Parameters.AddWithValue("@p4", TxtPlaka.Text);
            komutguncelle.Parameters.AddWithValue("@p5", MskYil.Text);
            komutguncelle.Parameters.AddWithValue("@p6", TxtId.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            temizle();
            MessageBox.Show("Araç Bilgileri Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

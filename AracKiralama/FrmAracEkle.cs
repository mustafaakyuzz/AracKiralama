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
    public partial class FrmAracEkle : Form
    {
        public FrmAracEkle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void temizle()
        {
            //Temizleme işlemi.
            TxtMarka.Text = "";
            TxtModel.Text = "";
            CmbRenk.Text = "";
            TxtPlaka.Text = "";
            MskYil.Text = "";
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            //Girilen verilerin Tbl_Araba tablosuna Insert komutu ile eklenme işlemi
            SqlCommand komut = new SqlCommand("Insert into Tbl_Araba (ArabaMarka,ArabaModel,ArabaRenk,ArabaPlaka,ArabaYil) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtMarka.Text);
            komut.Parameters.AddWithValue("@p2", TxtModel.Text);
            komut.Parameters.AddWithValue("@p3", CmbRenk.Text);
            komut.Parameters.AddWithValue("@p4", TxtPlaka.Text);
            komut.Parameters.AddWithValue("@p5", MskYil.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            temizle();
            MessageBox.Show("Araç Bilgileri Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

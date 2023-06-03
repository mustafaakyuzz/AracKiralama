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
    public partial class FrmMusteriEkrani : Form
    {
        public FrmMusteriEkrani()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        //Müşteri giriş ekranından girilen kullanıcı adına göre diğer verileri çekmek için public bir string değişken tanımladık.
        public string musterikullaniciad;
        void listele()
        {
            //Yalnızca uygunluk durumu 'True' olan arabaların listelenmesi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Araba where ArabaUygunluk=1", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void temizle()
        {
            //Temizleme işlemi.
            TxtAracId.Text = "";
            TxtMarka.Text = "";
            TxtModel.Text = "";
            TxtPlaka.Text = "";
            TxtRenk.Text = "";
            DateTeslim.Text = DateAlis.Text;
        }
        private void FrmMusteriEkrani_Load(object sender, EventArgs e)
        {
            //FrmMusteriGiris Formundan tanımladığımız kullanıcı adı bilgisini bu forma taşımak için LblMusteriKullaniciAd'a taşıdık.
            LblMusteriKullaniciAd.Text = musterikullaniciad;
            //Getirdiğimiz Kullanıcı adı bilgisine göre diğer verileri çekiyoruz.
            SqlCommand komutsec = new SqlCommand("Select MusteriId,MusteriAd,MusteriSoyad,MusteriUygunluk from Tbl_Musteri where MusteriKullaniciAd=@p1", bgl.baglanti());
            komutsec.Parameters.AddWithValue("@p1", LblMusteriKullaniciAd.Text);
            SqlDataReader dr = komutsec.ExecuteReader();
            while (dr.Read())
            {
                //Gelen verileri ilgili labellara aktardık.
                LblMusteriId.Text = dr[0].ToString();
                LblMusteriAdSoyad.Text = dr[1] + "  " + dr[2];
                LblMusteriUygunluk.Text = dr[3].ToString();
            }

            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Tıklanılan satırdaki verileri textboxlara taşıma işlemi.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAracId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtMarka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtModel.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtPlaka.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtRenk.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (LblMusteriUygunluk.Text == "True")
            {
                //Insert komutu ile LblMusteriId,TxtArabaId, arabanın alınış ve teslim tarihini talep listesine aktardık.
                SqlCommand komuttalep = new SqlCommand("Insert into Tbl_Talep (MusteriID,ArabaID,VerilisTarihi,TeslimTarihi) values (@b1,@b2,@b3,@b4)", bgl.baglanti());
                komuttalep.Parameters.AddWithValue("@b1", LblMusteriId.Text);
                komuttalep.Parameters.AddWithValue("@b2", TxtAracId.Text);
                komuttalep.Parameters.AddWithValue("@b3", DateAlis.Text);
                komuttalep.Parameters.AddWithValue("@b4", DateTeslim.Text);
                komuttalep.ExecuteNonQuery();
                bgl.baglanti().Close();

                //Arabanın uygunluk durumunu 'False' yapıyoruz.
                SqlCommand komutguncelle = new SqlCommand("Update Tbl_Araba set ArabaUygunluk=0 where ArabaId=@c1", bgl.baglanti());
                komutguncelle.Parameters.AddWithValue("@c1", TxtAracId.Text);
                komutguncelle.ExecuteNonQuery();
                bgl.baglanti().Close();

                //Müşterinin uygunluk durumunu 'False' yapıyoruz.
                SqlCommand komutguncelle2 = new SqlCommand("Update Tbl_Musteri set MusteriUygunluk=0 where MusteriId=@d1", bgl.baglanti());
                komutguncelle2.Parameters.AddWithValue("@d1", LblMusteriId.Text);
                komutguncelle2.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                temizle();
                MessageBox.Show("Talebiniz Başarıyla İletildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (LblMusteriUygunluk.Text == "False")
            {
                listele();
                temizle();
                MessageBox.Show("Zaten işlemde bulundunuz. Talebiniz reddedilene kadar veya aracınızı teslim edene kadar yeni bir işlem yapamazsınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

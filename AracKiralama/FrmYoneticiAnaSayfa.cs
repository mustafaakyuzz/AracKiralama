using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class FrmYoneticiAnaSayfa : Form
    {
        public FrmYoneticiAnaSayfa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle frmmusteriekle = new FrmMusteriEkle();
            frmmusteriekle.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmMusteriIslemleri frmmusteriislem = new FrmMusteriIslemleri();
            frmmusteriislem.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmAracEkle frmaracekle = new FrmAracEkle();
            frmaracekle.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmAracGoruntule frmaracgoruntule = new FrmAracGoruntule();
            frmaracgoruntule.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FrmYoneticiEkle frmyoneticiekle = new FrmYoneticiEkle();
            frmyoneticiekle.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FrmYoneticiAyarlar frmyoneticiayarlar = new FrmYoneticiAyarlar();
            frmyoneticiayarlar.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmTalepGoruntule frmtalep = new FrmTalepGoruntule();
            frmtalep.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmKiraGoruntule frmkiragoruntule = new FrmKiraGoruntule();
            frmkiragoruntule.Show();
        }
    }
}

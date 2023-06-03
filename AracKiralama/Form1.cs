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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmYoneticiGiris frmyoneticigiris = new FrmYoneticiGiris();
            frmyoneticigiris.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmMusteriGiris frmmusterigiris = new FrmMusteriGiris();
            frmmusterigiris.Show();
            this.Hide();
        }
    }
}

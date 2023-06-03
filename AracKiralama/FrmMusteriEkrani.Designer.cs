namespace AracKiralama
{
    partial class FrmMusteriEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriEkrani));
            this.label1 = new System.Windows.Forms.Label();
            this.LblMusteriAdSoyad = new System.Windows.Forms.Label();
            this.LblMusteriId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAracId = new System.Windows.Forms.TextBox();
            this.TxtMarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPlaka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtRenk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DateAlis = new System.Windows.Forms.DateTimePicker();
            this.DateTeslim = new System.Windows.Forms.DateTimePicker();
            this.LblMusteriKullaniciAd = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblMusteriUygunluk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(162, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // LblMusteriAdSoyad
            // 
            this.LblMusteriAdSoyad.AutoSize = true;
            this.LblMusteriAdSoyad.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMusteriAdSoyad.ForeColor = System.Drawing.Color.Black;
            this.LblMusteriAdSoyad.Location = new System.Drawing.Point(268, 58);
            this.LblMusteriAdSoyad.Name = "LblMusteriAdSoyad";
            this.LblMusteriAdSoyad.Size = new System.Drawing.Size(52, 24);
            this.LblMusteriAdSoyad.TabIndex = 1;
            this.LblMusteriAdSoyad.Text = "label2";
            // 
            // LblMusteriId
            // 
            this.LblMusteriId.AutoSize = true;
            this.LblMusteriId.Location = new System.Drawing.Point(644, 12);
            this.LblMusteriId.Name = "LblMusteriId";
            this.LblMusteriId.Size = new System.Drawing.Size(115, 24);
            this.LblMusteriId.TabIndex = 2;
            this.LblMusteriId.Text = "LblMusteriId";
            this.LblMusteriId.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(702, 432);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(768, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Araç ID:";
            // 
            // TxtAracId
            // 
            this.TxtAracId.Enabled = false;
            this.TxtAracId.Location = new System.Drawing.Point(843, 101);
            this.TxtAracId.Name = "TxtAracId";
            this.TxtAracId.Size = new System.Drawing.Size(171, 32);
            this.TxtAracId.TabIndex = 5;
            // 
            // TxtMarka
            // 
            this.TxtMarka.Enabled = false;
            this.TxtMarka.Location = new System.Drawing.Point(843, 149);
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Size = new System.Drawing.Size(171, 32);
            this.TxtMarka.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(774, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marka:";
            // 
            // TxtModel
            // 
            this.TxtModel.Enabled = false;
            this.TxtModel.Location = new System.Drawing.Point(843, 197);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Size = new System.Drawing.Size(171, 32);
            this.TxtModel.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(775, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Model:";
            // 
            // TxtPlaka
            // 
            this.TxtPlaka.Enabled = false;
            this.TxtPlaka.Location = new System.Drawing.Point(843, 246);
            this.TxtPlaka.Name = "TxtPlaka";
            this.TxtPlaka.Size = new System.Drawing.Size(171, 32);
            this.TxtPlaka.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(777, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Plaka:";
            // 
            // TxtRenk
            // 
            this.TxtRenk.Enabled = false;
            this.TxtRenk.Location = new System.Drawing.Point(843, 294);
            this.TxtRenk.Name = "TxtRenk";
            this.TxtRenk.Size = new System.Drawing.Size(171, 32);
            this.TxtRenk.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(782, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Renk:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(750, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Alış Tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(732, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Teslim Tarihi:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(893, 441);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(888, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Talep Et";
            // 
            // DateAlis
            // 
            this.DateAlis.Location = new System.Drawing.Point(842, 338);
            this.DateAlis.Name = "DateAlis";
            this.DateAlis.Size = new System.Drawing.Size(172, 32);
            this.DateAlis.TabIndex = 20;
            // 
            // DateTeslim
            // 
            this.DateTeslim.Location = new System.Drawing.Point(842, 386);
            this.DateTeslim.Name = "DateTeslim";
            this.DateTeslim.Size = new System.Drawing.Size(172, 32);
            this.DateTeslim.TabIndex = 21;
            // 
            // LblMusteriKullaniciAd
            // 
            this.LblMusteriKullaniciAd.AutoSize = true;
            this.LblMusteriKullaniciAd.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMusteriKullaniciAd.ForeColor = System.Drawing.Color.Black;
            this.LblMusteriKullaniciAd.Location = new System.Drawing.Point(268, 21);
            this.LblMusteriKullaniciAd.Name = "LblMusteriKullaniciAd";
            this.LblMusteriKullaniciAd.Size = new System.Drawing.Size(57, 24);
            this.LblMusteriKullaniciAd.TabIndex = 22;
            this.LblMusteriKullaniciAd.Text = "label10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(185, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "Ad Soyad:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // LblMusteriUygunluk
            // 
            this.LblMusteriUygunluk.AutoSize = true;
            this.LblMusteriUygunluk.Location = new System.Drawing.Point(418, 12);
            this.LblMusteriUygunluk.Name = "LblMusteriUygunluk";
            this.LblMusteriUygunluk.Size = new System.Drawing.Size(179, 24);
            this.LblMusteriUygunluk.TabIndex = 25;
            this.LblMusteriUygunluk.Text = "LblMusteriUygunluk";
            this.LblMusteriUygunluk.Visible = false;
            // 
            // FrmMusteriEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1035, 537);
            this.Controls.Add(this.LblMusteriUygunluk);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LblMusteriKullaniciAd);
            this.Controls.Add(this.DateTeslim);
            this.Controls.Add(this.DateAlis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtRenk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtPlaka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAracId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LblMusteriId);
            this.Controls.Add(this.LblMusteriAdSoyad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMusteriEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekranı";
            this.Load += new System.EventHandler(this.FrmMusteriEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblMusteriAdSoyad;
        private System.Windows.Forms.Label LblMusteriId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAracId;
        private System.Windows.Forms.TextBox TxtMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPlaka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtRenk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DateAlis;
        private System.Windows.Forms.DateTimePicker DateTeslim;
        private System.Windows.Forms.Label LblMusteriKullaniciAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblMusteriUygunluk;
    }
}
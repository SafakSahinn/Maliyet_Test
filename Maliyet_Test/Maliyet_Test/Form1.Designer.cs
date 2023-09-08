
namespace Maliyet_Test
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMalzemeId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnMalzemeEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblMalzemeFiyat = new System.Windows.Forms.Label();
            this.LblMalzemeNotlar = new System.Windows.Forms.Label();
            this.TxtMalzemeAd = new System.Windows.Forms.TextBox();
            this.TxtMalzemeFiyat = new System.Windows.Forms.TextBox();
            this.TxtMalzemeStok = new System.Windows.Forms.TextBox();
            this.TxtMalzemeNotlar = new System.Windows.Forms.TextBox();
            this.BtnGetir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnUrunGuncelle = new System.Windows.Forms.Button();
            this.BtnUrunEkle = new System.Windows.Forms.Button();
            this.TxtSatisFiyat = new System.Windows.Forms.TextBox();
            this.TxtUrunStok = new System.Windows.Forms.TextBox();
            this.TxtMaliyetFiyat = new System.Windows.Forms.TextBox();
            this.TxtUrunAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtUrunId = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnUrunOlustur = new System.Windows.Forms.Button();
            this.TxtMiktar = new System.Windows.Forms.TextBox();
            this.TxtMaliyet = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnUrunListesi = new System.Windows.Forms.Button();
            this.BtnMalzemeListesi = new System.Windows.Forms.Button();
            this.BtnKasa = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CmbUrun = new System.Windows.Forms.ComboBox();
            this.CmbMalzeme = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // TxtMalzemeId
            // 
            this.TxtMalzemeId.Location = new System.Drawing.Point(111, 42);
            this.TxtMalzemeId.Name = "TxtMalzemeId";
            this.TxtMalzemeId.Size = new System.Drawing.Size(154, 26);
            this.TxtMalzemeId.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnGetir);
            this.groupBox1.Controls.Add(this.BtnMalzemeEkle);
            this.groupBox1.Controls.Add(this.TxtMalzemeNotlar);
            this.groupBox1.Controls.Add(this.TxtMalzemeStok);
            this.groupBox1.Controls.Add(this.TxtMalzemeFiyat);
            this.groupBox1.Controls.Add(this.TxtMalzemeAd);
            this.groupBox1.Controls.Add(this.LblMalzemeNotlar);
            this.groupBox1.Controls.Add(this.LblMalzemeFiyat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtMalzemeId);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 261);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MALZEME GİRİŞİ";
            // 
            // BtnMalzemeEkle
            // 
            this.BtnMalzemeEkle.Location = new System.Drawing.Point(111, 202);
            this.BtnMalzemeEkle.Name = "BtnMalzemeEkle";
            this.BtnMalzemeEkle.Size = new System.Drawing.Size(154, 41);
            this.BtnMalzemeEkle.TabIndex = 3;
            this.BtnMalzemeEkle.Text = "MALZEME EKLE";
            this.BtnMalzemeEkle.UseVisualStyleBackColor = true;
            this.BtnMalzemeEkle.Click += new System.EventHandler(this.BtnMalzemeEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "STOK:";
            // 
            // LblMalzemeFiyat
            // 
            this.LblMalzemeFiyat.AutoSize = true;
            this.LblMalzemeFiyat.Location = new System.Drawing.Point(46, 141);
            this.LblMalzemeFiyat.Name = "LblMalzemeFiyat";
            this.LblMalzemeFiyat.Size = new System.Drawing.Size(59, 20);
            this.LblMalzemeFiyat.TabIndex = 4;
            this.LblMalzemeFiyat.Text = "FİYAT:";
            // 
            // LblMalzemeNotlar
            // 
            this.LblMalzemeNotlar.AutoSize = true;
            this.LblMalzemeNotlar.Location = new System.Drawing.Point(28, 173);
            this.LblMalzemeNotlar.Name = "LblMalzemeNotlar";
            this.LblMalzemeNotlar.Size = new System.Drawing.Size(77, 20);
            this.LblMalzemeNotlar.TabIndex = 5;
            this.LblMalzemeNotlar.Text = "NOTLAR:";
            // 
            // TxtMalzemeAd
            // 
            this.TxtMalzemeAd.Location = new System.Drawing.Point(111, 74);
            this.TxtMalzemeAd.Name = "TxtMalzemeAd";
            this.TxtMalzemeAd.Size = new System.Drawing.Size(154, 26);
            this.TxtMalzemeAd.TabIndex = 6;
            // 
            // TxtMalzemeFiyat
            // 
            this.TxtMalzemeFiyat.Location = new System.Drawing.Point(111, 138);
            this.TxtMalzemeFiyat.Name = "TxtMalzemeFiyat";
            this.TxtMalzemeFiyat.Size = new System.Drawing.Size(154, 26);
            this.TxtMalzemeFiyat.TabIndex = 7;
            // 
            // TxtMalzemeStok
            // 
            this.TxtMalzemeStok.Location = new System.Drawing.Point(111, 106);
            this.TxtMalzemeStok.Name = "TxtMalzemeStok";
            this.TxtMalzemeStok.Size = new System.Drawing.Size(154, 26);
            this.TxtMalzemeStok.TabIndex = 7;
            // 
            // TxtMalzemeNotlar
            // 
            this.TxtMalzemeNotlar.Location = new System.Drawing.Point(111, 170);
            this.TxtMalzemeNotlar.Name = "TxtMalzemeNotlar";
            this.TxtMalzemeNotlar.Size = new System.Drawing.Size(154, 26);
            this.TxtMalzemeNotlar.TabIndex = 8;
            // 
            // BtnGetir
            // 
            this.BtnGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGetir.Location = new System.Drawing.Point(271, 74);
            this.BtnGetir.Name = "BtnGetir";
            this.BtnGetir.Size = new System.Drawing.Size(94, 26);
            this.BtnGetir.TabIndex = 9;
            this.BtnGetir.Text = "GETİR";
            this.BtnGetir.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1063, 228);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MALZEMELER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1057, 203);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnUrunGuncelle);
            this.groupBox3.Controls.Add(this.BtnUrunEkle);
            this.groupBox3.Controls.Add(this.TxtSatisFiyat);
            this.groupBox3.Controls.Add(this.TxtUrunStok);
            this.groupBox3.Controls.Add(this.TxtMaliyetFiyat);
            this.groupBox3.Controls.Add(this.TxtUrunAd);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.TxtUrunId);
            this.groupBox3.Location = new System.Drawing.Point(389, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 261);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ÜRÜN GİRİŞİ";
            // 
            // BtnUrunGuncelle
            // 
            this.BtnUrunGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunGuncelle.Location = new System.Drawing.Point(193, 202);
            this.BtnUrunGuncelle.Name = "BtnUrunGuncelle";
            this.BtnUrunGuncelle.Size = new System.Drawing.Size(152, 41);
            this.BtnUrunGuncelle.TabIndex = 9;
            this.BtnUrunGuncelle.Text = "GÜNCELLE";
            this.BtnUrunGuncelle.UseVisualStyleBackColor = true;
            // 
            // BtnUrunEkle
            // 
            this.BtnUrunEkle.Location = new System.Drawing.Point(33, 202);
            this.BtnUrunEkle.Name = "BtnUrunEkle";
            this.BtnUrunEkle.Size = new System.Drawing.Size(154, 41);
            this.BtnUrunEkle.TabIndex = 3;
            this.BtnUrunEkle.Text = "ÜRÜN EKLE";
            this.BtnUrunEkle.UseVisualStyleBackColor = true;
            this.BtnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // TxtSatisFiyat
            // 
            this.TxtSatisFiyat.Location = new System.Drawing.Point(111, 170);
            this.TxtSatisFiyat.Name = "TxtSatisFiyat";
            this.TxtSatisFiyat.Size = new System.Drawing.Size(154, 26);
            this.TxtSatisFiyat.TabIndex = 8;
            // 
            // TxtUrunStok
            // 
            this.TxtUrunStok.Location = new System.Drawing.Point(111, 106);
            this.TxtUrunStok.Name = "TxtUrunStok";
            this.TxtUrunStok.Size = new System.Drawing.Size(154, 26);
            this.TxtUrunStok.TabIndex = 7;
            // 
            // TxtMaliyetFiyat
            // 
            this.TxtMaliyetFiyat.Location = new System.Drawing.Point(111, 138);
            this.TxtMaliyetFiyat.Name = "TxtMaliyetFiyat";
            this.TxtMaliyetFiyat.Size = new System.Drawing.Size(154, 26);
            this.TxtMaliyetFiyat.TabIndex = 7;
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.Location = new System.Drawing.Point(111, 74);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(154, 26);
            this.TxtUrunAd.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "S.FİYAT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "M.FİYAT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "STOK:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "AD:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // TxtUrunId
            // 
            this.TxtUrunId.Location = new System.Drawing.Point(111, 42);
            this.TxtUrunId.Name = "TxtUrunId";
            this.TxtUrunId.Size = new System.Drawing.Size(154, 26);
            this.TxtUrunId.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.CmbMalzeme);
            this.groupBox4.Controls.Add(this.CmbUrun);
            this.groupBox4.Controls.Add(this.BtnUrunOlustur);
            this.groupBox4.Controls.Add(this.TxtMiktar);
            this.groupBox4.Controls.Add(this.TxtMaliyet);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(766, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(309, 261);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ÜRÜN OLUŞTUR";
            // 
            // BtnUrunOlustur
            // 
            this.BtnUrunOlustur.Location = new System.Drawing.Point(111, 170);
            this.BtnUrunOlustur.Name = "BtnUrunOlustur";
            this.BtnUrunOlustur.Size = new System.Drawing.Size(154, 41);
            this.BtnUrunOlustur.TabIndex = 3;
            this.BtnUrunOlustur.Text = "EKLE";
            this.BtnUrunOlustur.UseVisualStyleBackColor = true;
            this.BtnUrunOlustur.Click += new System.EventHandler(this.BtnUrunOlustur_Click);
            // 
            // TxtMiktar
            // 
            this.TxtMiktar.Location = new System.Drawing.Point(111, 106);
            this.TxtMiktar.Name = "TxtMiktar";
            this.TxtMiktar.Size = new System.Drawing.Size(154, 26);
            this.TxtMiktar.TabIndex = 7;
            this.TxtMiktar.TextChanged += new System.EventHandler(this.TxtMiktar_TextChanged);
            // 
            // TxtMaliyet
            // 
            this.TxtMaliyet.Location = new System.Drawing.Point(111, 138);
            this.TxtMaliyet.Name = "TxtMaliyet";
            this.TxtMaliyet.Size = new System.Drawing.Size(154, 26);
            this.TxtMaliyet.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "MALİYET:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "MİKTAR:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "MALZEME:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(45, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "ÜRÜN:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnCikis);
            this.groupBox5.Controls.Add(this.BtnKasa);
            this.groupBox5.Controls.Add(this.BtnMalzemeListesi);
            this.groupBox5.Controls.Add(this.BtnUrunListesi);
            this.groupBox5.Location = new System.Drawing.Point(1081, 279);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(216, 230);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "İŞLEMLER";
            // 
            // BtnUrunListesi
            // 
            this.BtnUrunListesi.Location = new System.Drawing.Point(6, 35);
            this.BtnUrunListesi.Name = "BtnUrunListesi";
            this.BtnUrunListesi.Size = new System.Drawing.Size(199, 41);
            this.BtnUrunListesi.TabIndex = 3;
            this.BtnUrunListesi.Text = "ÜRÜN LİSTESİ";
            this.BtnUrunListesi.UseVisualStyleBackColor = true;
            this.BtnUrunListesi.Click += new System.EventHandler(this.BtnUrunListesi_Click);
            // 
            // BtnMalzemeListesi
            // 
            this.BtnMalzemeListesi.Location = new System.Drawing.Point(6, 82);
            this.BtnMalzemeListesi.Name = "BtnMalzemeListesi";
            this.BtnMalzemeListesi.Size = new System.Drawing.Size(199, 41);
            this.BtnMalzemeListesi.TabIndex = 4;
            this.BtnMalzemeListesi.Text = "MALZEME LİSTESİ";
            this.BtnMalzemeListesi.UseVisualStyleBackColor = true;
            this.BtnMalzemeListesi.Click += new System.EventHandler(this.BtnMalzemeListesi_Click);
            // 
            // BtnKasa
            // 
            this.BtnKasa.Location = new System.Drawing.Point(6, 129);
            this.BtnKasa.Name = "BtnKasa";
            this.BtnKasa.Size = new System.Drawing.Size(199, 41);
            this.BtnKasa.TabIndex = 5;
            this.BtnKasa.Text = "KASA";
            this.BtnKasa.UseVisualStyleBackColor = true;
            this.BtnKasa.Click += new System.EventHandler(this.BtnKasa_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Location = new System.Drawing.Point(6, 176);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(199, 41);
            this.BtnCikis.TabIndex = 6;
            this.BtnCikis.Text = "ÇIKIŞ";
            this.BtnCikis.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listBox1);
            this.groupBox6.Location = new System.Drawing.Point(1080, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(216, 261);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "İŞLEMLER";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(3, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(210, 236);
            this.listBox1.TabIndex = 0;
            // 
            // CmbUrun
            // 
            this.CmbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUrun.FormattingEnabled = true;
            this.CmbUrun.Location = new System.Drawing.Point(111, 38);
            this.CmbUrun.Name = "CmbUrun";
            this.CmbUrun.Size = new System.Drawing.Size(154, 28);
            this.CmbUrun.TabIndex = 8;
            // 
            // CmbMalzeme
            // 
            this.CmbMalzeme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMalzeme.FormattingEnabled = true;
            this.CmbMalzeme.Location = new System.Drawing.Point(111, 72);
            this.CmbMalzeme.Name = "CmbMalzeme";
            this.CmbMalzeme.Size = new System.Drawing.Size(154, 28);
            this.CmbMalzeme.TabIndex = 9;
            this.CmbMalzeme.SelectedIndexChanged += new System.EventHandler(this.CmbMalzeme_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "MALİYET:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1308, 519);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMalzemeId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGetir;
        private System.Windows.Forms.Button BtnMalzemeEkle;
        private System.Windows.Forms.TextBox TxtMalzemeNotlar;
        private System.Windows.Forms.TextBox TxtMalzemeStok;
        private System.Windows.Forms.TextBox TxtMalzemeFiyat;
        private System.Windows.Forms.TextBox TxtMalzemeAd;
        private System.Windows.Forms.Label LblMalzemeNotlar;
        private System.Windows.Forms.Label LblMalzemeFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnUrunGuncelle;
        private System.Windows.Forms.Button BtnUrunEkle;
        private System.Windows.Forms.TextBox TxtSatisFiyat;
        private System.Windows.Forms.TextBox TxtUrunStok;
        private System.Windows.Forms.TextBox TxtMaliyetFiyat;
        private System.Windows.Forms.TextBox TxtUrunAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtUrunId;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnUrunOlustur;
        private System.Windows.Forms.TextBox TxtMiktar;
        private System.Windows.Forms.TextBox TxtMaliyet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnKasa;
        private System.Windows.Forms.Button BtnMalzemeListesi;
        private System.Windows.Forms.Button BtnUrunListesi;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox CmbMalzeme;
        private System.Windows.Forms.ComboBox CmbUrun;
        private System.Windows.Forms.Label label4;
    }
}


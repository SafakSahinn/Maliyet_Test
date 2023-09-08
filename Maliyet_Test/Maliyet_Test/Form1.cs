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

namespace Maliyet_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-S866UD2;Initial Catalog=TestMaliyet;Integrated Security=True");

        void malzemeListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLMALZEMELER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void urunListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLURUNLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void kasa()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLKASA", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            malzemeListesi();
            urunler();
            malzemeler();
        }

        void urunler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLURUNLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbUrun.ValueMember = "URUNID";
            CmbUrun.DisplayMember = "AD";
            CmbUrun.DataSource = dt;
            baglanti.Close();
        }

        void malzemeler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLMALZEMELER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbMalzeme.ValueMember = "MALZEMEID";
            CmbMalzeme.DisplayMember = "AD";
            CmbMalzeme.DataSource = dt;
            baglanti.Close();
        }

        private void BtnUrunListesi_Click(object sender, EventArgs e)
        {
            urunListesi();
        }

        private void BtnMalzemeListesi_Click(object sender, EventArgs e)
        {
            malzemeListesi();
        }

        private void BtnKasa_Click(object sender, EventArgs e)
        {
            kasa();
        }

        private void BtnMalzemeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLMALZEMELER (AD,STOK,FIYAT,NOTLAR) VALUES (@P1,@P2,@P3,@P4)", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtMalzemeAd.Text);
            komut.Parameters.AddWithValue("@P2", decimal.Parse(TxtMalzemeStok.Text));
            komut.Parameters.AddWithValue("@P3", decimal.Parse(TxtMalzemeFiyat.Text));
            komut.Parameters.AddWithValue("@P4", TxtMalzemeNotlar.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme Eklendi!");
            malzemeListesi();
        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLURUNLER (AD) VALUES (@P1)", baglanti);
            komut.Parameters.AddWithValue("@P1", TxtUrunAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Eklendi!");
            urunListesi();
        }

        private void BtnUrunOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLFIRIN (URUNID,MALZEMEID,MIKTAR,MALIYET) VALUES (@P1,@P2,@P3,@P4)", baglanti);
            komut.Parameters.AddWithValue("@P1", CmbUrun.SelectedValue);
            komut.Parameters.AddWithValue("@P2", CmbMalzeme.SelectedValue);
            komut.Parameters.AddWithValue("@P3", decimal.Parse(TxtMiktar.Text));
            komut.Parameters.AddWithValue("@P4", decimal.Parse(TxtMaliyet.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme Eklendi!");

            listBox1.Items.Add(CmbMalzeme.Text + " - " + TxtMaliyet.Text);

        }

        private void TxtMiktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;

            if (TxtMiktar.Text == "")
            {
                TxtMiktar.Text = "0";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLMALZEMELER WHERE MALZEMEID=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", CmbMalzeme.SelectedValue);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtMaliyet.Text = dr[3].ToString();
            }
            baglanti.Close();

            maliyet = Convert.ToDouble(TxtMaliyet.Text) / 1000 * Convert.ToDouble(TxtMiktar.Text);

            TxtMaliyet.Text = maliyet.ToString();
        }

        private void CmbMalzeme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtUrunId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtUrunAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT SUM (MALIYET) FROM TBLFIRIN WHERE URUNID=@P1",baglanti);
            komut.Parameters.AddWithValue("@P1",TxtUrunId.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtMaliyetFiyat.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
    }
}

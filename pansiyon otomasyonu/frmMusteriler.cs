using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace pansiyon_otomasyonu
{
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-414DTKK\SQLEXPRESS;Initial Catalog=pansiyon;Integrated Security=True");

        private void verilergoster ()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster();


        }

        

        private void frmMusteriler_Load(object sender, EventArgs e)
        {

        }
       
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            
            txtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cmbCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtTc.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtOdaNumarası.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text; 

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //oda101
            if(txtOdaNumarası.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda101 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            //oda 102
            if (txtOdaNumarası.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda102 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            //oda 103
            if (txtOdaNumarası.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda103 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            //oda104
            if (txtOdaNumarası.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda104 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }

            //oda105
            if (txtOdaNumarası.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda105 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }


            // oda 106 
            if (txtOdaNumarası.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda106 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }

            //oda 107
            if (txtOdaNumarası.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda1017 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            // oda 108
            if (txtOdaNumarası.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda108 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            // oda 109 
            if (txtOdaNumarası.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda109 ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
            
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            cmbCinsiyet.Text = "";
            MskTxtTelefon.Clear();
            txtMail.Text = "";
            txtTc.Clear();
            txtOdaNumarası.Clear();
            txtUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '%"+textbox1.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
//Data Source=DESKTOP-414DTKK\SQLEXPRESS;Initial Catalog=pansiyon;Integrated Security=True
// SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid=("+id+")",baglanti);
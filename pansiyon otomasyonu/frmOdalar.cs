﻿using System;
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
    public partial class frmOdalar : Form
    {
        public frmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-414DTKK\\SQLEXPRESS;Initial Catalog=pansiyon;Integrated Security=True");

        private void frmOdalar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select* from Oda101 ", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                btnOda101.Text = oku1["Adi"].ToString() +" "+ oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda101.Text!="101")
            {
                btnOda101.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select* from oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                btnOda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda102.Text != "102")
            {
                btnOda102.BackColor = Color.Red;
            }


            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select* from oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                btnOda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda103.Text != "103")
            {
                btnOda103.BackColor = Color.Red;
            }
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select* from oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                btnOda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda104.Text != "104")
            {
                btnOda104.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select* from oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                btnOda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda105.Text != "105")
            {
                btnOda105.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select* from oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                btnOda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda106.Text != "106")
            {
                btnOda106.BackColor = Color.Red;
            }



            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select* from oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                btnOda107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda107.Text != "107")
            {
                btnOda107.BackColor = Color.Red;
            }
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select* from oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                btnOda108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda108.Text != "108")
            {
                btnOda108.BackColor = Color.Red;
            }

            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select* from oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                btnOda109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btnOda109.Text != "109")
            {
                btnOda109.BackColor = Color.Red;
            }
        }
    }
}

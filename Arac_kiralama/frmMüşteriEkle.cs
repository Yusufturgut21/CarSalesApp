﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kiralama
{
    public partial class frmMüşteriEkle : Form
    {
        Araç_Kiralama arac_kiralama = new Araç_Kiralama();
        public frmMüşteriEkle()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cümle = "INSERT INTO musteri (tc, adsoyad, telefon, adres, email) VALUES (@tc, @adsoyad, @telefon, @adres, @email)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc",txtTc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@email", txtEmail.Text);
            arac_kiralama.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = ""; 
        }
    }
}

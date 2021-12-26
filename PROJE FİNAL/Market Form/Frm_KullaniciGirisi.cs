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

namespace Market_Form
{
    public partial class Frm_KullaniciGirisi : Form
    {
        public Frm_KullaniciGirisi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Anamenu form1 = new Frm_Anamenu();
            form1.Show();
            this.Hide();

        }

        Sql_Baglantisi bgl = new Sql_Baglantisi();

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Kullanicilar Where KullaniciTC=@p1 and KullaniciSifre=@p2", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1",MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                Frm_Onecikanlar frm_Onecikanlar = new Frm_Onecikanlar();
                frm_Onecikanlar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre");
            }
            bgl.baglanti().Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Kayitolma form3 = new Frm_Kayitolma();
            form3.Show();
            this.Hide();
        }

        private void Frm_KullaniciGirisi_Load(object sender, EventArgs e)
        {

        }
    }
}

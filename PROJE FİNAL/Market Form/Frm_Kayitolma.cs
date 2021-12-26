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
    public partial class Frm_Kayitolma : Form
    {
        public Frm_Kayitolma()
        {
            InitializeComponent();
        }

        Sql_Baglantisi bgl = new Sql_Baglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text == "" || TxtSifre.Text == "" || TxtSoyad.Text == "" || MskTC.Text == "" || MskTel.Text == "")
            {
                MessageBox.Show("Lütfen Bilgilerinizi Eksiksiz Giriniz");
            }


            else
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Kullanicilar (KullaniciAd,KullaniciSoyad,KullaniciTel,KullaniciTC,KullaniciSifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", MskTel.Text);
                komut.Parameters.AddWithValue("@p4", MskTC.Text);
                komut.Parameters.AddWithValue("@p5", TxtSifre.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kaydınız Gerçekleştirilmiştir");
                Frm_KullaniciGirisi form2 = new Frm_KullaniciGirisi();
                form2.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_KullaniciGirisi form2 = new Frm_KullaniciGirisi();
            form2.Show();
            this.Hide();
        }

        private void Frm_Kayitolma_Load(object sender, EventArgs e)
        {

        }
    }
}


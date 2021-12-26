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
    public partial class Frm_KrediKarti : Form
    {
        public Frm_KrediKarti()
        {
            InitializeComponent();
        }

        Sql_Baglantisi bgl = new Sql_Baglantisi();
        private void button8_Click(object sender, EventArgs e)
        {
            Frm_Sepet form49 = new Frm_Sepet();
            form49.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text == "" || txtKartNumarasi.Text == "" || txtkarttipi.Text == "" || msksonkllnm.Text == null || rchAdres.Text == "")
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Giriniz");
            }


            else
            {
                Frm_Onecikanlar form41 = new Frm_Onecikanlar();
                form41.Show();
                this.Hide();

                SqlCommand komut = new SqlCommand("insert into Tbl_Satıslar (Tarih,AdSoyad,Adres,ÖdemeTürü,ÖdenenTutar) values (@p1,@p2,@p3,'Kredi Kartı',@p5)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                komut.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@p3", rchAdres.Text);
                komut.Parameters.AddWithValue("@p5", lblTutar.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Siparişiniz Alınmıştır");

                SqlCommand komut3 = new SqlCommand("Delete from Tbl_Sepetim", bgl.baglanti());
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongDateString();
        }

        private void Frm_KrediKarti_Load(object sender, EventArgs e)
        {
            timer1.Start();

            bgl.baglanti();
            SqlCommand komut5 = new SqlCommand("Select Sum(ToplamTutar) from Tbl_Sepetim", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblTutar.Text = dr5[0].ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

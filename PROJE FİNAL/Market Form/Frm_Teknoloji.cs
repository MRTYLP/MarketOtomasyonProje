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
    public partial class Frm_Teknoloji : Form
    {
        public Frm_Teknoloji()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Icecekler form42 = new Frm_Icecekler();
            form42.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Temelgida form43 = new Frm_Temelgida();
            form43.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Atistirmalik form44 = new Frm_Atistirmalik();
            form44.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_Sebze form45 = new Frm_Sebze();
            form45.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnAtistirmalik form46 = new btnAtistirmalik();
            form46.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_Bebekbakim form47 = new Frm_Bebekbakim();
            form47.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Frm_Teknoloji form48 = new Frm_Teknoloji();
            form48.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Frm_Onecikanlar form41 = new Frm_Onecikanlar();
            form41.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Frm_Sepet form49 = new Frm_Sepet();
            form49.Show();
            this.Hide();
        }

        public void button8_Click_1(object sender, EventArgs e)
        {
            Frm_Sepet form49 = new Frm_Sepet();
            form49.Show();
            this.Hide();
        }

       


        

        private void timer1_Tick(object sender, EventArgs e)
        {
            label15.Text = DateTime.Now.ToLongDateString();
            label14.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form48_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Frm_Onecikanlar form41 = new Frm_Onecikanlar();
            form41.Show();
            this.Hide();
        }

        int tk1, tk2, tk3, tk4;

        private void button16_Click(object sender, EventArgs e)
        {
            tk4 += 1;
            lblusbbellekadet.Text = tk4.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (tk1 >= 1)
                tk1 -= 1;
            lblsarjaadet.Text = tk1.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (tk2 >= 1)
                tk2 -= 1;
            lbljbladet.Text = tk2.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (tk3 >= 1)
                tk3 -= 1;
            lblapplesadet.Text = tk3.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (tk4 >= 1)
                tk4 -= 1;
            lblusbbellekadet.Text = tk4.ToString();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("Seçilen Ürünler Sepete Eklenmiştir");

            TEKNOLOJI sarjadp = new TEKNOLOJI();
            sarjadp.Ad = "SARJ ADAPTORU";
            sarjadp.Adet = Convert.ToInt16(lblsarjaadet.Text);
            sarjadp.Kdv();
            sarjadp.Fiyat = 72.90;

            TEKNOLOJI jblbt = new TEKNOLOJI();
            jblbt.Ad = "JBL BT HOPARLOR";
            jblbt.Adet = Convert.ToInt16(lbljbladet.Text);
            jblbt.Kdv();
            jblbt.Fiyat = 1200;

            TEKNOLOJI applesarj = new TEKNOLOJI();
            applesarj.Ad = "APPLE SARJ KABLOSU";
            applesarj.Adet = Convert.ToInt16(lblapplesadet.Text);
            applesarj.Kdv();
            applesarj.Fiyat = 249;

            TEKNOLOJI usbbellek = new TEKNOLOJI();
            usbbellek.Ad = "USB BELLEK";
            usbbellek.Adet = Convert.ToInt16(lblusbbellekadet.Text);
            usbbellek.Kdv();
            usbbellek.Fiyat = 85.75;

            Sql_Baglantisi bgl = new Sql_Baglantisi();
            int a = Convert.ToInt16(sarjadp.Adet);
            if (a > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", sarjadp.Ad);
                komut.Parameters.AddWithValue("@p2", sarjadp.Adet);
                komut.Parameters.AddWithValue("@p7", sarjadp.Agırlık);
                komut.Parameters.AddWithValue("@p5", sarjadp.Kdv());
                komut.Parameters.AddWithValue("@p3", sarjadp.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", sarjadp.Fiyat);
                komut.Parameters.AddWithValue("@p4", sarjadp.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a1 = Convert.ToInt16(jblbt.Adet);
            if (a > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", jblbt.Ad);
                komut.Parameters.AddWithValue("@p2", jblbt.Adet);
                komut.Parameters.AddWithValue("@p7", jblbt.Agırlık);
                komut.Parameters.AddWithValue("@p5", jblbt.Kdv());
                komut.Parameters.AddWithValue("@p3", jblbt.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", jblbt.Fiyat);
                komut.Parameters.AddWithValue("@p4", jblbt.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }


            int a2 = Convert.ToInt16(applesarj.Adet);
            if (a > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", applesarj.Ad);
                komut.Parameters.AddWithValue("@p2", applesarj.Adet);
                komut.Parameters.AddWithValue("@p7", applesarj.Agırlık);
                komut.Parameters.AddWithValue("@p5", applesarj.Kdv());
                komut.Parameters.AddWithValue("@p3", applesarj.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", applesarj.Fiyat);
                komut.Parameters.AddWithValue("@p4", applesarj.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a3 = Convert.ToInt16(usbbellek.Adet);
            if (a > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", usbbellek.Ad);
                komut.Parameters.AddWithValue("@p2", usbbellek.Adet);
                komut.Parameters.AddWithValue("@p7", usbbellek.Agırlık);
                komut.Parameters.AddWithValue("@p5", usbbellek.Kdv());
                komut.Parameters.AddWithValue("@p3", usbbellek.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", usbbellek.Fiyat);
                komut.Parameters.AddWithValue("@p4", usbbellek.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tk3 += 1;
            lblapplesadet.Text = tk3.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tk2 += 1;
            lbljbladet.Text = tk2.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tk1 += 1;
            lblsarjaadet.Text = tk1.ToString();
        }
    }
}

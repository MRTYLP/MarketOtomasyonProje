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
    public partial class Frm_Temelgida : Form
    {
        public Frm_Temelgida()
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {
            Frm_Anamenu form1 = new Frm_Anamenu();
            form1.Show();
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

            Frm_Sepet form49 = new Frm_Sepet();
            form49.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label41.Text = DateTime.Now.ToLongDateString();
            label40.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form43_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button34_Click_1(object sender, EventArgs e)
        {
            Frm_Onecikanlar form41 = new Frm_Onecikanlar();
            form41.Show();
            this.Hide();
        }

        int t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12;
        private void button12_Click(object sender, EventArgs e)
        {
            t1 += 1;
            lblekmekadet.Text = t1.ToString();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (t1 >= 1)
                t1 -= 1;
            lblekmekadet.Text = t1.ToString();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (t2 >= 1)
                t2 -= 1;
            lblmakarnaadet.Text = t2.ToString();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            if (t3 >= 1)
                t3 -= 1;
            lblpirincadet.Text = t3.ToString();
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            if (t4 >= 1)
                t4 -= 1;
            lblbulguradet.Text = t4.ToString();
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            if (t5 >= 1)
                t5 -= 1;
            lblsalcaadet.Text = t5.ToString();
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            if (t6 >= 1)
                t6 -= 1;
            lblmercimekadet.Text = t6.ToString();
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            if (t7 >= 1)
                t7 -= 1;
            lblketcapadet.Text = t7.ToString();
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            if (t8 >= 1)
                t8 -= 1;
            lblmayonezadet.Text = t8.ToString();
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            if (t9 >= 1)
                t9 -= 1;
            lblbamyaadet.Text = t9.ToString();
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            if (t10 >= 1)
                t10 -= 1;
            lblaycicekadet.Text = t10.ToString();
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            if (t11 >= 1)
                t11 -= 1;
            lblmargarinadet.Text = t11.ToString();
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            if (t12 >= 1)
                t12 -= 1;
            lbltuzadet.Text = t12.ToString();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Seçilen Ürünler Sepete Eklenmiştir");

            TEMELGIDA ekmek = new TEMELGIDA();
            ekmek.Ad = "EKMEK";
            ekmek.Adet = Convert.ToInt16(lblekmekadet.Text);
            ekmek.Kdv();
            ekmek.Agırlık = 0.2;
            ekmek.Fiyat = 2.00;

            TEMELGIDA makarna = new TEMELGIDA();
            makarna.Ad = "MAKARNA";
            makarna.Adet = Convert.ToInt16(lblmakarnaadet.Text);
            makarna.Kdv();
            makarna.Agırlık = 0.5;
            makarna.Fiyat = 3.80;

            TEMELGIDA pirinc = new TEMELGIDA();
            pirinc.Ad = "PİRİNÇ";
            pirinc.Adet = Convert.ToInt16(lblpirincadet.Text);
            pirinc.Kdv();
            pirinc.Agırlık = 1;
            pirinc.Fiyat = 20.00;

            TEMELGIDA bulgur = new TEMELGIDA();
            bulgur.Ad = "BULGUR";
            bulgur.Adet = Convert.ToInt16(lblbulguradet.Text);
            bulgur.Kdv();
            bulgur.Agırlık = 1;
            bulgur.Fiyat = 12.25;

            TEMELGIDA dsalca = new TEMELGIDA();
            dsalca.Ad = "DOMATES SALCASI";
            dsalca.Adet = Convert.ToInt16(lblsalcaadet.Text);
            dsalca.Kdv();
             dsalca.Agırlık = 0.8;
            dsalca.Fiyat = 13.90;

            TEMELGIDA mercimek = new TEMELGIDA();
            mercimek.Ad = "MERCIMEK";
            mercimek.Adet = Convert.ToInt16(lblmercimekadet.Text);
            mercimek.Kdv();
            mercimek.Agırlık = 1;
            mercimek.Fiyat = 13.90;

            TEMELGIDA ketcap = new TEMELGIDA();
            ketcap.Ad = "KETCAP";
            ketcap.Adet = Convert.ToInt16(lblketcapadet.Text);
            ketcap.Kdv();
            ketcap.Agırlık = 0.75;
            ketcap.Fiyat = 13.25;

            TEMELGIDA mayonez = new TEMELGIDA();
            mayonez.Ad = "MAYONEZ";
            mayonez.Adet = Convert.ToInt16(lblmayonezadet.Text);
            mayonez.Kdv();
            mayonez.Agırlık = 0.55;
            mayonez.Fiyat = 17.75;

            TEMELGIDA bamya = new TEMELGIDA();
            bamya.Ad = "BAMYA";
            bamya.Adet = Convert.ToInt16(lblbamyaadet.Text);
            bamya.Kdv();
            bamya.Agırlık = 0.8;
            bamya.Fiyat = 17.90;

            TEMELGIDA ayagı = new TEMELGIDA();
            ayagı.Ad = "AYCICEK YAGI";
            ayagı.Adet = Convert.ToInt16(lblaycicekadet.Text);
            ayagı.Kdv();
            ayagı.Agırlık = 2;
            ayagı.Fiyat = 50.75;

            TEMELGIDA margarin = new TEMELGIDA();
            margarin.Ad = "MARGARIN";
            margarin.Adet = Convert.ToInt16(lblmargarinadet.Text);
            margarin.Kdv();
            margarin.Agırlık = 0.5;
            margarin.Fiyat = 15.00;

            TEMELGIDA tuz = new TEMELGIDA();
            tuz.Ad = "TUZ";
            tuz.Adet = Convert.ToInt16(lbltuzadet.Text);
            tuz.Kdv();
            tuz.Agırlık = 0.7;
            tuz.Fiyat = 8.25;

            Sql_Baglantisi bgl = new Sql_Baglantisi();
            int a = Convert.ToInt16(ekmek.Adet);
            if (a > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", ekmek.Ad);
                komut.Parameters.AddWithValue("@p2", ekmek.Adet);
                komut.Parameters.AddWithValue("@p7", ekmek.Agırlık);
                komut.Parameters.AddWithValue("@p5", ekmek.Kdv());
                komut.Parameters.AddWithValue("@p3", ekmek.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", ekmek.Fiyat);
                komut.Parameters.AddWithValue("@p4", ekmek.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a1 = Convert.ToInt16(makarna.Adet);
            if (a1 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", makarna.Ad);
                komut.Parameters.AddWithValue("@p2", makarna.Adet);
                komut.Parameters.AddWithValue("@p7", makarna.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", makarna.Kdv());
                komut.Parameters.AddWithValue("@p3", makarna.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", makarna.Fiyat);
                komut.Parameters.AddWithValue("@p4", makarna.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }


            int a2 = Convert.ToInt16(pirinc.Adet);
            if (a2 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", pirinc.Ad);
                komut.Parameters.AddWithValue("@p2", pirinc.Adet);
                komut.Parameters.AddWithValue("@p7", pirinc.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", pirinc.Kdv());
                komut.Parameters.AddWithValue("@p3", pirinc.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", pirinc.Fiyat);
                komut.Parameters.AddWithValue("@p4", pirinc.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a3 = Convert.ToInt16(bulgur.Adet);
            if (a3 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", bulgur.Ad);
                komut.Parameters.AddWithValue("@p2", bulgur.Adet);
                komut.Parameters.AddWithValue("@p7", bulgur.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", bulgur.Kdv());
                komut.Parameters.AddWithValue("@p3", bulgur.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", bulgur.Fiyat);
                komut.Parameters.AddWithValue("@p4", bulgur.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a4 = Convert.ToInt16(dsalca.Adet);
            if (a4 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", dsalca.Ad);
                komut.Parameters.AddWithValue("@p2", dsalca.Adet);
                komut.Parameters.AddWithValue("@p7", dsalca.Agırlık);
                komut.Parameters.AddWithValue("@p5", dsalca.Kdv());
                komut.Parameters.AddWithValue("@p3", dsalca.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", dsalca.Fiyat);
                komut.Parameters.AddWithValue("@p4", dsalca.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a5 = Convert.ToInt16(mercimek.Adet);
            if (a5 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", mercimek.Ad);
                komut.Parameters.AddWithValue("@p2", mercimek.Adet);
                komut.Parameters.AddWithValue("@p7", mercimek.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", mercimek.Kdv());
                komut.Parameters.AddWithValue("@p3", mercimek.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", mercimek.Fiyat);
                komut.Parameters.AddWithValue("@p4", mercimek.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }


            int a6 = Convert.ToInt16(ketcap.Adet);
            if (a6 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", ketcap.Ad);
                komut.Parameters.AddWithValue("@p2", ketcap.Adet);
                komut.Parameters.AddWithValue("@p7", ketcap.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", ketcap.Kdv());
                komut.Parameters.AddWithValue("@p3", ketcap.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", ketcap.Fiyat);
                komut.Parameters.AddWithValue("@p4", ketcap.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a7 = Convert.ToInt16(mayonez.Adet);
            if (a7 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", mayonez.Ad);
                komut.Parameters.AddWithValue("@p2", mayonez.Adet);
                komut.Parameters.AddWithValue("@p7", mayonez.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", mayonez.Kdv());
                komut.Parameters.AddWithValue("@p3", mayonez.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", mayonez.Fiyat);
                komut.Parameters.AddWithValue("@p4", mayonez.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a8 = Convert.ToInt16(bamya.Adet);
            if (a8 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", bamya.Ad);
                komut.Parameters.AddWithValue("@p2", bamya.Adet);
                komut.Parameters.AddWithValue("@p7", bamya.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", bamya.Kdv());
                komut.Parameters.AddWithValue("@p3", bamya.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", bamya.Fiyat);
                komut.Parameters.AddWithValue("@p4", bamya.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a9 = Convert.ToInt16(ayagı.Adet);
            if (a9 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", ayagı.Ad);
                komut.Parameters.AddWithValue("@p2", ayagı.Adet);
                komut.Parameters.AddWithValue("@p7", ayagı.Agırlık);
                komut.Parameters.AddWithValue("@p5", ayagı.Kdv());
                komut.Parameters.AddWithValue("@p3", ayagı.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", ayagı.Fiyat);
                komut.Parameters.AddWithValue("@p4", ayagı.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a10 = Convert.ToInt16(margarin.Adet);
            if (a10 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", margarin.Ad);
                komut.Parameters.AddWithValue("@p2", margarin.Adet);
                komut.Parameters.AddWithValue("@p7", margarin.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", margarin.Kdv());
                komut.Parameters.AddWithValue("@p3", margarin.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", margarin.Fiyat);
                komut.Parameters.AddWithValue("@p4", margarin.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }


            int a11 = Convert.ToInt16(tuz.Adet);
            if (a11 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", tuz.Ad);
                komut.Parameters.AddWithValue("@p2", tuz.Adet);
                komut.Parameters.AddWithValue("@p7", tuz.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", tuz.Kdv());
                komut.Parameters.AddWithValue("@p3", tuz.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", tuz.Fiyat);
                komut.Parameters.AddWithValue("@p4", tuz.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            t12 += 1;
            lbltuzadet.Text = t12.ToString();
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            t11 += 1;
            lblmargarinadet.Text = t11.ToString();
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            t10 += 1;
            lblaycicekadet.Text = t10.ToString();
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            t9 += 1;
            lblbamyaadet.Text = t9.ToString();
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            t8 += 1;
            lblmayonezadet.Text = t8.ToString();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            t7 += 1;
            lblketcapadet.Text = t7.ToString();
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            t6 += 1;
            lblmercimekadet.Text = t6.ToString();
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            t5 += 1;
            lblsalcaadet.Text = t5.ToString();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            t4 += 1;
            lblbulguradet.Text = t4.ToString();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            t3 += 1;
            lblpirincadet.Text = t3.ToString();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            t2 += 1;
            lblmakarnaadet.Text = t2.ToString();
        }
    }
}


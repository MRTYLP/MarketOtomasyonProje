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
    public partial class Frm_Sebze : Form
    {
        public Frm_Sebze()
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
            label40.Text = DateTime.Now.ToLongDateString();
            label39.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form45_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button34_Click_1(object sender, EventArgs e)
        {
            Frm_Onecikanlar form41 = new Frm_Onecikanlar();
            form41.Show();
            this.Hide();
        }

        int sm1, sm2, sm3, sm4, sm5, sm6, sm7, sm8, sm9, sm10, sm11, sm12;
        private void button10_Click(object sender, EventArgs e)
        {
            sm1 += 1;
            lblelmaadet.Text = sm1.ToString();
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            sm12 += 1;
            lblhavucadet.Text = sm12.ToString();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (sm1 >= 1)
                sm1 -= 1;
            lblelmaadet.Text = sm1.ToString();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (sm2 >= 1)
                sm2 -= 1;
            lblportakaladet.Text = sm2.ToString();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            if (sm3 >= 1)
                sm3 -= 1;
            lblmuzadet.Text = sm3.ToString();
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            if (sm4 >= 1)
                sm4 -= 1;
            lblarmutadet.Text = sm4.ToString();
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            if (sm5 >= 1)
                sm5 -= 1;
            lblcilekadet.Text = sm5.ToString();
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            if (sm6 >= 1)
                sm6 -= 1;
            lblkirazadet.Text = sm6.ToString();
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            if (sm7 >= 1)
                sm7 -= 1;
            lblsalatalikadet.Text = sm7.ToString();
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            if (sm8 >= 1)
                sm8 -= 1;
            lbldomatesadet.Text = sm8.ToString();
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            if (sm9 >= 1)
                sm9 -= 1;
            lblispanakadet.Text = sm9.ToString();
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            if (sm10 >= 1)
                sm10 -= 1;
            lbllimonadet.Text = sm10.ToString();
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            if (sm11 >= 1)
                sm11 -= 1;
            lblpatatesadet.Text = sm11.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            MessageBox.Show("Seçilen Ürünler Sepete Eklenmiştir");

            SEBZEMEYVE elmakg = new SEBZEMEYVE();
            elmakg.Ad = "ELMA KG";
            elmakg.Adet = Convert.ToInt16(lblelmaadet.Text);
            elmakg.Kdv();
            elmakg.Agırlık = 1;
            elmakg.Fiyat = 9.25;
            

            SEBZEMEYVE portkg = new SEBZEMEYVE();
            portkg.Ad = "PORTAKAL KG";
            portkg.Adet = Convert.ToInt16(lblportakaladet.Text);
            portkg.Kdv();
            portkg.Agırlık = 1 ;
            portkg.Fiyat = 5.75;
            

            SEBZEMEYVE muzkg = new SEBZEMEYVE();
            muzkg.Ad = "MUZ KG";
            muzkg.Adet = Convert.ToInt16(lblmuzadet.Text);
            muzkg.Kdv();
            muzkg.Agırlık = 1;
            muzkg.Fiyat = 10;

            SEBZEMEYVE armutkg = new SEBZEMEYVE();
            armutkg.Ad = "ARMUT KG";
            armutkg.Adet = Convert.ToInt16(lblarmutadet.Text);
            armutkg.Kdv();
            armutkg.Agırlık = 1 ;
            armutkg.Fiyat = 7.00;

            SEBZEMEYVE cilekkg = new SEBZEMEYVE();
            cilekkg.Ad = "CILEK KG";
            cilekkg.Adet = Convert.ToInt16(lblcilekadet.Text);
            cilekkg.Kdv();
            cilekkg.Agırlık = 1 ;
            cilekkg.Fiyat = 41.50;

            SEBZEMEYVE kirazkg = new SEBZEMEYVE();
            kirazkg.Ad = "KIRAZ KG";
            kirazkg.Adet = Convert.ToInt16(lblkirazadet.Text);
            kirazkg.Kdv();
            kirazkg.Agırlık = 1 ;
            kirazkg.Fiyat = 15.00;

            SEBZEMEYVE salatalıkkg = new SEBZEMEYVE();
            salatalıkkg.Ad = "SALATALIK KG";
            salatalıkkg.Adet = Convert.ToInt16(lblsalatalikadet.Text);
            salatalıkkg.Kdv();
            salatalıkkg.Agırlık = 1 ;
            salatalıkkg.Fiyat = 8.00;

            SEBZEMEYVE domateskg = new SEBZEMEYVE();
            domateskg.Ad = "DOMATES KG";
            domateskg.Adet = Convert.ToInt16(lbldomatesadet.Text);
            domateskg.Kdv();
            domateskg.Agırlık = 1 ;
            domateskg.Fiyat = 8.00;

            SEBZEMEYVE ıspanakkg = new SEBZEMEYVE();
            ıspanakkg.Ad = "ISPANAK KG";
            ıspanakkg.Adet = Convert.ToInt16(lblispanakadet.Text);
            ıspanakkg.Kdv();
            ıspanakkg.Agırlık = 1 ;
            ıspanakkg.Fiyat = 8.010;

            SEBZEMEYVE lımonkg = new SEBZEMEYVE();
            lımonkg.Ad = "LIMON KG";
            lımonkg.Adet = Convert.ToInt16(lbllimonadet.Text);
            lımonkg.Kdv();
            lımonkg.Agırlık = 1 ;
            lımonkg.Fiyat = 1.50;

            SEBZEMEYVE patateskg = new SEBZEMEYVE();
            patateskg.Ad = "PATATES KG";
            patateskg.Adet = Convert.ToInt16(lblpatatesadet.Text);
            patateskg.Kdv();
            patateskg.Agırlık = 1 ;
            patateskg.Fiyat = 1.50;

            SEBZEMEYVE havuckg = new SEBZEMEYVE();
            havuckg.Ad = "HAVUC KG";
            havuckg.Adet = Convert.ToInt16(lblhavucadet.Text);
            havuckg.Kdv();
            havuckg.Agırlık = 1;
            havuckg.Fiyat = 1.50;

            Sql_Baglantisi bgl = new Sql_Baglantisi();

            int a = Convert.ToInt16(elmakg.Adet);
            if (a > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", elmakg.Ad);
                komut.Parameters.AddWithValue("@p2", elmakg.Adet);
                komut.Parameters.AddWithValue("@p7", elmakg.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", elmakg.Kdv());
                komut.Parameters.AddWithValue("@p3", elmakg.Fiyat - ((elmakg.Kdv() * elmakg.Fiyat) / 100));
                komut.Parameters.AddWithValue("@p6", elmakg.Fiyat);
                komut.Parameters.AddWithValue("@p4", elmakg.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a1 = Convert.ToInt16(portkg.Adet);
            if (a1 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", portkg.Ad);
                komut.Parameters.AddWithValue("@p2", portkg.Adet);
                komut.Parameters.AddWithValue("@p7", portkg.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", portkg.Kdv());
                komut.Parameters.AddWithValue("@p3", portkg.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", portkg.Fiyat);
                komut.Parameters.AddWithValue("@p4", portkg.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }


            int a2 = Convert.ToInt16(muzkg.Adet);
            if (a2 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", muzkg.Ad);
                komut.Parameters.AddWithValue("@p2", muzkg.Adet);
                komut.Parameters.AddWithValue("@p7", muzkg.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", muzkg.Kdv());
                komut.Parameters.AddWithValue("@p3", muzkg.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", muzkg.Fiyat);
                komut.Parameters.AddWithValue("@p4", muzkg.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a3 = Convert.ToInt16(armutkg.Adet);
            if (a3 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", armutkg.Ad);
                komut.Parameters.AddWithValue("@p2", armutkg.Adet);
                komut.Parameters.AddWithValue("@p7", armutkg.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", armutkg.Kdv());
                komut.Parameters.AddWithValue("@p3", armutkg.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", armutkg.Fiyat);
                komut.Parameters.AddWithValue("@p4", armutkg.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a4 = Convert.ToInt16(cilekkg.Adet);
            if (a4 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", cilekkg.Ad);
                komut.Parameters.AddWithValue("@p2", cilekkg.Adet);
                komut.Parameters.AddWithValue("@p7", cilekkg.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", cilekkg.Kdv());
                komut.Parameters.AddWithValue("@p3", cilekkg.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", cilekkg.Fiyat);
                komut.Parameters.AddWithValue("@p4", cilekkg.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a5 = Convert.ToInt16(kirazkg.Adet);
            if (a5 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", kirazkg.Ad);
                komut.Parameters.AddWithValue("@p2", kirazkg.Adet);
                komut.Parameters.AddWithValue("@p7", kirazkg.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", kirazkg.Kdv());
                komut.Parameters.AddWithValue("@p3", kirazkg.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", kirazkg.Fiyat);
                komut.Parameters.AddWithValue("@p4", kirazkg.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }


            int a6 = Convert.ToInt16(salatalıkkg.Adet);
            if (a6 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", salatalıkkg.Ad);
                komut.Parameters.AddWithValue("@p2", salatalıkkg.Adet);
                komut.Parameters.AddWithValue("@p7", salatalıkkg.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", salatalıkkg.Kdv());
                komut.Parameters.AddWithValue("@p3", salatalıkkg.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", salatalıkkg.Fiyat);
                komut.Parameters.AddWithValue("@p4", salatalıkkg.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a7 = Convert.ToInt16(domateskg.Adet);
            if (a7 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", domateskg.Ad);
                komut.Parameters.AddWithValue("@p2", domateskg.Adet);
                komut.Parameters.AddWithValue("@p7", domateskg.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", domateskg.Kdv());
                komut.Parameters.AddWithValue("@p3", domateskg.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", domateskg.Fiyat);
                komut.Parameters.AddWithValue("@p4", domateskg.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a8 = Convert.ToInt16(ıspanakkg.Adet);
            if (a8 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", ıspanakkg.Ad);
                komut.Parameters.AddWithValue("@p2", ıspanakkg.Adet);
                komut.Parameters.AddWithValue("@p7", ıspanakkg.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", ıspanakkg.Kdv());
                komut.Parameters.AddWithValue("@p3", ıspanakkg.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", ıspanakkg.Fiyat);
                komut.Parameters.AddWithValue("@p4", ıspanakkg.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a9 = Convert.ToInt16(lımonkg.Adet);
            if (a9 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", lımonkg.Ad);
                komut.Parameters.AddWithValue("@p2", lımonkg.Adet);
                komut.Parameters.AddWithValue("@p7", lımonkg.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", lımonkg.Kdv());
                komut.Parameters.AddWithValue("@p3", lımonkg.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", lımonkg.Fiyat);
                komut.Parameters.AddWithValue("@p4", lımonkg.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a10 = Convert.ToInt16(patateskg.Adet);
            if (a10 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", patateskg.Ad);
                komut.Parameters.AddWithValue("@p2", patateskg.Adet);
                komut.Parameters.AddWithValue("@p7", patateskg.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", patateskg.Kdv());
                komut.Parameters.AddWithValue("@p3", patateskg.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", patateskg.Fiyat);
                komut.Parameters.AddWithValue("@p4", patateskg.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }


            int a11 = Convert.ToInt16(havuckg.Adet);
            if (a11 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", havuckg.Ad);
                komut.Parameters.AddWithValue("@p2", havuckg.Adet);
                komut.Parameters.AddWithValue("@p7", havuckg.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", havuckg.Kdv());
                komut.Parameters.AddWithValue("@p3", havuckg.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", havuckg.Fiyat);
                komut.Parameters.AddWithValue("@p4", havuckg.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            if (sm12 >= 1)
                sm12 -= 1;
            lblhavucadet.Text = sm12.ToString();
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            sm11 += 1;
            lblpatatesadet.Text = sm11.ToString();
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            sm10 += 1;
            lbllimonadet.Text = sm10.ToString();
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            sm9 += 1;
            lblispanakadet.Text = sm9.ToString();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            sm8 += 1;
            lbldomatesadet.Text = sm8.ToString();
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            sm7 += 1;
            lblsalatalikadet.Text = sm7.ToString();
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            sm6 += 1;
            lblkirazadet.Text = sm6.ToString();
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            sm5 += 1;
            lblcilekadet.Text = sm5.ToString();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            sm4 += 1;
            lblarmutadet.Text = sm4.ToString();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            sm3 += 1;
            lblmuzadet.Text = sm3.ToString();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            sm2 += 1;
            lblportakaladet.Text = sm2.ToString();
        }
    }
}

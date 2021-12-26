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
    public partial class Frm_Atistirmalik : Form
    {
        public Frm_Atistirmalik()
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

        private void Form44_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button34_Click_1(object sender, EventArgs e)
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

        private void button34_Click(object sender, EventArgs e)
        {
            Frm_Onecikanlar form41 = new Frm_Onecikanlar();
            form41.Show();
            this.Hide();
        }

        int a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12;
        private void button12_Click(object sender, EventArgs e)
        {
            a1 += 1;
            lbllaysadet.Text = a1.ToString();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (a1 >= 1)
                a1 -= 1;
            lbllaysadet.Text = a1.ToString();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (a2 >= 1)
                a2 -= 1;
            lbl3biskuviadet.Text = a2.ToString();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            if (a3 >= 1)
                a3 -= 1;
            lblcitliyoadet.Text = a3.ToString();
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            if (a4 >= 1)
                a4 -= 1;
            lblantepadet.Text = a4.ToString();
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            if (a5 >= 1)
                a5 -= 1;
            lbldoritosadet.Text = a5.ToString();
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            if (a6 >= 1)
                a6 -= 1;
            lblalbeniadet.Text = a6.ToString();
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            if (a7 >= 1)
                a7 -= 1;
            lblbrowniadet.Text = a7.ToString();
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            if (a8 >= 1)
                a8 -= 1;
            lblkrakeradet.Text = a8.ToString();
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            if (a9 >= 1)
                a9 -= 1;
            lblrulokatadet.Text = a9.ToString();
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            if (a10 >= 1)
                a10 -= 1;
            lblnoodleadet.Text = a10.ToString();
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            if (a11 >= 1)
                a11 -= 1;
            lbltopkekadet.Text = a11.ToString();
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            if (a12 >= 1)
                a12 -= 1;
            lblpopkekadet.Text = a12.ToString();
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Seçilen Ürünler Sepete Eklenmiştir");

            ATIŞTIRMALIK lbaharat = new ATIŞTIRMALIK();
            lbaharat.Ad = "LAYS BAHARATLI";
            lbaharat.Adet = Convert.ToInt16(lbllaysadet.Text);
            lbaharat.Agırlık = 0.106;
            lbaharat.Fiyat = 8.00;

            ATIŞTIRMALIK ucbıskuvıkarma = new ATIŞTIRMALIK();
            ucbıskuvıkarma.Ad = "UCLU BISKUVI KARMA";
            ucbıskuvıkarma.Adet = Convert.ToInt16(lbl3biskuviadet.Text);
            ucbıskuvıkarma.Agırlık = 0.243;
            ucbıskuvıkarma.Fiyat = 5.25;

            ATIŞTIRMALIK citliyo = new ATIŞTIRMALIK();
            citliyo.Ad = "CITLIYO";
            citliyo.Adet = Convert.ToInt16(lblcitliyoadet.Text);
           citliyo.Agırlık = 0.180;
            citliyo.Fiyat = 9.50;

            ATIŞTIRMALIK tadımantep = new ATIŞTIRMALIK();
            tadımantep.Ad = "TADIM ANTEP";
            tadımantep.Adet = Convert.ToInt16(lblantepadet.Text);
            tadımantep.Agırlık = 0.180;
            tadımantep.Fiyat = 35.00;

            ATIŞTIRMALIK dacılı = new ATIŞTIRMALIK();
            dacılı.Ad = "DORITOS ACILI";
            dacılı.Adet = Convert.ToInt16(lbldoritosadet.Text);
            dacılı.Agırlık = 106;
            dacılı.Fiyat = 8.00;

            ATIŞTIRMALIK albenicik = new ATIŞTIRMALIK();
            albenicik.Ad = "ALBENI CIKOLATA";
            albenicik.Adet = Convert.ToInt16(lblalbeniadet.Text);
            albenicik.Agırlık = 0.040;
            albenicik.Fiyat = 3.00;

            ATIŞTIRMALIK browcik = new ATIŞTIRMALIK();
            browcik.Ad = "BROWNI CIKOLATA";
            browcik.Adet = Convert.ToInt16(lblbrowniadet.Text);
            browcik.Agırlık = 0.040;
            browcik.Fiyat = 2.50;

            ATIŞTIRMALIK ikicrax = new ATIŞTIRMALIK();
            ikicrax.Ad = "IKILI CRAX KRAKER";
            ikicrax.Adet = Convert.ToInt16(lblkrakeradet.Text);
            ikicrax.Agırlık = 0.140;
            ikicrax.Fiyat = 3.25;

            ATIŞTIRMALIK rulok = new ATIŞTIRMALIK();
            rulok.Ad = "RULOKAT GOFRET";
            rulok.Adet = Convert.ToInt16(lblrulokatadet.Text);
            rulok.Agırlık = 0.17;
            rulok.Fiyat = 9.95;

            ATIŞTIRMALIK indnood = new ATIŞTIRMALIK();
            indnood.Ad = "INDOMIE NOODLE";
            indnood.Adet = Convert.ToInt16(lblnoodleadet.Text);
            indnood.Agırlık = 0.70;
            indnood.Fiyat = 2.20;

            ATIŞTIRMALIK epopkekcok = new ATIŞTIRMALIK();
            epopkekcok.Ad = "ETI POPKEK COKLU";
            epopkekcok.Adet = Convert.ToInt16(lblpopkekadet.Text);
            epopkekcok.Agırlık = 0.180;
            epopkekcok.Fiyat = 6.75;

            ATIŞTIRMALIK epopkektop = new ATIŞTIRMALIK();
            epopkektop.Ad = "POPKEK TOPLU";
            epopkektop.Adet = Convert.ToInt16(lblpopkekadet.Text);
            epopkektop.Agırlık = 0.180;
            epopkektop.Fiyat = 6.50;

            Sql_Baglantisi bgl = new Sql_Baglantisi();
            int a = Convert.ToInt16(lbaharat.Adet);
            if (a > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", lbaharat.Ad);
                komut.Parameters.AddWithValue("@p2", lbaharat.Adet);
                komut.Parameters.AddWithValue("@p7", lbaharat.Agırlık);
                komut.Parameters.AddWithValue("@p5", lbaharat.Kdv());
                komut.Parameters.AddWithValue("@p3", lbaharat.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", lbaharat.Fiyat);
                komut.Parameters.AddWithValue("@p4", lbaharat.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a1 = Convert.ToInt16(ucbıskuvıkarma.Adet);
            if (a1 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", ucbıskuvıkarma.Ad);
                komut.Parameters.AddWithValue("@p2", ucbıskuvıkarma.Adet);
                komut.Parameters.AddWithValue("@p7", ucbıskuvıkarma.Agırlık);
                komut.Parameters.AddWithValue("@p5", ucbıskuvıkarma.Kdv());
                komut.Parameters.AddWithValue("@p3", ucbıskuvıkarma.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", ucbıskuvıkarma.Fiyat);
                komut.Parameters.AddWithValue("@p4", ucbıskuvıkarma.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }


            int a2 = Convert.ToInt16(citliyo.Adet);
            if (a2 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", citliyo.Ad);
                komut.Parameters.AddWithValue("@p2", citliyo.Adet);
                komut.Parameters.AddWithValue("@p7", citliyo.Agırlık);
                komut.Parameters.AddWithValue("@p5", citliyo.Kdv());
                komut.Parameters.AddWithValue("@p3", citliyo.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", citliyo.Fiyat);
                komut.Parameters.AddWithValue("@p4", citliyo.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a3 = Convert.ToInt16(tadımantep.Adet);
            if (a3 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", tadımantep.Ad);
                komut.Parameters.AddWithValue("@p2", tadımantep.Adet);
                komut.Parameters.AddWithValue("@p7", tadımantep.Agırlık);
                komut.Parameters.AddWithValue("@p5", tadımantep.Kdv());
                komut.Parameters.AddWithValue("@p3", tadımantep.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", tadımantep.Fiyat);
                komut.Parameters.AddWithValue("@p4", tadımantep.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a4 = Convert.ToInt16(dacılı.Adet);
            if (a4 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", dacılı.Ad);
                komut.Parameters.AddWithValue("@p2", dacılı.Adet);
                komut.Parameters.AddWithValue("@p7", dacılı.Agırlık);
                komut.Parameters.AddWithValue("@p5", dacılı.Kdv());
                komut.Parameters.AddWithValue("@p3", dacılı.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", dacılı.Fiyat);
                komut.Parameters.AddWithValue("@p4", tadımantep.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a5 = Convert.ToInt16(albenicik.Adet);
            if (a5 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", albenicik.Ad);
                komut.Parameters.AddWithValue("@p2", albenicik.Adet);
                komut.Parameters.AddWithValue("@p7", albenicik.Adet);
                komut.Parameters.AddWithValue("@p5", albenicik.Kdv());
                komut.Parameters.AddWithValue("@p3", albenicik.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", albenicik.Fiyat);
                komut.Parameters.AddWithValue("@p4", albenicik.ToplamFiyatHesapla());

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }


            int a6 = Convert.ToInt16(browcik.Adet);
            if (a6 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", browcik.Ad);
                komut.Parameters.AddWithValue("@p2", browcik.Adet);
                komut.Parameters.AddWithValue("@p7", browcik.Agırlık);
                komut.Parameters.AddWithValue("@p5", browcik.Kdv());
                komut.Parameters.AddWithValue("@p3", browcik.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", browcik.Fiyat);
                komut.Parameters.AddWithValue("@p4", browcik.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a7 = Convert.ToInt16(ikicrax.Adet);
            if (a7 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", ikicrax.Ad);
                komut.Parameters.AddWithValue("@p2", ikicrax.Adet);
                komut.Parameters.AddWithValue("@p7", ikicrax.Agırlık);
                komut.Parameters.AddWithValue("@p5", ikicrax.Kdv());
                komut.Parameters.AddWithValue("@p3", ikicrax.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", ikicrax.Fiyat);
                komut.Parameters.AddWithValue("@p4", ikicrax.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a8 = Convert.ToInt16(rulok.Adet);
            if (a8 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", rulok.Ad);
                komut.Parameters.AddWithValue("@p2", rulok.Adet);
                komut.Parameters.AddWithValue("@p7", rulok.Agırlık);
                komut.Parameters.AddWithValue("@p5", rulok.Kdv());
                komut.Parameters.AddWithValue("@p3", rulok.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", rulok.Fiyat);
                komut.Parameters.AddWithValue("@p4", rulok.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a9 = Convert.ToInt16(indnood.Adet);
            if (a9 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", indnood.Ad);
                komut.Parameters.AddWithValue("@p2", indnood.Adet);
                komut.Parameters.AddWithValue("@p7", indnood.Agırlık);
                komut.Parameters.AddWithValue("@p5", indnood.Kdv());
                komut.Parameters.AddWithValue("@p3", indnood.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", indnood.Fiyat);
                komut.Parameters.AddWithValue("@p4", indnood.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a10 = Convert.ToInt16(epopkekcok.Adet);
            if (a10 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", epopkekcok.Ad);
                komut.Parameters.AddWithValue("@p2", epopkekcok.Adet);
                komut.Parameters.AddWithValue("@p7", epopkekcok.Agırlık);
                komut.Parameters.AddWithValue("@p5", epopkekcok.Kdv());
                komut.Parameters.AddWithValue("@p3", epopkekcok.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", epopkekcok.Fiyat);
                komut.Parameters.AddWithValue("@p4", epopkekcok.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }


            int a11 = Convert.ToInt16(epopkektop.Adet);
            if (a11 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", epopkektop.Ad);
                komut.Parameters.AddWithValue("@p2", epopkektop.Adet);
                komut.Parameters.AddWithValue("@p7", epopkektop.Agırlık);
                komut.Parameters.AddWithValue("@p5", epopkektop.Kdv());
                komut.Parameters.AddWithValue("@p3", epopkektop.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", epopkektop.Fiyat);
                komut.Parameters.AddWithValue("@p4", epopkektop.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            a12 += 1;
            lblpopkekadet.Text = a12.ToString();
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            a11 += 1;
            lbltopkekadet.Text = a11.ToString();
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            a10 += 1;
            lblnoodleadet.Text = a10.ToString();
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            a9 += 1;
            lblrulokatadet.Text = a9.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            a6 += 1;
            lblalbeniadet.Text = a6.ToString();
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            a8 += 1;
            lblkrakeradet.Text = a8.ToString();
        }
        private void button22_Click_1(object sender, EventArgs e)
        {
            a7 += 1;
            lblbrowniadet.Text = a7.ToString();
        }
        private void button18_Click_1(object sender, EventArgs e)
        {
            a5 += 1;
            lbldoritosadet.Text = a5.ToString();
        }
       private void button16_Click_1(object sender, EventArgs e)
        {
            a4 += 1;
            lblantepadet.Text = a4.ToString();
        }
        private void button10_Click_1(object sender, EventArgs e)
        {
            a2 += 1;
            lbl3biskuviadet.Text = a2.ToString();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            a3 += 1;
            lblcitliyoadet.Text = a3.ToString();
        }
    }
}


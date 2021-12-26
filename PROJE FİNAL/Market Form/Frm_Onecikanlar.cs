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
    public partial class Frm_Onecikanlar : Form
    {

        public void SepeteEklendi()
        {
            MessageBox.Show("Seçilen Ürünler Sepete Eklenmiştir");
        }
        public Frm_Onecikanlar()
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
            Frm_Sepet form49 = new Frm_Sepet();
            form49.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Frm_Sepet form49 = new Frm_Sepet();
            form49.Show();
            this.Hide();
        }

        private void Form41_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
                    }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Frm_Anamenu form1 = new Frm_Anamenu();
            form1.Show();
            this.Hide();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Frm_Anamenu form1 = new Frm_Anamenu();
            form1.Show();
            this.Hide();
        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            Frm_Sepet form49 = new Frm_Sepet();
            form49.Show();
            this.Hide();    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label42.Text = DateTime.Now.ToLongDateString();
            label41.Text = DateTime.Now.ToLongTimeString();
        }

        int sayi, a, b, c, d, l, f, g, h, i, j, k;
        private void button12_Click(object sender, EventArgs e)
        {
            sayi += 1;
            lblsu05oadet.Text = sayi.ToString();

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (sayi >= 1)
                sayi -= 1;
            lblsu05oadet.Text = sayi.ToString();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (a >= 1)
                a -= 1;
            lblucluoadet.Text = a.ToString();
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            if (b >= 1)
                b -= 1;
            lbltuvaletkadet.Text = b.ToString();
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            if (c >= 1)
                c -= 1;
            lblprimabadet.Text = c.ToString();
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            if (d >= 1)
                d -= 1;
            lbljblbtadet.Text = d.ToString();
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            if (l >= 1)
                l -= 1;
            lbldisfadet.Text = l.ToString();
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            if (f >= 1)
                f -= 1;
            lblcraxkadet.Text = f.ToString();
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            if (g >= 1)
                g -= 1;
            lbl3biskuviadet.Text = g.ToString();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            if (h >= 1)
                h -= 1;
            lblelmaoadet.Text = h.ToString();
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            if (i >= 1)
                i -= 1;
            lblaycicekoadet.Text = i.ToString();
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            if (j >= 1)
                j -= 1;
            lblhacisakiroadet.Text = j.ToString();
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            if (k >= 1)
                k -= 1;
            lblmaske50oadet.Text = k.ToString();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            SepeteEklendi();


            ICECEK ksu = new ICECEK();
            ksu.Ad = "SU";
            ksu.Adet = Convert.ToInt16(lblsu05oadet.Text);
            ksu.Kdv();
            ksu.Agırlık = 0.5;
            ksu.Fiyat = 1.50;

            ICECEK ucicecek = new ICECEK();
            ucicecek.Ad = "UCLU ICECEK";
            ucicecek.Adet = Convert.ToInt16(lblucluoadet.Text);
            ucicecek.Kdv();
            ucicecek.Agırlık = 1.5;
            ucicecek.Fiyat = 17.90;

            KBAKIM sekiztuval = new KBAKIM();
            sekiztuval.Ad = "8'LI TUVALET KAGIDI";
            sekiztuval.Adet = Convert.ToInt16(lbltuvaletkadet.Text);
            sekiztuval.Kdv();
            sekiztuval.Fiyat = 24.95;

            BEBEKBAKIM prımabez = new BEBEKBAKIM();
            prımabez.Ad = "PRIMA BEBEK BEZ(52'LI";
            prımabez.Adet = Convert.ToInt16(lblprimabadet.Text);
            prımabez.Kdv();
            prımabez.Fiyat = 109.90;

            TEKNOLOJI jblbt = new TEKNOLOJI();
            jblbt.Ad = "JBL BT HOPARLOR";
            jblbt.Adet = Convert.ToInt16(lbljblbtadet.Text);
            jblbt.Kdv();
            jblbt.Fiyat = 1200;

            KBAKIM dfirca = new KBAKIM();
            dfirca.Ad = "DIS FIRCASI 2'LI";
            dfirca.Adet = Convert.ToInt16(lbldisfadet.Text);
            dfirca.Kdv();
            dfirca.Agırlık = 0.036;
            dfirca.Fiyat = 24.95;

            ATIŞTIRMALIK ikicrax = new ATIŞTIRMALIK();
            ikicrax.Ad = "IKILI CRAX KRAKER";
            ikicrax.Adet = Convert.ToInt16(lblcraxkadet.Text);
            ikicrax.Kdv();
            ikicrax.Agırlık = 0.140;
            ikicrax.Fiyat = 3.25;

            ATIŞTIRMALIK ucbıskuvıkarma = new ATIŞTIRMALIK();
            ucbıskuvıkarma.Ad = "UCLU BISKUVI KARMA";
            ucbıskuvıkarma.Adet = Convert.ToInt16(lbl3biskuviadet.Text);
            ucbıskuvıkarma.Kdv();
            ucbıskuvıkarma.Agırlık = 0.243;
            ucbıskuvıkarma.Fiyat = 5.25;

            SEBZEMEYVE elmakg = new SEBZEMEYVE();
            elmakg.Ad = "ELMA KG";
            elmakg.Adet = Convert.ToInt16(lblelmaoadet.Text);
            elmakg.Kdv();
            elmakg.Agırlık = 1;
            elmakg.Fiyat = 9.25;

            TEMELGIDA ayagı = new TEMELGIDA();
            ayagı.Ad = "AYCICEK YAGI";
            ayagı.Adet = Convert.ToInt16(lblaycicekoadet.Text);
            ayagı.Kdv();
            ayagı.Agırlık = 2;
            ayagı.Fiyat = 50.75;

            KBAKIM hsakir = new KBAKIM();
            hsakir.Ad = "HACI SAKIR 4'LU";
            hsakir.Adet = Convert.ToInt16(lblhacisakiroadet.Text);
            hsakir.Kdv();
            hsakir.Agırlık = 0.600;
            hsakir.Fiyat = 20.90;

            KBAKIM maske = new KBAKIM();
            maske.Ad = "MASKE 50'LI";
            maske.Adet = Convert.ToInt16(lblmaske50oadet.Text);
            maske.Kdv();
            maske.Fiyat = 34.95;

            Sql_Baglantisi bgl = new Sql_Baglantisi();

            int a = Convert.ToInt16(ksu.Adet);
            if (a > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", ksu.Ad);
                komut.Parameters.AddWithValue("@p2", ksu.Adet);
                komut.Parameters.AddWithValue("@p7", ksu.Agırlık);
                komut.Parameters.AddWithValue("@p5", ksu.Kdv());
                komut.Parameters.AddWithValue("@p3", ksu.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", ksu.Fiyat);
                komut.Parameters.AddWithValue("@p4", ksu.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a1 = Convert.ToInt16(ucicecek.Adet);
            if (a1 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", ucicecek.Ad);
                komut.Parameters.AddWithValue("@p2", ucicecek.Adet);
                komut.Parameters.AddWithValue("@p7", ucicecek.Agırlık);
                komut.Parameters.AddWithValue("@p5", ucicecek.Kdv());
                komut.Parameters.AddWithValue("@p3", ucicecek.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", ucicecek.Fiyat);
                komut.Parameters.AddWithValue("@p4", ucicecek.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a2 = Convert.ToInt16(sekiztuval.Adet);
            if (a2 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", sekiztuval.Ad);
                komut.Parameters.AddWithValue("@p2", sekiztuval.Adet);
                komut.Parameters.AddWithValue("@p7", sekiztuval.Agırlık);
                komut.Parameters.AddWithValue("@p5", sekiztuval.Kdv());
                komut.Parameters.AddWithValue("@p3", sekiztuval.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", sekiztuval.Fiyat);
                komut.Parameters.AddWithValue("@p4", sekiztuval.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a3 = Convert.ToInt16(prımabez.Adet);
            if (a3 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", prımabez.Ad);
                komut.Parameters.AddWithValue("@p2", prımabez.Adet);
                komut.Parameters.AddWithValue("@p7", prımabez.Agırlık);
                komut.Parameters.AddWithValue("@p5", prımabez.Kdv());
                komut.Parameters.AddWithValue("@p3", prımabez.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", prımabez.Fiyat);
                komut.Parameters.AddWithValue("@p4", prımabez.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a4 = Convert.ToInt16(jblbt.Adet);
            if (a4 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

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

            int a5 = Convert.ToInt16(dfirca.Adet);
            if (a5 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", dfirca.Ad);
                komut.Parameters.AddWithValue("@p2", dfirca.Adet);
                komut.Parameters.AddWithValue("@p7", dfirca.Agırlık);
                komut.Parameters.AddWithValue("@p5", dfirca.Kdv());
                komut.Parameters.AddWithValue("@p3", dfirca.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", dfirca.Fiyat);
                komut.Parameters.AddWithValue("@p4", dfirca.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a7 = Convert.ToInt16(ikicrax.Adet);
            if (a7 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

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


            int a6 = Convert.ToInt16(ucbıskuvıkarma.Adet);
            if (a6 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

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

            int a11 = Convert.ToInt16(elmakg.Adet);
            if (a11 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", elmakg.Ad);
                komut.Parameters.AddWithValue("@p2", elmakg.Adet);
                komut.Parameters.AddWithValue("@p7", elmakg.ToplamAgırlıkHesapla());
                komut.Parameters.AddWithValue("@p5", elmakg.Kdv());
                komut.Parameters.AddWithValue("@p3", elmakg.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", elmakg.Fiyat);
                komut.Parameters.AddWithValue("@p4", elmakg.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }


            int a8 = Convert.ToInt16(ayagı.Adet);
            if (a8 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

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

            int a9 = Convert.ToInt16(hsakir.Adet);
            if (a9 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", hsakir.Ad);
                komut.Parameters.AddWithValue("@p2", hsakir.Adet);
                komut.Parameters.AddWithValue("@p7", hsakir.Agırlık);
                komut.Parameters.AddWithValue("@p5", hsakir.Kdv());
                komut.Parameters.AddWithValue("@p3", hsakir.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", hsakir.Fiyat);
                komut.Parameters.AddWithValue("@p4", hsakir.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a10 = Convert.ToInt16(maske.Adet);
            if (a10 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", maske.Ad);
                komut.Parameters.AddWithValue("@p2", maske.Adet);
                komut.Parameters.AddWithValue("@p7", maske.Agırlık);
                komut.Parameters.AddWithValue("@p5", maske.Kdv());
                komut.Parameters.AddWithValue("@p3", maske.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", maske.Fiyat);
                komut.Parameters.AddWithValue("@p4", maske.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            k += 1;
            lblmaske50oadet.Text = k.ToString();
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            j += 1;
            lblhacisakiroadet.Text = j.ToString();
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            i += 1;
            lblaycicekoadet.Text = i.ToString();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            h += 1;
            lblelmaoadet.Text = h.ToString();
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            g += 1;
            lbl3biskuviadet.Text = g.ToString();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            f += 1;
            lblcraxkadet.Text = f.ToString();
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            l += 1;
            lbldisfadet.Text = l.ToString();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            d += 1;
            lbljblbtadet.Text = d.ToString();
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            c += 1;
            lblprimabadet.Text = c.ToString();
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            b += 1;
            lbltuvaletkadet.Text = b.ToString();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            a += 1;
            lblucluoadet.Text = a.ToString();
        }

    }
}


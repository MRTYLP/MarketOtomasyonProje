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
    public partial class btnAtistirmalik : Form
    {
        public btnAtistirmalik()
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

        private void Form46_Load(object sender, EventArgs e)
        {  
            timer1.Start();
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

        private void button34_Click_1(object sender, EventArgs e)
        {
            Frm_Onecikanlar form41 = new Frm_Onecikanlar();
            form41.Show();
            this.Hide();
        }

        int kb1, kb2, kb3, kb4, kb5, kb6, kb7, kb8, kb9, kb10, kb11, kb12;
        private void button12_Click(object sender, EventArgs e)
        {
            kb1 += 1;
            lblclearadet.Text = kb1.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            kb8 += 1;
            lblsacspreyiadet.Text = kb8.ToString();
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            kb12 += 1;
            lblmaske50adet.Text = kb12.ToString();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (kb1 >= 1)
                kb1 -= 1;
            lblclearadet.Text = kb1.ToString();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (kb2 >= 1)
                kb2 -= 1;
            lblsackremiadet.Text = kb2.ToString();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            if (kb3 >= 1)
                kb3 -= 1;
            lblyuztemizlemeadet.Text = kb3.ToString();
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            if (kb4 >= 1)
                kb4 -= 1;
            lblpanteneadet.Text = kb4.ToString();
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            if (kb5 >= 1)
                kb5 -= 1;
            lbldismacunadet.Text = kb5.ToString();
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            if (kb6 >= 1)
                kb6 -= 1;
            lbldisfircaadet.Text = kb6.ToString();
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            if (kb7 >= 1)
                kb7 -= 1;
            lblhacisakiradet.Text = kb7.ToString();
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            if (kb8 >= 1)
                kb8 -= 1;
            lblsacspreyiadet.Text = kb8.ToString();
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            if (kb9 >= 1)
                kb9 -= 1;
            lbltuvaletkadet.Text = kb9.ToString();
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            if (kb10 >= 1)
                kb10 -= 1;
            lblservispadet.Text = kb10.ToString();
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            if (kb11 >= 1)
                kb11 -= 1;
            lblniveakadet.Text = kb11.ToString();
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            if (kb12 >= 1)
                kb12 -= 1;
            lblmaske50adet.Text = kb12.ToString();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Seçilen Ürünler Sepete Eklenmiştir");

            KBAKIM clsamp = new KBAKIM();
            clsamp.Ad = "CLEAR SAMP";
            clsamp.Adet = Convert.ToInt16(lblclearadet.Text);
            clsamp.Agırlık = 0.800 * clsamp.Adet;
            clsamp.Fiyat = 45.90 * clsamp.Adet;

            KBAKIM skremi = new KBAKIM();
            skremi.Ad = "SAC KREMI";
            skremi.Adet = Convert.ToInt16(lblsackremiadet.Text);
            skremi.Agırlık = 0.300 * skremi.Adet;
            skremi.Fiyat = 22.75 * skremi.Adet;

            KBAKIM ytemız = new KBAKIM();
            ytemız.Ad = "YUZ TEMIZLEME SUYU";
            ytemız.Adet = Convert.ToInt16(lblyuztemizlemeadet.Text);
            ytemız.Agırlık = 0.200 * ytemız.Adet;
            ytemız.Fiyat = 23.95 * ytemız.Adet;

            KBAKIM psamp = new KBAKIM();
            psamp.Ad = "PANTENE SAMP";
            psamp.Adet = Convert.ToInt16(lblpanteneadet.Text);
            psamp.Agırlık = 0.600 * psamp.Adet;
            psamp.Fiyat = 33.50 * psamp.Adet;

            KBAKIM dmacun = new KBAKIM();
            dmacun.Ad = "DIS MACUNU";
            dmacun.Adet = Convert.ToInt16(lbldismacunadet.Text);
            dmacun.Agırlık = 0.200 * dmacun.Adet;
            dmacun.Fiyat = 21.95 * dmacun.Adet;

            KBAKIM dfirca = new KBAKIM();
            dfirca.Ad = "DIS FIRCASI 2'LI";
            dfirca.Adet = Convert.ToInt16(lbldisfircaadet.Text);
            dfirca.Agırlık = 0.036 * dfirca.Adet;
            dfirca.Fiyat = 24.95 * dfirca.Adet;

            KBAKIM hsakir = new KBAKIM();
            hsakir.Ad = "HACI SAKIR 4'LU";
            hsakir.Adet = Convert.ToInt16(lblhacisakiradet.Text);
            hsakir.Agırlık = 0.600 * hsakir.Adet;
            hsakir.Fiyat = 20.90 * hsakir.Adet;

            KBAKIM ssprey = new KBAKIM();
            ssprey.Ad = "CLEAR SAMP";
            ssprey.Adet = Convert.ToInt16(lblsacspreyiadet.Text);
            ssprey.Agırlık = 0.300 * ssprey.Adet;
            ssprey.Fiyat = 27.95 * ssprey.Adet;

            KBAKIM sekiztuval = new KBAKIM();
            sekiztuval.Ad = "8'LI TUVALET KAGIDI";
            sekiztuval.Adet = Convert.ToInt16(lbltuvaletkadet.Text);
            sekiztuval.Fiyat = 24.95 * sekiztuval.Adet;

            KBAKIM servispec = new KBAKIM();
            servispec.Ad = "SERVIS PECETE";
            servispec.Adet = Convert.ToInt16(lblservispadet.Text);
            servispec.Fiyat = 24.95 * servispec.Adet;

            KBAKIM niveaelk = new KBAKIM();
            niveaelk.Ad = "NIVEA EL KREMI";
            niveaelk.Adet = Convert.ToInt16(lblniveakadet.Text);
            niveaelk.Agırlık = 0.250 * niveaelk.Adet;
            niveaelk.Fiyat = 27.95 * niveaelk.Adet;

            KBAKIM maske = new KBAKIM();
            maske.Ad = "MASKE 50'LI";
            maske.Adet = Convert.ToInt16(lblmaske50adet.Text);
            maske.Fiyat = 34.95 * maske.Adet;

            Sql_Baglantisi bgl = new Sql_Baglantisi();

            int a = Convert.ToInt16(clsamp.Adet);
            if (a > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", clsamp.Ad);
                komut.Parameters.AddWithValue("@p2", clsamp.Adet);
                komut.Parameters.AddWithValue("@p7", clsamp.Agırlık);
                komut.Parameters.AddWithValue("@p5", clsamp.Kdv());
                komut.Parameters.AddWithValue("@p3", clsamp.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", clsamp.Fiyat);
                komut.Parameters.AddWithValue("@p4", clsamp.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }


            int a1 = Convert.ToInt16(skremi.Adet);
            if (a1 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", skremi.Ad);
                komut.Parameters.AddWithValue("@p2", skremi.Adet);
                komut.Parameters.AddWithValue("@p7", skremi.Agırlık);
                komut.Parameters.AddWithValue("@p5", skremi.Kdv());
                komut.Parameters.AddWithValue("@p3", skremi.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", skremi.Fiyat);
                komut.Parameters.AddWithValue("@p4", skremi.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }


            int a2 = Convert.ToInt16(ytemız.Adet);
            if (a2 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", ytemız.Ad);
                komut.Parameters.AddWithValue("@p2", ytemız.Adet);
                komut.Parameters.AddWithValue("@p7", ytemız.Agırlık);
                komut.Parameters.AddWithValue("@p5", ytemız.Kdv());
                komut.Parameters.AddWithValue("@p3", ytemız.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", ytemız.Fiyat);
                komut.Parameters.AddWithValue("@p4", ytemız.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a3 = Convert.ToInt16(psamp.Adet);
            if (a3 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", psamp.Ad);
                komut.Parameters.AddWithValue("@p2", psamp.Adet);
                komut.Parameters.AddWithValue("@p7", psamp.Agırlık);
                komut.Parameters.AddWithValue("@p5", psamp.Kdv());
                komut.Parameters.AddWithValue("@p3", psamp.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", psamp.Fiyat);
                komut.Parameters.AddWithValue("@p4", psamp.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a4 = Convert.ToInt16(dmacun.Adet);
            if (a4 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", dmacun.Ad);
                komut.Parameters.AddWithValue("@p2", dmacun.Adet);
                komut.Parameters.AddWithValue("@p7", dmacun.Agırlık);
                komut.Parameters.AddWithValue("@p5", dmacun.Kdv());
                komut.Parameters.AddWithValue("@p3", dmacun.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", dmacun.Fiyat);
                komut.Parameters.AddWithValue("@p4", dmacun.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a5 = Convert.ToInt16(dfirca.Adet);
            if (a5 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

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


            int a6 = Convert.ToInt16(hsakir.Adet);
            if (a6 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

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

            int a7 = Convert.ToInt16(ssprey.Adet);
            if (a7 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", ssprey.Ad);
                komut.Parameters.AddWithValue("@p2", ssprey.Adet);
                komut.Parameters.AddWithValue("@p7", ssprey.Agırlık);
                komut.Parameters.AddWithValue("@p5", ssprey.Kdv());
                komut.Parameters.AddWithValue("@p3", ssprey.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", ssprey.Fiyat);
                komut.Parameters.AddWithValue("@p4", ssprey.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a8 = Convert.ToInt16(sekiztuval.Adet);
            if (a8 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

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

            int a9 = Convert.ToInt16(servispec.Adet);
            if (a9 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", servispec.Ad);
                komut.Parameters.AddWithValue("@p2", servispec.Adet);
                komut.Parameters.AddWithValue("@p7", servispec.Agırlık);
                komut.Parameters.AddWithValue("@p5", servispec.Kdv());
                komut.Parameters.AddWithValue("@p3", servispec.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", servispec.Fiyat);
                komut.Parameters.AddWithValue("@p4", servispec.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a10 = Convert.ToInt16(niveaelk.Adet);
            if (a10 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", niveaelk.Ad);
                komut.Parameters.AddWithValue("@p2", niveaelk.Adet);
                komut.Parameters.AddWithValue("@p7", niveaelk.Agırlık);
                komut.Parameters.AddWithValue("@p5", niveaelk.Kdv());
                komut.Parameters.AddWithValue("@p3", niveaelk.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", niveaelk.Fiyat);
                komut.Parameters.AddWithValue("@p4", niveaelk.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }


            int a11 = Convert.ToInt16(maske.Adet);
            if (a11 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

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

        private void button28_Click_1(object sender, EventArgs e)
        {
            kb11 += 1;
            lblniveakadet.Text = kb11.ToString();
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            kb10 += 1;
            lblservispadet.Text = kb10.ToString();
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            kb9 += 1;
            lbltuvaletkadet.Text = kb9.ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (kb11 >= 1)
                kb11 -= 1;
            lblniveakadet.Text = kb11.ToString();
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            kb7 += 1;
            lblhacisakiradet.Text = kb7.ToString();
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            kb6 += 1;
            lbldisfircaadet.Text = kb6.ToString();
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            kb5 += 1;
            lbldismacunadet.Text = kb5.ToString();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            kb4 += 1;
            lblpanteneadet.Text = kb4.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            kb3 += 1;
            lblyuztemizlemeadet.Text = kb3.ToString();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            kb2 += 1;
            lblsackremiadet.Text = kb2.ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (kb12 >= 1)
                kb12 -= 1;
            lblmaske50adet.Text = kb12.ToString();
        }
    }
}
    

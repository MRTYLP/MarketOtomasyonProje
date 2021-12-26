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
    public partial class Frm_Icecekler : Form
    {
        

    public Frm_Icecekler()
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
            Frm_Onecikanlar form41 = new Frm_Onecikanlar();
            form41.Show();
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Frm_Sepet form49 = new Frm_Sepet();
            form49.Show();
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
            label41.Text = DateTime.Now.ToLongDateString();
            label40.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form42_Load(object sender, EventArgs e)
        {
            timer1.Start();           
        }

         int i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12;

        private void button12_Click_2(object sender, EventArgs e)
        {
            i1 += 1;
            lblsuadet.Text = i1.ToString();                                                   
        }

        private void button13_Click_2(object sender, EventArgs e)
        {
            if (i1 >= 1)
                i1 -= 1;
            lblsuadet.Text = i1.ToString();                         
        }

        private void button11_Click_2(object sender, EventArgs e)
        {
            if (i2 >= 1)
                i2 -= 1;
            lblsu5adet.Text = i2.ToString();
        }

        private void button15_Click_2(object sender, EventArgs e)
        {
            if (i3 >= 1)
                i3 -= 1;
            lblfantaadet.Text = i3.ToString();
        }

        private void button17_Click_2(object sender, EventArgs e)
        {
            if (i4 >= 1)
                i4 -= 1;
            lblpepsiadet.Text = i4.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (i5 >= 1)
                i5 -= 1;
            lblcola330adet.Text = i5.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (i6 >= 1)
                i6 -= 1;
            lblsprite330adet.Text = i6.ToString();
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            if (i7 >= 1)
                i7 -= 1;
            lblcola25adet.Text = i7.ToString();
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            if (i8 >= 1)
                i8 -= 1;
            lblcapriadet.Text = i8.ToString();
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            if (i9 >= 1)
                i9 -= 1;
            lblsprite15adet.Text = i9.ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (i10 >= 1)
                i10 -= 1;
            lblucluadet.Text = i10.ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (i11 >= 1)
                i11 -= 1;
            lbldimesadet.Text = i11.ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (i12 >= 1)
                i12 -= 1;
            lblayranadet.Text = i12.ToString();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("Seçilen Ürünler Sepete Eklenmiştir");
            ICECEK ksu = new ICECEK();
            ksu.Ad = "SU";
            ksu.Adet = Convert.ToInt16(lblsuadet.Text);
            ksu.Kdv();
            ksu.Agırlık = 0.5;
            ksu.Fiyat = 1.50;

            ICECEK bsu = new ICECEK();
            bsu.Ad = "BUYUK SU";
            bsu.Adet = Convert.ToInt16(lblsu5adet.Text);
            bsu.Kdv();
            bsu.Agırlık = 5;
            bsu.Fiyat = 5.30;

            ICECEK fanta = new ICECEK();
            fanta.Ad = "FANTA";
            fanta.Adet = Convert.ToInt16(lblfantaadet.Text);
            fanta.Kdv();
            fanta.Agırlık = 0.330;
            fanta.Fiyat = 4.80;

            ICECEK pepsi = new ICECEK();
            pepsi.Ad = "PEPSİ";
            pepsi.Adet = Convert.ToInt16(lblpepsiadet.Text);
            pepsi.Kdv();
            pepsi.Agırlık = 0.330;
            pepsi.Fiyat = 4.80;

            ICECEK kkola = new ICECEK();
            kkola.Ad = "COCA COLA";
            kkola.Adet = Convert.ToInt16(lblcola330adet.Text);
            kkola.Kdv();
            kkola.Agırlık = 0.330;
            kkola.Fiyat = 4.80;

            ICECEK ksprite = new ICECEK();
            ksprite.Ad = "SPRITE";
            ksprite.Adet = Convert.ToInt16(lblsprite330adet.Text);
            ksprite.Kdv();
            ksprite.Agırlık = 0.330;
            ksprite.Fiyat = 4.80;


            ICECEK bkola = new ICECEK();
            bkola.Ad = "COCA COLA";
            bkola.Adet = Convert.ToInt16(lblcola25adet.Text);
            bkola.Kdv();
            bkola.Agırlık = 2.5;
            bkola.Fiyat = 11.25;

            ICECEK csun = new ICECEK();
            csun.Ad = "CAPRI-SUN";
            csun.Adet = Convert.ToInt16(lblcapriadet.Text);
            csun.Kdv();
            csun.Agırlık = 200;
            csun.Fiyat = 3.25;

            ICECEK bsprite = new ICECEK();
            bsprite.Ad = "SPRITE";
            bsprite.Adet = Convert.ToInt16(lblsprite15adet.Text);
            bsprite.Kdv();
            bsprite.Agırlık = 1.5;
            bsprite.Fiyat = 7.00;

            ICECEK ucicecek = new ICECEK();
            ucicecek.Ad = "UCLU ICECEK";
            ucicecek.Adet = Convert.ToInt16(lblucluadet.Text);
            ucicecek.Kdv();
            ucicecek.Agırlık = 1.5;
            ucicecek.Fiyat = 17.90;

            ICECEK dkarisik = new ICECEK();
            dkarisik.Ad = "DIMES KARISIK";
            dkarisik.Adet = Convert.ToInt16(lbldimesadet.Text);
            dkarisik.Kdv();
            dkarisik.Agırlık = 1.5;
            dkarisik.Fiyat = 6.00;

            ICECEK ayran = new ICECEK();
            ayran.Ad = "AYRAN";
            ayran.Adet = Convert.ToInt16(lblayranadet.Text);
            ayran.Kdv();
            ayran.Agırlık = 1.5;
            ayran.Fiyat = 6.00;



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

            int a1 = Convert.ToInt16(bsu.Adet);
            if (a1 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", bsu.Ad);
                komut.Parameters.AddWithValue("@p2", bsu.Adet);
                komut.Parameters.AddWithValue("@p7", bsu.Agırlık);
                komut.Parameters.AddWithValue("@p5", bsu.Kdv());
                komut.Parameters.AddWithValue("@p3", bsu.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", bsu.Fiyat);
                komut.Parameters.AddWithValue("@p4", bsu.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a2 = Convert.ToInt16(fanta.Adet);
            if (a2 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", fanta.Ad);
                komut.Parameters.AddWithValue("@p2", fanta.Adet);
                komut.Parameters.AddWithValue("@p7", fanta.Agırlık);
                komut.Parameters.AddWithValue("@p5", fanta.Kdv());
                komut.Parameters.AddWithValue("@p3", fanta.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", fanta.Fiyat);
                komut.Parameters.AddWithValue("@p4", fanta.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a3 = Convert.ToInt16(pepsi.Adet);
            if (a3 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", pepsi.Ad);
                komut.Parameters.AddWithValue("@p2", pepsi.Adet);
                komut.Parameters.AddWithValue("@p7", pepsi.Agırlık);
                komut.Parameters.AddWithValue("@p5", pepsi.Kdv());
                komut.Parameters.AddWithValue("@p3", pepsi.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", pepsi.Fiyat);
                komut.Parameters.AddWithValue("@p4", pepsi.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a4 = Convert.ToInt16(kkola.Adet);
            if (a4 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", kkola.Ad);
                komut.Parameters.AddWithValue("@p2", kkola.Adet);
                komut.Parameters.AddWithValue("@p7", kkola.Agırlık);
                komut.Parameters.AddWithValue("@p5", kkola.Kdv());
                komut.Parameters.AddWithValue("@p3", kkola.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", kkola.Fiyat);
                komut.Parameters.AddWithValue("@p4", bkola.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a5 = Convert.ToInt16(ksprite.Adet);
            if (a5 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", ksprite.Ad);
                komut.Parameters.AddWithValue("@p2", ksprite.Adet);
                komut.Parameters.AddWithValue("@p7", ksprite.Agırlık);
                komut.Parameters.AddWithValue("@p5", ksprite.Kdv());
                komut.Parameters.AddWithValue("@p3", ksprite.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", ksprite.Fiyat);
                komut.Parameters.AddWithValue("@p4", ksprite.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a7 = Convert.ToInt16(bsprite.Adet);
            if (a7 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", bsprite.Ad);
                komut.Parameters.AddWithValue("@p2", bsprite.Adet);
                komut.Parameters.AddWithValue("@p7", bsprite.Agırlık);
                komut.Parameters.AddWithValue("@p5", bsprite.Kdv());
                komut.Parameters.AddWithValue("@p3", bsprite.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", bsprite.Fiyat);
                komut.Parameters.AddWithValue("@p4", bsprite.ToplamFiyatHesapla());

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }


            int a6 = Convert.ToInt16(csun.Adet);
            if (a6 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", csun.Ad);
                komut.Parameters.AddWithValue("@p2", csun.Adet);
                komut.Parameters.AddWithValue("@p7", csun.Agırlık);
                komut.Parameters.AddWithValue("@p5", csun.Kdv());
                komut.Parameters.AddWithValue("@p3", csun.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", csun.Fiyat);
                komut.Parameters.AddWithValue("@p4", csun.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a8 = Convert.ToInt16(ucicecek.Adet);
            if (a8 > 0)
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

            int a9 = Convert.ToInt16(dkarisik.Adet);
            if (a9 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", dkarisik.Ad);
                komut.Parameters.AddWithValue("@p2", dkarisik.Adet);
                komut.Parameters.AddWithValue("@p7", dkarisik.Agırlık);
                komut.Parameters.AddWithValue("@p5", dkarisik.Kdv());
                komut.Parameters.AddWithValue("@p3", dkarisik.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", dkarisik.Fiyat);
                komut.Parameters.AddWithValue("@p4", dkarisik.Adet * dkarisik.Fiyat);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a10 = Convert.ToInt16(ayran.Adet);
            if (a10 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", ayran.Ad);
                komut.Parameters.AddWithValue("@p2", ayran.Adet);
                komut.Parameters.AddWithValue("@p7", ayran.Agırlık);
                komut.Parameters.AddWithValue("@p5", ayran.Kdv());
                komut.Parameters.AddWithValue("@p3", ayran.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", ayran.Fiyat);
                komut.Parameters.AddWithValue("@p4", ayran.Adet * ayran.Fiyat);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            i12 += 1;
            lblayranadet.Text = i12.ToString();
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            i11 += 1;
            lbldimesadet.Text = i11.ToString();
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            i10 += 1;
            lblucluadet.Text = i10.ToString();
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            i9 += 1;
            lblsprite15adet.Text = i9.ToString();
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            i8 += 1;
            lblcapriadet.Text = i8.ToString();
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            i7 += 1;
            lblcola25adet.Text = i7.ToString();
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            i6 += 1;
            lblsprite330adet.Text = i6.ToString();


            ICECEK bsprite = new ICECEK();
            bsprite.Ad = "SPRITE";
            bsprite.Adet = Convert.ToInt32(lblsprite330adet.Text);
            bsprite.Agırlık = 1.5 * bsprite.Adet;
            bsprite.Fiyat = 7.00 * bsprite.Adet;
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            i5 += 1;
            lblcola330adet.Text = i5.ToString();
        }

        private void button16_Click_2(object sender, EventArgs e)
        {
            i4 += 1;
            lblpepsiadet.Text = i4.ToString();
        }

        private void button14_Click_2(object sender, EventArgs e)
        {
            i3 += 1;
            lblfantaadet.Text = i3.ToString();
        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            i2 += 1;
            lblsu5adet.Text = i2.ToString();
        }

    }
}
    

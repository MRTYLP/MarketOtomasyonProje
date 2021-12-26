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

    public partial class Frm_Bebekbakim : Form
    {
       
        public Frm_Bebekbakim()
        {
            InitializeComponent();
           
            BEBEKBAKIM emzik = new BEBEKBAKIM();
            
        }


        Sql_Baglantisi bgl = new Sql_Baglantisi();
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
            Frm_Anamenu form49 = new Frm_Anamenu();
            form49.Show();
            this.Hide();
        }


        private void button34_Click(object sender, EventArgs e)
        {
            Frm_Anamenu form1 = new Frm_Anamenu();
            form1.Show();
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label28.Text = DateTime.Now.ToLongDateString();
            label27.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form47_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void button34_Click_1(object sender, EventArgs e)
        {
            Frm_Onecikanlar form41 = new Frm_Onecikanlar();
            form41.Show();
            this.Hide();
        }

        int b1, b2, b3, b4, b5, b6, b7, b8;

        private void button22_Click(object sender, EventArgs e)
        {
            b8 += 1;
            lblbiberonadet.Text = b8.ToString();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            b1 += 1;
            lblniveaadet.Text = b1.ToString();
        }

        private void BtnNiveam_Click(object sender, EventArgs e)
        {
            if (b1 >= 1)
                b1 -= 1;
            lblniveaadet.Text = b1.ToString();

            int c1 = Convert.ToInt16(lblniveaadet.Text);

            // SEPETTEN ÜRÜN SİLME
            if (c1 == 0)
            {
                SqlCommand komut = new SqlCommand("Delete from Tbl_Sepetim where ÜrünAdı='Nivea'", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (b2 >= 1)
                b2 -= 1;
            lbldalinadet.Text = b2.ToString();

            int c2 = Convert.ToInt16(lblniveaadet.Text);

            // SEPETTEN ÜRÜN SİLME
            if (c2 == 0)
            {
                SqlCommand komut = new SqlCommand("Delete from Tbl_Sepetim where ÜrünAdı='Dalin'", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            if (b3 >= 1)
                b3 -= 1;
            lblmamaadet.Text = b3.ToString();
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            if (b4 >= 1)
                b4 -= 1;
            lblpampersadet.Text = b4.ToString();
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            if (b5 >= 1)
                b5 -= 1;
            lblprimaadet.Text = b5.ToString();
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            if (b6 >= 1)
                b6 -= 1;
            lblbepantholpadet.Text = b6.ToString();
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            if (b7 >= 1)
                b7 -= 1;
            lblemzikadet.Text = b7.ToString();
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            if (b8 >= 1)
                b8 -= 1;
            lblbiberonadet.Text = b8.ToString();
        }

        public void button8_Click_2(object sender, EventArgs e)
        {
            Frm_Sepet form49 = new Frm_Sepet();
            form49.Show();
            this.Hide();   
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Seçilen Ürünler Sepete Eklenmiştir");

            BEBEKBAKIM nıvsamp = new BEBEKBAKIM();
            nıvsamp.Ad = "NIVEA SAMP";
            nıvsamp.Adet = Convert.ToInt16(lblniveaadet.Text);
            nıvsamp.Kdv();
            nıvsamp.Agırlık = 0.800;
            nıvsamp.Fiyat = 80;


            BEBEKBAKIM dalınsamp = new BEBEKBAKIM();
            dalınsamp.Ad = "DALIN SAMP";
            dalınsamp.Adet = Convert.ToInt16(lbldalinadet.Text);
            dalınsamp.Kdv();
            dalınsamp.Agırlık = 0.800;
            dalınsamp.Fiyat = 20;

            BEBEKBAKIM mama = new BEBEKBAKIM();
            mama.Ad = "MAMA(8-9 AY)";
            mama.Adet = Convert.ToInt16(lblmamaadet.Text);
            mama.Kdv();
            mama.Agırlık = 0.650 * mama.Adet;
            mama.Fiyat = 63;

            BEBEKBAKIM pampbez = new BEBEKBAKIM();
            pampbez.Ad = "PAMPERS BEZ 18'LI ";
            pampbez.Adet = Convert.ToInt16(lblpampersadet.Text);
            pampbez.Kdv();
            pampbez.Fiyat = 43;

            BEBEKBAKIM prımabez = new BEBEKBAKIM();
            prımabez.Ad = "PRIMA BEBEK BEZ(52'LI)";
            prımabez.Adet = Convert.ToInt16(lblprimaadet.Text);
            prımabez.Kdv();
            prımabez.Fiyat = 109;

            BEBEKBAKIM bepant = new BEBEKBAKIM();
            bepant.Ad = "BEPANTHOL";
            bepant.Adet = Convert.ToInt16(lblbepantholpadet.Text);
            bepant.Kdv();
            bepant.Agırlık = 0.050;
            bepant.Fiyat = 30;

            BEBEKBAKIM emzik = new BEBEKBAKIM();
            emzik.Ad = "EMZIK";
            emzik.Kdv();
            emzik.Adet = Convert.ToInt16(lblemzikadet.Text);
            emzik.Fiyat = 19;

            BEBEKBAKIM biberon = new BEBEKBAKIM();
            biberon.Ad = "BIBERON";
            biberon.Adet = Convert.ToInt16(lblbiberonadet.Text);
            biberon.Kdv();
            biberon.Agırlık = 0.240;
            biberon.Fiyat = 47;

            int a = Convert.ToInt16(lblniveaadet.Text);
            if (a > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@P5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", nıvsamp.Ad);
                komut.Parameters.AddWithValue("@p2", nıvsamp.Adet);
                komut.Parameters.AddWithValue("@p7", nıvsamp.Agırlık);
                komut.Parameters.AddWithValue("@p5", nıvsamp.Kdv());
                komut.Parameters.AddWithValue("@p3", nıvsamp.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", nıvsamp.Fiyat);
                komut.Parameters.AddWithValue("@p4", nıvsamp.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a1 = Convert.ToInt16(lbldalinadet.Text);
            if (a1 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", dalınsamp.Ad);
                komut.Parameters.AddWithValue("@p2", dalınsamp.Adet);
                komut.Parameters.AddWithValue("@p7", dalınsamp.Agırlık);
                komut.Parameters.AddWithValue("@p5", dalınsamp.Kdv());
                komut.Parameters.AddWithValue("@p3", dalınsamp.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", dalınsamp.Fiyat);
                komut.Parameters.AddWithValue("@p4", dalınsamp.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a2 = Convert.ToInt16(lblmamaadet.Text);
            if (a2 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", mama.Ad);
                komut.Parameters.AddWithValue("@p2", mama.Adet);
                komut.Parameters.AddWithValue("@p7", mama.Agırlık);
                komut.Parameters.AddWithValue("@p5", mama.Kdv());
                komut.Parameters.AddWithValue("@p3", mama.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", mama.Fiyat);
                komut.Parameters.AddWithValue("@p4", mama.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a3 = Convert.ToInt16(lblpampersadet.Text);
            if (a3 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", pampbez.Ad);
                komut.Parameters.AddWithValue("@p2", pampbez.Adet);
                komut.Parameters.AddWithValue("@p7", pampbez.Agırlık);
                komut.Parameters.AddWithValue("@p5", pampbez.Kdv());
                komut.Parameters.AddWithValue("@p3", pampbez.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", pampbez.Fiyat);
                komut.Parameters.AddWithValue("@p4", pampbez.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a4 = Convert.ToInt16(lblprimaadet.Text);
            if (a4 > 0)
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

            int a5 = Convert.ToInt16(lblbepantholpadet.Text);
            if (a5 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", bepant.Ad);
                komut.Parameters.AddWithValue("@p2", bepant.Adet);
                komut.Parameters.AddWithValue("@p7", bepant.Agırlık);
                komut.Parameters.AddWithValue("@p5", bepant.Kdv());
                komut.Parameters.AddWithValue("@p3", bepant.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", bepant.Fiyat);
                komut.Parameters.AddWithValue("@p4", bepant.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }

            int a7 = Convert.ToInt16(lblemzikadet.Text);
            if (a7 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", emzik.Ad);
                komut.Parameters.AddWithValue("@p2", emzik.Adet);
                komut.Parameters.AddWithValue("@p7", emzik.Agırlık);
                komut.Parameters.AddWithValue("@p5", emzik.Kdv());
                komut.Parameters.AddWithValue("@p3", emzik.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", emzik.Fiyat);
                komut.Parameters.AddWithValue("@p4", emzik.ToplamFiyatHesapla());

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }


            int a6 = Convert.ToInt16(lblbiberonadet.Text);
            if (a6 > 0)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepetim (ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar) values (@p1,@p2,@p5,@p7,@p3,@p6,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", biberon.Ad);
                komut.Parameters.AddWithValue("@p2", biberon.Adet);
                komut.Parameters.AddWithValue("@p7", biberon.Agırlık);
                komut.Parameters.AddWithValue("@p5", biberon.Kdv());
                komut.Parameters.AddWithValue("@p3", biberon.KdvsizFiyatHesapla());
                komut.Parameters.AddWithValue("@p6", biberon.Fiyat);
                komut.Parameters.AddWithValue("@p4", biberon.ToplamFiyatHesapla());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            b8 += 1;
            lblbiberonadet.Text = b8.ToString();
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            b7 += 1;
            lblemzikadet.Text = b7.ToString();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            b6 += 1;
            lblbepantholpadet.Text = b6.ToString();
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            b5 += 1;
            lblprimaadet.Text = b5.ToString();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            b4 += 1;
            lblpampersadet.Text = b4.ToString();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            b3 += 1;
            lblmamaadet.Text = b3.ToString();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            b2 += 1;
            lbldalinadet.Text = b2.ToString();
        }
    }
}










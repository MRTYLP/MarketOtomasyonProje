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
    public partial class Fm_Stogaurunalim : Form
    {

        Sql_Baglantisi bgl = new Sql_Baglantisi();

         private void fillGridView()
         {
             DataTable dt = new DataTable();
             SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Stok", bgl.baglanti());
             da.Fill(dt);
             dataGridView1.DataSource = dt;
             bgl.baglanti().Close();
         }

        public Fm_Stogaurunalim()
        {
            InitializeComponent();
        }


        private void Form6_Load(object sender, EventArgs e)
        {
            fillGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cmburunadi.Text == "" || TxtKDV.Text == "" || Convert.ToInt32(TxtKDV.Text) == 0 || TxtAlısFiyat.Text == "" || Convert.ToInt32(TxtAlısFiyat.Text) == 0 || TxtAdet.Text == "" || Convert.ToInt32(TxtAdet.Text) == 0)
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Giriniz");
            }


            // STOĞA ÜRÜN EKLEME
            else
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Stok (UrunAdi,UrunKDV,UrunAlisFiyat,UrunMiktari,UrunBirimi,UrunGirisTarihi) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", cmburunadi.Text);
                komut.Parameters.AddWithValue("@p2", TxtKDV.Text);
                komut.Parameters.AddWithValue("@p3", TxtAlısFiyat.Text);
                komut.Parameters.AddWithValue("@p4", TxtAdet.Text);
                komut.Parameters.AddWithValue("@p5", CmbBirimi.Text);
                komut.Parameters.AddWithValue("@p6", SqlDbType.Date).Value = dateTimePicker1.Value.Date;

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                fillGridView();
                MessageBox.Show("Ürün Eklenmiştir");
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            // ANA MENUYE DONME

            Frm_Anamenu form1 = new Frm_Anamenu();
            form1.Show();
            this.Hide();
        }

        private void BtnGeriDon_Click(object sender, EventArgs e)
        {
            //YONETİCİ DETAYA DONME

            Frm_Yoneticidetay form5 = new Frm_Yoneticidetay();
            form5.Show();
            this.Hide();
        }
    }
}
       
    



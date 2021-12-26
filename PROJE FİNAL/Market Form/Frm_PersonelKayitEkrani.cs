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
    public partial class Frm_PersonelKayitEkrani : Form
    {
        public Frm_PersonelKayitEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Yoneticidetay form5 = new Frm_Yoneticidetay();
            form5.Show();
            this.Hide();
        }


        Sql_Baglantisi bgl = new Sql_Baglantisi();

        private void fillGridView()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Personeller", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            fillGridView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_Yoneticidetay form5 = new Frm_Yoneticidetay();
            form5.Show();
            this.Hide();


        }

        private void button5_Click(object sender, EventArgs e)
        {

            Frm_Anamenu form1 = new Frm_Anamenu();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TxtAdSoyad.Text == "" || rchAdres.Text == "" || MskTel.Text == "")
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Giriniz");
            }


            //Personel Ekleme
            else
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Personeller (PersonelAdSoyad,PersonelTel,PersonelAdres) values (@p1,@p2,@p3)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
                komut.Parameters.AddWithValue("@p2", MskTel.Text);
                komut.Parameters.AddWithValue("@p3", rchAdres.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                fillGridView();
                MessageBox.Show("Kaydınız Gerçekleştirilmiştir");
            }
        }

        //Tıklanan değeri textbox a yazdırma
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAdSoyad.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            MskTel.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            rchAdres.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }


        //Seçilen değeri silme
        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Personeller where PersonelAdSoyad=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            
            fillGridView();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
 
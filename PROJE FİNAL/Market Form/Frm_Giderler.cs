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
    public partial class Frm_Giderler : Form
    {

        Sql_Baglantisi bgl = new Sql_Baglantisi();

        public Frm_Giderler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Yoneticidetay form5 = new Frm_Yoneticidetay();
            form5.Show();
            this.Hide();
        }

       

        private void Form10_Load(object sender, EventArgs e)
        {
            fillGridView();
        }

        private void fillGridView()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Giderler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_Yoneticidetay form5 = new Frm_Yoneticidetay();
            form5.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
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

        private void BtnGideriKaydet_Click(object sender, EventArgs e)
        {
            if (TxtAdSoyad.Text == "" || TxtUcret.Text == "" || Convert.ToInt32(TxtUcret.Text) == 0 || CmbOdemeTuru.Text == "")
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Giriniz");
            }


            // Gider Eklemeelse
            else
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Giderler (AdSoyad,OdemeUcreti,IslemTarihi,OdemeTuru) values (@p1,@p2,@p3,@p4)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
                komut.Parameters.AddWithValue("@p2", TxtUcret.Text);
                komut.Parameters.AddWithValue("@p3", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                komut.Parameters.AddWithValue("@p4", CmbOdemeTuru.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                fillGridView();
                MessageBox.Show("Kaydınız Gerçekleştirilmiştir");
            }
        }

        private void BtnGideriSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Giderler where AdSoyad=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            
            fillGridView();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAdSoyad.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtUcret.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            //dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[2].ToString();
            CmbOdemeTuru.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }
    }
}

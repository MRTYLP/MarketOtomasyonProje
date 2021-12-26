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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        Sql_Baglantisi bgl = new Sql_Baglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Yoneticidetay form5 = new Frm_Yoneticidetay();
            form5.Show();
            this.Hide();
        }

        // Stoktaki ürünleri datagride e getirme
        private void fillGridView()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Stok", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }


        private void Form8_Load(object sender, EventArgs e)
        {
            fillGridView();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Frm_Yoneticidetay form5 = new Frm_Yoneticidetay();
            form5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Frm_Anamenu form1 = new Frm_Anamenu();
            form1.Show();
            this.Hide();
        }

        //Seçilen ürünü silme
        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Stok where UrunAdi=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtUrunAdi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            
            fillGridView();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // SEÇİLEN ÜRÜNÜ TEXTBOX A YAZDIRMA


            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtUrunAdi.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

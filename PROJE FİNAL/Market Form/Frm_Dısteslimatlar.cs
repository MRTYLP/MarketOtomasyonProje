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
    public partial class Frm_Dısteslimatlar : Form
    {
        public Frm_Dısteslimatlar()
        {
            InitializeComponent();
        }

        Sql_Baglantisi bgl = new Sql_Baglantisi();
        private void fillGridView()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Satıslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
        private void Form9_Load(object sender, EventArgs e)
        {
            fillGridView();

            SqlCommand komut5 = new SqlCommand("Select Sum(ÖdenenTutar) from Tbl_Satıslar", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblToplamSatis.Text = dr5[0].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Yoneticidetay form5 = new Frm_Yoneticidetay();
            form5.Show();
            this.Hide();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[2].RowIndex;
            txtADsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Satıslar where Adres=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtADsoyad.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            fillGridView();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SqlCommand komut5 = new SqlCommand("Select Sum(ÖdenenTutar) from Tbl_Satıslar", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblToplamSatis.Text = dr5[0].ToString();
            }
        }

      
    }
}

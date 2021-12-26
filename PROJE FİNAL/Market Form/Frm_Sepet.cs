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
    public partial class Frm_Sepet : Form
    {
        public Frm_Sepet()
        {
            InitializeComponent();
        }

        Sql_Baglantisi bgl = new Sql_Baglantisi();
        private void button8_Click(object sender, EventArgs e)
        {
            Frm_Onecikanlar form41 = new Frm_Onecikanlar();
            form41.Show();
            this.Hide();
        }

        private void fillGridView()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select distinct ÜrünID,ÜrünAdı,ÜrünAdedi,KDV,Litre_KG,KDVsiz,KDVli,ToplamTutar from Tbl_Sepetim", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
            bgl.baglanti().Close();
        }
        
        private void Form49_Load(object sender, EventArgs e)
        {           
            fillGridView();
            bgl.baglanti();
            SqlCommand komut5 = new SqlCommand("Select Sum(ToplamTutar) from Tbl_Sepetim", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lbltutar.Text = dr5[0].ToString();
            }    
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (lbltutar.Text == "")
            {
                MessageBox.Show("Sepetinizde Ürün Bulunmamaktadır");
            }

            else
            {
                Frm_KrediKarti form50 = new Frm_KrediKarti();
                form50.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lbltutar.Text == "")
            {
                MessageBox.Show("Sepetinizde Ürün Bulunmamaktadır");
            }
            else
            {
                Frm_Nakit form51 = new Frm_Nakit();
                form51.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lbltutar.Text == "")
            {
                MessageBox.Show("Sepetinizde Ürün Bulunmamaktadır");
            }

            else
            {
                Frm_Cek form52 = new Frm_Cek();
                form52.Show();
                this.Hide();
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Frm_Anamenu form1 = new Frm_Anamenu();
            form1.Show();
            this.Hide();
        }

        
        private void button34_Click_1(object sender, EventArgs e)
        {
            Frm_Onecikanlar form41 = new Frm_Onecikanlar();
            form41.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Delete from Tbl_Sepetim", bgl.baglanti());
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            fillGridView();
            lbltutar.Text = "0";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Sepetim where ÜrünID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            SqlCommand komut5 = new SqlCommand("Select Sum(ToplamTutar) from Tbl_Sepetim", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lbltutar.Text = dr5[0].ToString();
            }

            fillGridView();
           
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }        
    }
}

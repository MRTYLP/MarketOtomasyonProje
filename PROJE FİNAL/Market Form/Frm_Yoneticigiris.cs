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
    public partial class Frm_Yoneticigiris : Form
    {
        public Frm_Yoneticigiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Anamenu form1 = new Frm_Anamenu();
            form1.Show();
            this.Hide();
        }

        Sql_Baglantisi bgl = new Sql_Baglantisi();

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yoneticiler Where YoneticiTC=@p1 and YoneticiSifre=@p2", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", TxtTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                Frm_Yoneticidetay fr = new Frm_Yoneticidetay();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre");
            }
            bgl.baglanti().Close();
        }

        private void Frm_Yoneticigiris_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_Form
{
    public partial class Frm_Yoneticidetay : Form
    {
        public Frm_Yoneticidetay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Yoneticigiris form4 = new Frm_Yoneticigiris();
            form4.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Fm_Stogaurunalim form6 = new Fm_Stogaurunalim();
            form6.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Dısteslimatlar form9 = new Frm_Dısteslimatlar();
            form9.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_Giderler form10 = new Frm_Giderler();
            form10.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_PersonelKayitEkrani form11 = new Frm_PersonelKayitEkrani();
            form11.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString();
            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}

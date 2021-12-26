
namespace Market_Form
{
    partial class Frm_Giderler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Giderler));
            this.button1 = new System.Windows.Forms.Button();
            this.BtnGideriSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGideriKaydet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnGeriDon = new System.Windows.Forms.Button();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(6, 815);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 111);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BtnGideriSil
            // 
            this.BtnGideriSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(147)))), ((int)(((byte)(64)))));
            this.BtnGideriSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGideriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGideriSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnGideriSil.Location = new System.Drawing.Point(934, 406);
            this.BtnGideriSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGideriSil.Name = "BtnGideriSil";
            this.BtnGideriSil.Size = new System.Drawing.Size(104, 68);
            this.BtnGideriSil.TabIndex = 8;
            this.BtnGideriSil.Text = "GİDERİ SİL";
            this.BtnGideriSil.UseVisualStyleBackColor = false;
            this.BtnGideriSil.Click += new System.EventHandler(this.BtnGideriSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(790, 47);
            this.label1.TabIndex = 10;
            this.label1.Text = "EK GİDERLER VEYA PERSONEL ÜCRETLERİ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Location = new System.Drawing.Point(888, 293);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 27);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // TxtUcret
            // 
            this.TxtUcret.BackColor = System.Drawing.Color.White;
            this.TxtUcret.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUcret.Location = new System.Drawing.Point(888, 248);
            this.TxtUcret.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtUcret.Multiline = true;
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Size = new System.Drawing.Size(136, 22);
            this.TxtUcret.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(740, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "ADI SOYADI :";
            // 
            // CmbOdemeTuru
            // 
            this.CmbOdemeTuru.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CmbOdemeTuru.FormattingEnabled = true;
            this.CmbOdemeTuru.Items.AddRange(new object[] {
            "MAAŞ",
            "BENZİN",
            "DİGER"});
            this.CmbOdemeTuru.Location = new System.Drawing.Point(889, 348);
            this.CmbOdemeTuru.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbOdemeTuru.Name = "CmbOdemeTuru";
            this.CmbOdemeTuru.Size = new System.Drawing.Size(136, 28);
            this.CmbOdemeTuru.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(740, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "ÖDEME TÜRÜ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(729, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "İŞLEM TARİH :";
            // 
            // BtnGideriKaydet
            // 
            this.BtnGideriKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(147)))), ((int)(((byte)(64)))));
            this.BtnGideriKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGideriKaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnGideriKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGideriKaydet.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGideriKaydet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnGideriKaydet.Location = new System.Drawing.Point(811, 406);
            this.BtnGideriKaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGideriKaydet.Name = "BtnGideriKaydet";
            this.BtnGideriKaydet.Size = new System.Drawing.Size(104, 68);
            this.BtnGideriKaydet.TabIndex = 24;
            this.BtnGideriKaydet.Text = "GİDERİ KAYDET";
            this.BtnGideriKaydet.UseVisualStyleBackColor = false;
            this.BtnGideriKaydet.Click += new System.EventHandler(this.BtnGideriKaydet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(718, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "ÖDEME ÜCRETİ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(805, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 33);
            this.label6.TabIndex = 36;
            this.label6.Text = "GİDER KAYIT";
            // 
            // BtnGeriDon
            // 
            this.BtnGeriDon.BackColor = System.Drawing.Color.Transparent;
            this.BtnGeriDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGeriDon.BackgroundImage")));
            this.BtnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGeriDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGeriDon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.BtnGeriDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnGeriDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeriDon.Location = new System.Drawing.Point(12, 675);
            this.BtnGeriDon.Name = "BtnGeriDon";
            this.BtnGeriDon.Size = new System.Drawing.Size(72, 66);
            this.BtnGeriDon.TabIndex = 49;
            this.BtnGeriDon.UseVisualStyleBackColor = false;
            this.BtnGeriDon.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // BtnKapat
            // 
            this.BtnKapat.BackColor = System.Drawing.Color.Transparent;
            this.BtnKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnKapat.BackgroundImage")));
            this.BtnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKapat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.BtnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKapat.Location = new System.Drawing.Point(90, 676);
            this.BtnKapat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(72, 65);
            this.BtnKapat.TabIndex = 48;
            this.BtnKapat.UseVisualStyleBackColor = false;
            this.BtnKapat.Click += new System.EventHandler(this.button5_Click);
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.BackColor = System.Drawing.Color.White;
            this.TxtAdSoyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtAdSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAdSoyad.Location = new System.Drawing.Point(889, 199);
            this.TxtAdSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtAdSoyad.Multiline = true;
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(136, 22);
            this.TxtAdSoyad.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(40, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 556);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GİDERLER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(661, 530);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Frm_Giderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnGeriDon);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TxtUcret);
            this.Controls.Add(this.TxtAdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbOdemeTuru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGideriKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGideriSil);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Frm_Giderler";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnGideriSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TxtUcret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbOdemeTuru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGideriKaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnGeriDon;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
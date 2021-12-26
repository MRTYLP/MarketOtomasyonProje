namespace Market_Form
{
    partial class Frm_Nakit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Nakit));
            this.BtnGeriDon = new System.Windows.Forms.Button();
            this.BtnSiparisVer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGeriDon
            // 
            this.BtnGeriDon.BackColor = System.Drawing.Color.Transparent;
            this.BtnGeriDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGeriDon.BackgroundImage")));
            this.BtnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGeriDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeriDon.Location = new System.Drawing.Point(12, 726);
            this.BtnGeriDon.Name = "BtnGeriDon";
            this.BtnGeriDon.Size = new System.Drawing.Size(79, 83);
            this.BtnGeriDon.TabIndex = 48;
            this.BtnGeriDon.UseVisualStyleBackColor = false;
            this.BtnGeriDon.Click += new System.EventHandler(this.button8_Click);
            // 
            // BtnSiparisVer
            // 
            this.BtnSiparisVer.BackColor = System.Drawing.Color.Transparent;
            this.BtnSiparisVer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSiparisVer.FlatAppearance.BorderSize = 3;
            this.BtnSiparisVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnSiparisVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSiparisVer.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.BtnSiparisVer.ForeColor = System.Drawing.Color.White;
            this.BtnSiparisVer.Location = new System.Drawing.Point(440, 684);
            this.BtnSiparisVer.Name = "BtnSiparisVer";
            this.BtnSiparisVer.Size = new System.Drawing.Size(329, 71);
            this.BtnSiparisVer.TabIndex = 51;
            this.BtnSiparisVer.Text = "SİPARİŞ VER";
            this.BtnSiparisVer.UseVisualStyleBackColor = false;
            this.BtnSiparisVer.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(306, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 38);
            this.label2.TabIndex = 55;
            this.label2.Text = "Adres :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(383, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "KAYITLI ADRES HARİCİNDE BİR ADRESE TESLİMAT İÇİN KULLANINIZ!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(383, 594);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "ADRESİNİZ AYNI İSE SİPARİŞ BUTONUNA TIKLAYINIZ!";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(440, 209);
            this.txtAdSoyad.MaxLength = 50;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(329, 45);
            this.txtAdSoyad.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(248, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 38);
            this.label4.TabIndex = 59;
            this.label4.Text = "Ad Soyad : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(464, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 46);
            this.label5.TabIndex = 61;
            this.label5.Text = "Ödeme bilgileri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(849, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(306, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 38);
            this.label6.TabIndex = 63;
            this.label6.Text = "Tarih : ";
            // 
            // rchAdres
            // 
            this.rchAdres.Location = new System.Drawing.Point(440, 277);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(329, 108);
            this.rchAdres.TabIndex = 64;
            this.rchAdres.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(440, 416);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(329, 30);
            this.dateTimePicker1.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(148, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 38);
            this.label7.TabIndex = 67;
            this.label7.Text = "Ödenecek Tutar : ";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.BackColor = System.Drawing.Color.Transparent;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(433, 488);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(53, 38);
            this.lblTutar.TabIndex = 66;
            this.lblTutar.Text = "00";
            
            // 
            // Frm_Nakit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 821);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rchAdres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSiparisVer);
            this.Controls.Add(this.BtnGeriDon);
            this.MaximizeBox = false;
            this.Name = "Frm_Nakit";
            this.Text = "Ödeme Bilgileri";
            this.Load += new System.EventHandler(this.Frm_Nakit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGeriDon;
        private System.Windows.Forms.Button BtnSiparisVer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rchAdres;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTutar;
    }
}
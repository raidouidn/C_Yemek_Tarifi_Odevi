
namespace yemek_tarifi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTarifAdi = new System.Windows.Forms.Label();
            this.LblAdim = new System.Windows.Forms.Label();
            this.TxtTarifAdi = new System.Windows.Forms.TextBox();
            this.TxtAdim = new System.Windows.Forms.TextBox();
            this.BtnAdimEkle = new System.Windows.Forms.Button();
            this.BtnTarifiKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 89);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel2.Location = new System.Drawing.Point(-2, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(999, 62);
            this.panel2.TabIndex = 1;
            // 
            // LblTarifAdi
            // 
            this.LblTarifAdi.AutoSize = true;
            this.LblTarifAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTarifAdi.Location = new System.Drawing.Point(12, 144);
            this.LblTarifAdi.Name = "LblTarifAdi";
            this.LblTarifAdi.Size = new System.Drawing.Size(121, 25);
            this.LblTarifAdi.TabIndex = 2;
            this.LblTarifAdi.Text = "Tarifin Adı :";
            // 
            // LblAdim
            // 
            this.LblAdim.AutoSize = true;
            this.LblAdim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAdim.Location = new System.Drawing.Point(43, 195);
            this.LblAdim.Name = "LblAdim";
            this.LblAdim.Size = new System.Drawing.Size(90, 25);
            this.LblAdim.TabIndex = 3;
            this.LblAdim.Text = "1.Adım :";
            // 
            // TxtTarifAdi
            // 
            this.TxtTarifAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtTarifAdi.Location = new System.Drawing.Point(150, 142);
            this.TxtTarifAdi.Name = "TxtTarifAdi";
            this.TxtTarifAdi.Size = new System.Drawing.Size(262, 29);
            this.TxtTarifAdi.TabIndex = 4;
            // 
            // TxtAdim
            // 
            this.TxtAdim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdim.Location = new System.Drawing.Point(150, 193);
            this.TxtAdim.Name = "TxtAdim";
            this.TxtAdim.Size = new System.Drawing.Size(262, 29);
            this.TxtAdim.TabIndex = 5;
            // 
            // BtnAdimEkle
            // 
            this.BtnAdimEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdimEkle.Location = new System.Drawing.Point(150, 228);
            this.BtnAdimEkle.Name = "BtnAdimEkle";
            this.BtnAdimEkle.Size = new System.Drawing.Size(262, 35);
            this.BtnAdimEkle.TabIndex = 7;
            this.BtnAdimEkle.Text = "Adımı Ekle";
            this.BtnAdimEkle.UseVisualStyleBackColor = true;
            this.BtnAdimEkle.Click += new System.EventHandler(this.BtnAdimEkle_Click);
            // 
            // BtnTarifiKaydet
            // 
            this.BtnTarifiKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTarifiKaydet.Location = new System.Drawing.Point(150, 334);
            this.BtnTarifiKaydet.Name = "BtnTarifiKaydet";
            this.BtnTarifiKaydet.Size = new System.Drawing.Size(262, 52);
            this.BtnTarifiKaydet.TabIndex = 8;
            this.BtnTarifiKaydet.Text = "Tarifi Kaydet";
            this.BtnTarifiKaydet.UseVisualStyleBackColor = true;
            this.BtnTarifiKaydet.Click += new System.EventHandler(this.BtnTarifiKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(451, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tarifler :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(459, 147);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(500, 238);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(914, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(996, 480);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnTarifiKaydet);
            this.Controls.Add(this.BtnAdimEkle);
            this.Controls.Add(this.TxtAdim);
            this.Controls.Add(this.TxtTarifAdi);
            this.Controls.Add(this.LblAdim);
            this.Controls.Add(this.LblTarifAdi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblTarifAdi;
        private System.Windows.Forms.Label LblAdim;
        private System.Windows.Forms.TextBox TxtTarifAdi;
        private System.Windows.Forms.TextBox TxtAdim;
        private System.Windows.Forms.Button BtnAdimEkle;
        private System.Windows.Forms.Button BtnTarifiKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


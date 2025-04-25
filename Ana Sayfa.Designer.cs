namespace Stok_takip
{
    partial class Satıs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textad = new System.Windows.Forms.TextBox();
            this.textsoyad = new System.Windows.Forms.TextBox();
            this.texttelefon = new System.Windows.Forms.TextBox();
            this.textmail = new System.Windows.Forms.TextBox();
            this.textbarkod = new System.Windows.Forms.TextBox();
            this.textürünadı = new System.Windows.Forms.TextBox();
            this.textsatısfiyat = new System.Windows.Forms.TextBox();
            this.textmiktar = new System.Windows.Forms.TextBox();
            this.texttoplam = new System.Windows.Forms.TextBox();
            this.buttonekle = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.buttonsatısiptal = new System.Windows.Forms.Button();
            this.buttonsatısyap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonsatıslist = new System.Windows.Forms.Button();
            this.buttonürünlist = new System.Windows.Forms.Button();
            this.buttonürünkayıt = new System.Windows.Forms.Button();
            this.buttonmüslist = new System.Windows.Forms.Button();
            this.buttonmüskayıt = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxürün = new System.Windows.Forms.GroupBox();
            this.groupBoxmüşteri = new System.Windows.Forms.GroupBox();
            this.labelgenel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxürün.SuspendLayout();
            this.groupBoxmüşteri.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FloralWhite;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FloralWhite;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numara";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FloralWhite;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mail";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(378, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(740, 360);
            this.dataGridView1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FloralWhite;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Barkod Numarası";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FloralWhite;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(24, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ürün Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FloralWhite;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(24, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Satış Fiyatı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FloralWhite;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(24, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Miktarı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FloralWhite;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(24, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Toplam Fiyat";
            // 
            // textad
            // 
            this.textad.Location = new System.Drawing.Point(120, 44);
            this.textad.Name = "textad";
            this.textad.Size = new System.Drawing.Size(205, 22);
            this.textad.TabIndex = 10;
            this.textad.TextChanged += new System.EventHandler(this.textad_TextChanged);
            // 
            // textsoyad
            // 
            this.textsoyad.Location = new System.Drawing.Point(120, 76);
            this.textsoyad.Name = "textsoyad";
            this.textsoyad.Size = new System.Drawing.Size(205, 22);
            this.textsoyad.TabIndex = 11;
            // 
            // texttelefon
            // 
            this.texttelefon.Location = new System.Drawing.Point(120, 12);
            this.texttelefon.Name = "texttelefon";
            this.texttelefon.Size = new System.Drawing.Size(205, 22);
            this.texttelefon.TabIndex = 12;
            this.texttelefon.TextChanged += new System.EventHandler(this.texttelefon_TextChanged);
            // 
            // textmail
            // 
            this.textmail.Location = new System.Drawing.Point(120, 108);
            this.textmail.Name = "textmail";
            this.textmail.Size = new System.Drawing.Size(205, 22);
            this.textmail.TabIndex = 13;
            // 
            // textbarkod
            // 
            this.textbarkod.Location = new System.Drawing.Point(170, 14);
            this.textbarkod.Name = "textbarkod";
            this.textbarkod.Size = new System.Drawing.Size(164, 22);
            this.textbarkod.TabIndex = 14;
            this.textbarkod.TextChanged += new System.EventHandler(this.textbarkod_TextChanged);
            // 
            // textürünadı
            // 
            this.textürünadı.Location = new System.Drawing.Point(170, 42);
            this.textürünadı.Name = "textürünadı";
            this.textürünadı.Size = new System.Drawing.Size(164, 22);
            this.textürünadı.TabIndex = 15;
            // 
            // textsatısfiyat
            // 
            this.textsatısfiyat.Location = new System.Drawing.Point(170, 72);
            this.textsatısfiyat.Name = "textsatısfiyat";
            this.textsatısfiyat.Size = new System.Drawing.Size(164, 22);
            this.textsatısfiyat.TabIndex = 16;
            this.textsatısfiyat.TextChanged += new System.EventHandler(this.textsatısfiyat_TextChanged);
            // 
            // textmiktar
            // 
            this.textmiktar.Location = new System.Drawing.Point(170, 100);
            this.textmiktar.Name = "textmiktar";
            this.textmiktar.Size = new System.Drawing.Size(164, 22);
            this.textmiktar.TabIndex = 17;
            this.textmiktar.TextChanged += new System.EventHandler(this.textmiktar_TextChanged);
            // 
            // texttoplam
            // 
            this.texttoplam.Location = new System.Drawing.Point(170, 129);
            this.texttoplam.Name = "texttoplam";
            this.texttoplam.Size = new System.Drawing.Size(164, 22);
            this.texttoplam.TabIndex = 18;
            // 
            // buttonekle
            // 
            this.buttonekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonekle.Location = new System.Drawing.Point(378, 525);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(125, 34);
            this.buttonekle.TabIndex = 19;
            this.buttonekle.Text = "Ekle";
            this.buttonekle.UseVisualStyleBackColor = true;
            this.buttonekle.Click += new System.EventHandler(this.buttonekle_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonsil.Location = new System.Drawing.Point(540, 525);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(125, 34);
            this.buttonsil.TabIndex = 20;
            this.buttonsil.Text = "Sil";
            this.buttonsil.UseVisualStyleBackColor = true;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // buttonsatısiptal
            // 
            this.buttonsatısiptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonsatısiptal.Location = new System.Drawing.Point(698, 525);
            this.buttonsatısiptal.Name = "buttonsatısiptal";
            this.buttonsatısiptal.Size = new System.Drawing.Size(125, 34);
            this.buttonsatısiptal.TabIndex = 21;
            this.buttonsatısiptal.Text = "Satış İptal";
            this.buttonsatısiptal.UseVisualStyleBackColor = true;
            this.buttonsatısiptal.Click += new System.EventHandler(this.buttonsatısiptal_Click);
            // 
            // buttonsatısyap
            // 
            this.buttonsatısyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonsatısyap.Location = new System.Drawing.Point(993, 561);
            this.buttonsatısyap.Name = "buttonsatısyap";
            this.buttonsatısyap.Size = new System.Drawing.Size(125, 34);
            this.buttonsatısyap.TabIndex = 22;
            this.buttonsatısyap.Text = "Satış Yap";
            this.buttonsatısyap.UseVisualStyleBackColor = true;
            this.buttonsatısyap.Click += new System.EventHandler(this.buttonsatısyap_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonsatıslist);
            this.panel1.Controls.Add(this.buttonürünlist);
            this.panel1.Controls.Add(this.buttonürünkayıt);
            this.panel1.Controls.Add(this.buttonmüslist);
            this.panel1.Controls.Add(this.buttonmüskayıt);
            this.panel1.Location = new System.Drawing.Point(105, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 73);
            this.panel1.TabIndex = 23;
            // 
            // buttonsatıslist
            // 
            this.buttonsatıslist.Location = new System.Drawing.Point(809, 16);
            this.buttonsatıslist.Name = "buttonsatıslist";
            this.buttonsatıslist.Size = new System.Drawing.Size(150, 45);
            this.buttonsatıslist.TabIndex = 24;
            this.buttonsatıslist.Text = "Satış Listesi";
            this.buttonsatıslist.UseVisualStyleBackColor = true;
            this.buttonsatıslist.Click += new System.EventHandler(this.buttonsatıslist_Click);
            // 
            // buttonürünlist
            // 
            this.buttonürünlist.Location = new System.Drawing.Point(618, 16);
            this.buttonürünlist.Name = "buttonürünlist";
            this.buttonürünlist.Size = new System.Drawing.Size(150, 45);
            this.buttonürünlist.TabIndex = 23;
            this.buttonürünlist.Text = "Ürün Listesi";
            this.buttonürünlist.UseVisualStyleBackColor = true;
            this.buttonürünlist.Click += new System.EventHandler(this.buttonürünlist_Click);
            // 
            // buttonürünkayıt
            // 
            this.buttonürünkayıt.Location = new System.Drawing.Point(423, 16);
            this.buttonürünkayıt.Name = "buttonürünkayıt";
            this.buttonürünkayıt.Size = new System.Drawing.Size(150, 45);
            this.buttonürünkayıt.TabIndex = 22;
            this.buttonürünkayıt.Text = "Ürün Girişi";
            this.buttonürünkayıt.UseVisualStyleBackColor = true;
            this.buttonürünkayıt.Click += new System.EventHandler(this.buttonürünkayıt_Click);
            // 
            // buttonmüslist
            // 
            this.buttonmüslist.Location = new System.Drawing.Point(228, 16);
            this.buttonmüslist.Name = "buttonmüslist";
            this.buttonmüslist.Size = new System.Drawing.Size(150, 45);
            this.buttonmüslist.TabIndex = 21;
            this.buttonmüslist.Text = "Müşteri Listesi";
            this.buttonmüslist.UseVisualStyleBackColor = true;
            this.buttonmüslist.Click += new System.EventHandler(this.buttonmüslist_Click);
            // 
            // buttonmüskayıt
            // 
            this.buttonmüskayıt.Location = new System.Drawing.Point(30, 16);
            this.buttonmüskayıt.Name = "buttonmüskayıt";
            this.buttonmüskayıt.Size = new System.Drawing.Size(150, 45);
            this.buttonmüskayıt.TabIndex = 20;
            this.buttonmüskayıt.Text = "Müşteri Kaydı Oluşturma";
            this.buttonmüskayıt.UseVisualStyleBackColor = true;
            this.buttonmüskayıt.Click += new System.EventHandler(this.buttonmüskayıt_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(863, 532);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Genel Toplam";
            // 
            // groupBoxürün
            // 
            this.groupBoxürün.Controls.Add(this.texttoplam);
            this.groupBoxürün.Controls.Add(this.textmiktar);
            this.groupBoxürün.Controls.Add(this.textsatısfiyat);
            this.groupBoxürün.Controls.Add(this.textürünadı);
            this.groupBoxürün.Controls.Add(this.textbarkod);
            this.groupBoxürün.Controls.Add(this.label9);
            this.groupBoxürün.Controls.Add(this.label8);
            this.groupBoxürün.Controls.Add(this.label7);
            this.groupBoxürün.Controls.Add(this.label6);
            this.groupBoxürün.Controls.Add(this.label5);
            this.groupBoxürün.Location = new System.Drawing.Point(22, 296);
            this.groupBoxürün.Name = "groupBoxürün";
            this.groupBoxürün.Size = new System.Drawing.Size(350, 165);
            this.groupBoxürün.TabIndex = 25;
            this.groupBoxürün.TabStop = false;
            // 
            // groupBoxmüşteri
            // 
            this.groupBoxmüşteri.Controls.Add(this.textmail);
            this.groupBoxmüşteri.Controls.Add(this.texttelefon);
            this.groupBoxmüşteri.Controls.Add(this.textsoyad);
            this.groupBoxmüşteri.Controls.Add(this.textad);
            this.groupBoxmüşteri.Controls.Add(this.label4);
            this.groupBoxmüşteri.Controls.Add(this.label3);
            this.groupBoxmüşteri.Controls.Add(this.label2);
            this.groupBoxmüşteri.Controls.Add(this.label1);
            this.groupBoxmüşteri.Location = new System.Drawing.Point(27, 141);
            this.groupBoxmüşteri.Name = "groupBoxmüşteri";
            this.groupBoxmüşteri.Size = new System.Drawing.Size(344, 142);
            this.groupBoxmüşteri.TabIndex = 26;
            this.groupBoxmüşteri.TabStop = false;
            // 
            // labelgenel
            // 
            this.labelgenel.AutoSize = true;
            this.labelgenel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelgenel.Location = new System.Drawing.Point(1039, 532);
            this.labelgenel.Name = "labelgenel";
            this.labelgenel.Size = new System.Drawing.Size(0, 20);
            this.labelgenel.TabIndex = 27;
            this.labelgenel.Click += new System.EventHandler(this.label11_Click);
            // 
            // Satıs
            // 
            this.AcceptButton = this.buttonekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1212, 629);
            this.Controls.Add(this.labelgenel);
            this.Controls.Add(this.groupBoxmüşteri);
            this.Controls.Add(this.groupBoxürün);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonsatısyap);
            this.Controls.Add(this.buttonsatısiptal);
            this.Controls.Add(this.buttonsil);
            this.Controls.Add(this.buttonekle);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.Name = "Satıs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBoxürün.ResumeLayout(false);
            this.groupBoxürün.PerformLayout();
            this.groupBoxmüşteri.ResumeLayout(false);
            this.groupBoxmüşteri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textad;
        private System.Windows.Forms.TextBox textsoyad;
        private System.Windows.Forms.TextBox texttelefon;
        private System.Windows.Forms.TextBox textmail;
        private System.Windows.Forms.TextBox textbarkod;
        private System.Windows.Forms.TextBox textürünadı;
        private System.Windows.Forms.TextBox textsatısfiyat;
        private System.Windows.Forms.TextBox textmiktar;
        private System.Windows.Forms.TextBox texttoplam;
        private System.Windows.Forms.Button buttonekle;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttonsatısiptal;
        private System.Windows.Forms.Button buttonsatısyap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonsatıslist;
        private System.Windows.Forms.Button buttonürünlist;
        private System.Windows.Forms.Button buttonürünkayıt;
        private System.Windows.Forms.Button buttonmüslist;
        private System.Windows.Forms.Button buttonmüskayıt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBoxürün;
        private System.Windows.Forms.GroupBox groupBoxmüşteri;
        private System.Windows.Forms.Label labelgenel;
    }
}


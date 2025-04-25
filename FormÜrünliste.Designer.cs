namespace Stok_takip
{
    partial class FormÜrünliste
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.güncellemebutonu = new System.Windows.Forms.Button();
            this.kayıtsilme = new System.Windows.Forms.Button();
            this.txtarama = new System.Windows.Forms.TextBox();
            this.ürünadıarama = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxyer = new System.Windows.Forms.TextBox();
            this.textBoxstok = new System.Windows.Forms.TextBox();
            this.textBoxsatıs = new System.Windows.Forms.TextBox();
            this.textBoxalıs = new System.Windows.Forms.TextBox();
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonktgrekle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxkategori = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(494, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(764, 532);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // güncellemebutonu
            // 
            this.güncellemebutonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.güncellemebutonu.Location = new System.Drawing.Point(261, 426);
            this.güncellemebutonu.Name = "güncellemebutonu";
            this.güncellemebutonu.Size = new System.Drawing.Size(169, 51);
            this.güncellemebutonu.TabIndex = 16;
            this.güncellemebutonu.Text = "Ürün Kaydı Güncelleme";
            this.güncellemebutonu.UseVisualStyleBackColor = true;
            this.güncellemebutonu.Click += new System.EventHandler(this.güncellemebutonu_Click);
            // 
            // kayıtsilme
            // 
            this.kayıtsilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtsilme.Location = new System.Drawing.Point(261, 501);
            this.kayıtsilme.Name = "kayıtsilme";
            this.kayıtsilme.Size = new System.Drawing.Size(169, 51);
            this.kayıtsilme.TabIndex = 27;
            this.kayıtsilme.Text = "Kayıt Sil";
            this.kayıtsilme.UseVisualStyleBackColor = true;
            this.kayıtsilme.Click += new System.EventHandler(this.kayıtsilme_Click);
            // 
            // txtarama
            // 
            this.txtarama.Location = new System.Drawing.Point(239, 48);
            this.txtarama.Name = "txtarama";
            this.txtarama.Size = new System.Drawing.Size(158, 22);
            this.txtarama.TabIndex = 28;
            this.txtarama.TextChanged += new System.EventHandler(this.txtarama_TextChanged);
            // 
            // ürünadıarama
            // 
            this.ürünadıarama.AutoSize = true;
            this.ürünadıarama.BackColor = System.Drawing.Color.FloralWhite;
            this.ürünadıarama.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.ürünadıarama.Location = new System.Drawing.Point(95, 50);
            this.ürünadıarama.Name = "ürünadıarama";
            this.ürünadıarama.Size = new System.Drawing.Size(105, 20);
            this.ürünadıarama.TabIndex = 29;
            this.ürünadıarama.Text = "Ürün Adı Ara";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FloralWhite;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label8.Location = new System.Drawing.Point(42, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Kategori";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FloralWhite;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label7.Location = new System.Drawing.Point(42, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Alış Fiyatı";
            // 
            // textBoxyer
            // 
            this.textBoxyer.Location = new System.Drawing.Point(273, 318);
            this.textBoxyer.Name = "textBoxyer";
            this.textBoxyer.Size = new System.Drawing.Size(187, 22);
            this.textBoxyer.TabIndex = 46;
            // 
            // textBoxstok
            // 
            this.textBoxstok.Location = new System.Drawing.Point(273, 283);
            this.textBoxstok.Name = "textBoxstok";
            this.textBoxstok.Size = new System.Drawing.Size(187, 22);
            this.textBoxstok.TabIndex = 45;
            // 
            // textBoxsatıs
            // 
            this.textBoxsatıs.Location = new System.Drawing.Point(273, 248);
            this.textBoxsatıs.Name = "textBoxsatıs";
            this.textBoxsatıs.Size = new System.Drawing.Size(187, 22);
            this.textBoxsatıs.TabIndex = 44;
            // 
            // textBoxalıs
            // 
            this.textBoxalıs.Location = new System.Drawing.Point(273, 213);
            this.textBoxalıs.Name = "textBoxalıs";
            this.textBoxalıs.Size = new System.Drawing.Size(187, 22);
            this.textBoxalıs.TabIndex = 43;
            // 
            // textBoxad
            // 
            this.textBoxad.Location = new System.Drawing.Point(273, 178);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(187, 22);
            this.textBoxad.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FloralWhite;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label6.Location = new System.Drawing.Point(42, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Son Kullanma Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FloralWhite;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label5.Location = new System.Drawing.Point(42, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Üretim Yeri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FloralWhite;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label4.Location = new System.Drawing.Point(42, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Stok Miktarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FloralWhite;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label3.Location = new System.Drawing.Point(42, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Satış Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FloralWhite;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label2.Location = new System.Drawing.Point(42, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Ürün Adı";
            // 
            // textBoxno
            // 
            this.textBoxno.Location = new System.Drawing.Point(273, 106);
            this.textBoxno.Name = "textBoxno";
            this.textBoxno.Size = new System.Drawing.Size(187, 22);
            this.textBoxno.TabIndex = 36;
            this.textBoxno.TextChanged += new System.EventHandler(this.textBoxno_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label1.Location = new System.Drawing.Point(42, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Barkod Numarası";
            // 
            // buttonktgrekle
            // 
            this.buttonktgrekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonktgrekle.Location = new System.Drawing.Point(46, 426);
            this.buttonktgrekle.Name = "buttonktgrekle";
            this.buttonktgrekle.Size = new System.Drawing.Size(169, 51);
            this.buttonktgrekle.TabIndex = 53;
            this.buttonktgrekle.Text = "Kategori Ekleme";
            this.buttonktgrekle.UseVisualStyleBackColor = true;
            this.buttonktgrekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(273, 355);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 22);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // comboBoxkategori
            // 
            this.comboBoxkategori.FormattingEnabled = true;
            this.comboBoxkategori.Location = new System.Drawing.Point(273, 141);
            this.comboBoxkategori.Name = "comboBoxkategori";
            this.comboBoxkategori.Size = new System.Drawing.Size(187, 24);
            this.comboBoxkategori.TabIndex = 50;
            this.comboBoxkategori.SelectedIndexChanged += new System.EventHandler(this.comboBoxkategori_SelectedIndexChanged);
            // 
            // FormÜrünliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1304, 649);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonktgrekle);
            this.Controls.Add(this.comboBoxkategori);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxyer);
            this.Controls.Add(this.textBoxstok);
            this.Controls.Add(this.textBoxsatıs);
            this.Controls.Add(this.textBoxalıs);
            this.Controls.Add(this.textBoxad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ürünadıarama);
            this.Controls.Add(this.txtarama);
            this.Controls.Add(this.kayıtsilme);
            this.Controls.Add(this.güncellemebutonu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormÜrünliste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.FormÜrünliste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button güncellemebutonu;
        private System.Windows.Forms.Button kayıtsilme;
        private System.Windows.Forms.TextBox txtarama;
        private System.Windows.Forms.Label ürünadıarama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxyer;
        private System.Windows.Forms.TextBox textBoxstok;
        private System.Windows.Forms.TextBox textBoxsatıs;
        private System.Windows.Forms.TextBox textBoxalıs;
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonktgrekle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxkategori;
    }
}
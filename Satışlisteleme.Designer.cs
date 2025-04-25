namespace Stok_takip
{
    partial class Satışlisteleme
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
            this.buttonsil = new System.Windows.Forms.Button();
            this.buttonseçsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(994, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonsil
            // 
            this.buttonsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonsil.Location = new System.Drawing.Point(572, 448);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(288, 50);
            this.buttonsil.TabIndex = 25;
            this.buttonsil.Text = "Tüm Satış Kayıtlarını Sil";
            this.buttonsil.UseVisualStyleBackColor = true;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // buttonseçsil
            // 
            this.buttonseçsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonseçsil.Location = new System.Drawing.Point(213, 448);
            this.buttonseçsil.Name = "buttonseçsil";
            this.buttonseçsil.Size = new System.Drawing.Size(288, 50);
            this.buttonseçsil.TabIndex = 26;
            this.buttonseçsil.Text = "Seçili Kaydı Sil";
            this.buttonseçsil.UseVisualStyleBackColor = true;
            this.buttonseçsil.Click += new System.EventHandler(this.buttonseçsil_Click);
            // 
            // Satışlisteleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1083, 510);
            this.Controls.Add(this.buttonseçsil);
            this.Controls.Add(this.buttonsil);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Satışlisteleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Listelesi";
            this.Load += new System.EventHandler(this.Satışlisteleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttonseçsil;
    }
}
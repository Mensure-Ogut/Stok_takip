using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_takip
{
    public partial class Müşteri_Listesi : Form
    {
        public Müşteri_Listesi()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=LAPTOP-G8T50B0C;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void Müşteri_Listesi_Load(object sender, EventArgs e)
        {
            Müşteri_Kaydı_Göster();
        }

        private void Müşteri_Kaydı_Göster()//Müşteri bilgilerini veritabanından gösterir
        {
            baglantı.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter("select *from Müşteri", baglantı);
            adaptor.Fill(daset, "Müşteri");
            dataGridView1.DataSource = daset.Tables["Müşteri"];
            baglantı.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();//müşteri ad bilgisini gösterir
            textBox2.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();//müşteri soyad bilgisini gösterir
            textBox3.Text = dataGridView1.CurrentRow.Cells["Numara"].Value.ToString();//müşteri numara bilgisini gösterir
            textBox4.Text = dataGridView1.CurrentRow.Cells["Mail"].Value.ToString();//müşteri mail bilgisini gösterir
            textBox5.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();//müşteri adres bilgisini gösterir

        }

        private void buttongüncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update Müşteri set Soyad=@Soyad,Numara=@Numara,Mail=@Mail,Adres=@Adres where Ad=@Ad", baglantı);//müşteri bilgilerinin ada göre güncellenmesini sağlar
            komut.Parameters.AddWithValue("@Ad", textBox1.Text);
            komut.Parameters.AddWithValue("@Soyad", textBox2.Text);//müşteri soyad bilgisini günceller
            komut.Parameters.AddWithValue("@Numara", textBox3.Text);//müşteri numara bilgisini günceller
            komut.Parameters.AddWithValue("@Mail", textBox4.Text);//müşteri mail bilgisini günceller
            komut.Parameters.AddWithValue("@Adres", textBox5.Text);//müşteri adres bilgisini günceller
            komut.ExecuteNonQuery();
            baglantı.Close();
            daset.Tables["Müşteri"].Clear();
            Müşteri_Kaydı_Göster();
            MessageBox.Show("Müşteri kaydı başarıyla güncellendi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void buttonsilme_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from Müşteri where Ad='" + dataGridView1.CurrentRow.Cells["Ad"].Value.ToString() + "'", baglantı);//ada göre müşteri kaydı siler
            komut.ExecuteNonQuery();
            baglantı.Close();
            daset.Tables["Müşteri"].Clear();
            Müşteri_Kaydı_Göster();
            MessageBox.Show("Kayıt başarı ile silindi");
        }

        private void txtarama_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglantı.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter("select *from Müşteri where Ad like '%" + txtarama.Text + "%'", baglantı);//ada göre müşteri araması yapar
            adaptor.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.Close();
        }
    }
}

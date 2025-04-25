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
    public partial class FormÜrünliste : Form
    {
        public FormÜrünliste()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=LAPTOP-G8T50B0C;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void FormÜrünliste_Load(object sender, EventArgs e)
        {
            Ürün_kayıt_göster();
            Kategorigetir();
        }

        private void Ürün_kayıt_göster()
        {
            baglantı.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter("select *from ürün_listesi", baglantı);//ürünlerin listelendiği tabloyu gösterir
            adaptor.Fill(daset,"ürün_listesi");
            dataGridView1.DataSource = daset.Tables["ürün_listesi"];
            baglantı.Close();
        }
        private void Kategorigetir()
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from kategori", baglantı);//kategorileri gösterir
            baglantı.Close();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//çift tıklandığında ürün bilgilerinin textboxlara gelmesini sağlar
        {
            textBoxno.Text = dataGridView1.CurrentRow.Cells["Barkod_Numarası"].Value.ToString();
            comboBoxkategori.Text = dataGridView1.CurrentRow.Cells["Kategori"].Value.ToString();
            textBoxad.Text = dataGridView1.CurrentRow.Cells["Ürün_Adı"].Value.ToString();
            textBoxalıs.Text = dataGridView1.CurrentRow.Cells["Alış_Fiyatı"].Value.ToString();
            textBoxsatıs.Text = dataGridView1.CurrentRow.Cells["Satış_Fiyatı"].Value.ToString();
            textBoxstok.Text = dataGridView1.CurrentRow.Cells["Stok_Miktarı"].Value.ToString();
            textBoxyer.Text = dataGridView1.CurrentRow.Cells["Üretim_Yeri"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["Son_Kullanma_Tarihi"].Value.ToString();
        }

        private void güncellemebutonu_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("update ürün_listesi set Alış_Fiyatı=@Alış_Fiyatı,Satış_Fiyatı=@Satış_Fiyatı,Stok_Miktarı=@Stok_Miktarı, Üretim_Yeri=@Üretim_Yeri, Son_Kullanma_Tarihi=@Son_Kullanma_Tarihi where Barkod_Numarası=@Barkod_Numarası", baglantı);//ürün bilgilerini barkod numarasına göre günceller
            komut.Parameters.AddWithValue("@Barkod_Numarası", textBoxno.Text);
            komut.Parameters.AddWithValue("@Alış_Fiyatı", double.Parse(textBoxalıs.Text));
            komut.Parameters.AddWithValue("@Satış_Fiyatı", double.Parse(textBoxsatıs.Text));
            komut.Parameters.AddWithValue("@Stok_Miktarı", int.Parse(textBoxstok.Text));
            komut.Parameters.AddWithValue("@Üretim_Yeri", textBoxyer.Text);
            komut.Parameters.AddWithValue("@Son_Kullanma_Tarihi", dateTimePicker1.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            daset.Tables["ürün_listesi"].Clear();
            Ürün_kayıt_göster();
            MessageBox.Show("Ürün kaydı başarıyla güncellendi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void kayıtsilme_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from ürün_listesi where Barkod_Numarası='" + dataGridView1.CurrentRow.Cells["Barkod_Numarası"].Value.ToString() +"'",baglantı);//barkod numarasına göre ürün kaydının silinmesini sağlar
            komut.ExecuteNonQuery();
            baglantı.Close();
            daset.Tables["ürün_listesi"].Clear();
            Ürün_kayıt_göster();
            MessageBox.Show("Kayıt başarı ile silindi");
        }

        private void txtarama_TextChanged(object sender, EventArgs e)//ürün adına göre arama yapar
        {
            DataTable tablo = new DataTable();
            baglantı.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter("select *from ürün_listesi where Ürün_Adı like '%" + txtarama.Text + "%'", baglantı);
            adaptor.Fill(tablo);
            dataGridView1.DataSource= tablo;
            baglantı.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            kategori.ShowDialog();
        }

        private void comboBoxkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            SqlCommand komut = new SqlCommand("select *from kategori", baglantı);//kategorileri gösterir
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBoxkategori.Items.Add(read["Kategori"].ToString());
            }
            read.Close();
            baglantı.Close();
        }

        private void textBoxno_TextChanged(object sender, EventArgs e)
        {
            if (textBoxno.Text == "")
            {
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                    if (item is ComboBox)
                    {
                        item.Text = "";
                    }
                    if (item is DateTimePicker)
                    {
                        item.Text = "";
                    }
                }
            }
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from ürün_listesi where Barkod_Numarası like '" + textBoxno.Text + "'", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBoxkategori.Text = read["Kategori"].ToString();
                textBoxad.Text = read["Ürün_Adı"].ToString();
                textBoxalıs.Text = read["Alış_Fiyatı"].ToString();
                textBoxsatıs.Text = read["Satış_Fiyatı"].ToString();
                textBoxstok.Text = read["Stok_Miktarı"].ToString();
                textBoxyer.Text = read["Üretim_Yeri"].ToString();
                dateTimePicker1.Text = read["Son_Kullanma_Tarihi"].ToString();
            }
            read.Close();
            baglantı.Close();
            
        }
    }
}

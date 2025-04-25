using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_takip
{
    public partial class Ürüngiriş : Form
    {
        public Ürüngiriş()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=LAPTOP-G8T50B0C;Initial Catalog=Stok_Takip;Integrated Security=True");
        bool durum;
        private void barkodkontrolü()
        {
            durum = true;
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from ürün_listesi", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBoxno.Text == read["Barkod_Numarası"].ToString())
                {
                    durum = false;
                }
            }
            baglantı.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            barkodkontrolü();
            if (durum == true)
            {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into ürün_listesi(Barkod_Numarası,Kategori,Ürün_Adı,Alış_Fiyatı,Satış_Fiyatı,Stok_Miktarı,Üretim_Yeri,Son_Kullanma_Tarihi) values(@Barkod_Numarası,@Kategori,@Ürün_Adı,@Alış_Fiyatı,@Satış_Fiyatı,@Stok_Miktarı,@Üretim_Yeri,@Son_Kullanma_Tarihi)", baglantı);
            komut.Parameters.AddWithValue("@Barkod_Numarası", int.Parse(textBoxno.Text));//ürünün barkod bilgisinin girilmesi
            komut.Parameters.AddWithValue("@Kategori", comboBoxkategori.Text);//ürünün kategori bilgisinin girilmesi
            komut.Parameters.AddWithValue("@Ürün_Adı", textBoxad.Text);//ürünün ad bilgisinin girilmesi
            komut.Parameters.AddWithValue("@Alış_Fiyatı", double.Parse(textBoxalıs.Text));//ürünün alış fiyat bilgisinin girilmesi
            komut.Parameters.AddWithValue("@Satış_Fiyatı", double.Parse(textBoxsatıs.Text));//ürünün satış fiyat bilgisinin girilmesi
            komut.Parameters.AddWithValue("@Stok_Miktarı", int.Parse(textBoxstok.Text));//ürünün stok bilgisinin girilmesi
            komut.Parameters.AddWithValue("@Üretim_Yeri", textBoxyer.Text);//ürünün üretildiği yer bilgisinin girilmesi
            komut.Parameters.AddWithValue("@Son_Kullanma_Tarihi", dateTimePicker1.Text);//ürünün son kullanma tarihi bilgisinin girilmesi
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Ürün kaydı başarıyla oluşturuldu");
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                    if (item is ComboBox)
                    {
                        item.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Bu barkod numarası bulunmaktadır!", "Uyarı");//aynı barkod daha önce girildiyse oluşacak uyarı
                textBoxno.Text = "";
            }
            
            
        }

        private void Ürüngiriş_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }
        private void kategorigetir()
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from kategori", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBoxkategori.Items.Add(read["kategori"].ToString());
            }
            baglantı.Close();

        }
        private void comboBoxkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from kategori", baglantı);
            SqlDataReader read = komut .ExecuteReader();
            while (read.Read())
            {
                comboBoxkategori.Items.Add(read["kategori"].ToString() );
            }
            baglantı.Close();
        }
    }
}

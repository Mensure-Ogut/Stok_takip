using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace Stok_takip
{
    public partial class Müşterikayıt : Form
    {
        public Müşterikayıt()
        {
            InitializeComponent();
        }
         SqlConnection baglantı = new SqlConnection("Data Source=LAPTOP-G8T50B0C;Initial Catalog=Stok_Takip;Integrated Security=True");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Müşterikayıt_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Müşteri(Ad,Soyad,Numara,Mail,Adres) values(@Ad,@Soyad,@Numara,@Mail,@Adres)", baglantı);
            komut.Parameters.AddWithValue("@Ad", textBox1.Text);//müşteri ad bilgisini "Müşteri" adlı tabloya atar
            komut.Parameters.AddWithValue("@Soyad", textBox2.Text);//müşteri soyad bilgisini "Müşteri" adlı tabloya atar
            komut.Parameters.AddWithValue("@Numara", textBox3.Text);//müşteri numara bilgisini "Müşteri" adlı tabloya atar
            komut.Parameters.AddWithValue("@Mail", textBox4.Text);//müşteri mail bilgisini "Müşteri" adlı tabloya atar
            komut.Parameters.AddWithValue("@Adres", textBox5.Text);//müşteri adres bilgisini "Müşteri" adlı tabloya atar
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Müşteri kaydı başarıyla oluşturuldu");
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}

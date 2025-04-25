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
namespace Stok_takip
{
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=LAPTOP-G8T50B0C;Initial Catalog=Stok_Takip;Integrated Security=True");

        private void Kategori_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into kategori(Kategori) values('" + textBox1.Text + "')", baglantı);//kategorilerin eklenmesi
            komut.ExecuteNonQuery();
            baglantı.Close();
            textBox1.Text = "";
            MessageBox.Show("Kategori başarı ile eklendi");
        }
    }
}

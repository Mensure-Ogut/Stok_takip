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
    public partial class Satışlisteleme : Form
    {
        public Satışlisteleme()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=LAPTOP-G8T50B0C;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void satışlistesi()//kayıtları satıştan çekme
        {
            baglantı.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter("select *from Satış ", baglantı);
            adaptor.Fill(daset, "Satış");
            dataGridView1.DataSource = daset.Tables["Satış"];
            baglantı.Close();
        }
        private void Satışlisteleme_Load(object sender, EventArgs e)
        {
            satışlistesi();
        }

        private void buttonsil_Click(object sender, EventArgs e)//tüm kayıtları temizleme işlemi
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from Satış", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            daset.Tables["Satış"].Clear();
            MessageBox.Show("Satış kayıtları temizlendi");//silindiğine dair alınan mesaj 
        }

        private void buttonseçsil_Click(object sender, EventArgs e)//belirli bir ürünle ilgili kayıtları silme
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from Satış where Barkod_Numarası='" + dataGridView1.CurrentRow.Cells["Barkod_Numarası"].Value.ToString() + "'", baglantı);//barkod numrasına göre silme işlemini gerçekleştirme
            komut.ExecuteNonQuery();
            baglantı.Close();
            daset.Tables["Satış"].Clear();
            MessageBox.Show("Satış kaydı silindi");//silindiğine dair alınan mesaj 
        }
    }
}

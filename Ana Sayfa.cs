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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Stok_takip
{
    public partial class Satıs : Form
    {
        public Satıs()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=LAPTOP-G8T50B0C;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void sepetlistesi()
        {
            baglantı.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter("select *from Sepet ", baglantı);
            adaptor.Fill(daset, "Sepet");
            dataGridView1.DataSource = daset.Tables["Sepet"];//sepete eklenen ürünlerin bilgilerini gösterir
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            baglantı.Close();
        }
        private void hesap()
        {
            try
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("select sum(Toplam_Fiyat) from Sepet",baglantı);//toplam fiyat hesaplaması yapılır
                labelgenel.Text = komut.ExecuteScalar() + "TL";
                baglantı.Close();
            }
            catch (Exception)
            {
                ;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sepetlistesi();
        }

        private void buttonmüskayıt_Click(object sender, EventArgs e)
        {
            Müşterikayıt ekle = new Müşterikayıt();//müşteri kayıt ekranını açar
            ekle.ShowDialog();
        }

        private void buttonürünkayıt_Click(object sender, EventArgs e)
        {
            Ürüngiriş ekle = new Ürüngiriş();//ürün kayıt ekranını açar
            ekle.ShowDialog();
        }

        private void buttonürünlist_Click(object sender, EventArgs e)
        {
            FormÜrünliste listele = new FormÜrünliste();//ürün listeleme ekranını açar
            listele.ShowDialog();
        }

        private void buttonmüslist_Click(object sender, EventArgs e)
        {
            Müşteri_Listesi listele = new Müşteri_Listesi();//müşteri listeleme ekranını açar
            listele.ShowDialog();
        }

        private void textad_TextChanged(object sender, EventArgs e)
        {

        }

        private void texttelefon_TextChanged(object sender, EventArgs e)
        {
            if (texttelefon.Text == "")//telefon numarası girildiğinde müşterinin bilgilerini gösterir
            {
                textad.Text = "";
                textsoyad.Text = "";
                textmail.Text = "";

            }
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from Müşteri where Numara like '"+texttelefon.Text+"'",baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textad.Text = read["Ad"].ToString();
                textsoyad.Text = read["Soyad"].ToString();
                textmail.Text = read["Mail"].ToString();

            }
            baglantı.Close();
        }

        private void textbarkod_TextChanged(object sender, EventArgs e)
        {
            Temizleme();
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from ürün_listesi where Barkod_Numarası like '" + textbarkod.Text + "'", baglantı);//ürün barkod numarası girildiğinde ürünün diğer bilgilerini gösterir
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                textürünadı.Text = read["Ürün_Adı"].ToString();
                textsatısfiyat.Text = read["Satış_Fiyatı"].ToString();
            }
            baglantı.Close();
        }

        private void Temizleme()
        {
            if (textbarkod.Text == "")//ürünlerin olduğu grubu temizler 
            {
                foreach (Control item in groupBoxürün.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != textmiktar)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        bool durum;
        private void barkodkontrol()//barkod kontrolünü sağlar
        {
            durum = true;
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from Sepet", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textbarkod.Text == read["Barkod_Numarası"].ToString())
                {
                    durum = false;
                }
            }
            read.Close();
            
        }
        private void buttonekle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum == true)
            {
                SqlCommand komut = new SqlCommand("insert into Sepet(Ad,Soyad,Numara,Mail,Barkod_Numarası,Ürün_Adı,Satış_Fiyatı,Miktar,Toplam_Fiyat,Tarih) values(@Ad,@Soyad,@Numara,@Mail,@Barkod_Numarası,@Ürün_Adı,@Satış_Fiyatı,@Miktar,@Toplam_Fiyat,@Tarih)", baglantı);
                komut.Parameters.AddWithValue("@Ad", textad.Text);//sepete müşterinin ad bilgisini atar
                komut.Parameters.AddWithValue("@Soyad", textsoyad.Text);//sepete müşterinin soyad bilgisini atar
                komut.Parameters.AddWithValue("@Numara", texttelefon.Text);//sepete müşterinin numara bilgisini atar
                komut.Parameters.AddWithValue("@Mail", textmail.Text);//sepete müşterinin mail bilgisini atar
                komut.Parameters.AddWithValue("@Barkod_Numarası", textbarkod.Text);//sepete ürünün barkod bilgisini atar
                komut.Parameters.AddWithValue("@Ürün_Adı", textürünadı.Text);//sepete ürünün ad bilgisini atar
                komut.Parameters.AddWithValue("@Satış_Fiyatı", double.Parse(textsatısfiyat.Text));//sepete ürünün fiyat bilgisini atar
                komut.Parameters.AddWithValue("@Miktar", int.Parse(textmiktar.Text));//sepete ürünün miktar bilgisini atar
                komut.Parameters.AddWithValue("@Toplam_Fiyat", double.Parse(texttoplam.Text));//sepete ürünlerin toplam fiyat bilgisini atar
                komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());//sepete alışverişin tarih bilgisini atar
                komut.ExecuteNonQuery();
                baglantı.Close();
            }
            else
            {
                SqlCommand komut1 = new SqlCommand("update Sepet set Miktar = Miktar +'"+int.Parse(textmiktar.Text)+ "'where Barkod_Numarası'" + textbarkod.Text + "'", baglantı);//barkod numarası aynı olan ürünler girdiğinde üzerine ekleme yapar
                komut1.ExecuteNonQuery(); 
                SqlCommand komut2 = new SqlCommand("update Sepet set Toplam_Fiyat = Miktar * Satış_Fiyatı where Barkod_Numarası'" + textbarkod.Text + "'", baglantı);//toplam fiyatı hesaplar
                komut2.ExecuteNonQuery();
                baglantı.Close();
            }
            textmiktar.Text = "";
            daset.Tables["Sepet"].Clear();
            sepetlistesi();
            hesap();
            foreach (Control item in groupBoxürün.Controls)
            {
                if (item is TextBox)
                {
                    if (item != textmiktar)
                    {
                        item.Text = "";
                    }
                }

            }
        }

        private void textmiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                texttoplam.Text = (int.Parse(textmiktar.Text) * double.Parse(textsatısfiyat.Text)).ToString();

            }
            catch(Exception)
            {
                ;
            }
        }

        private void textsatısfiyat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                texttoplam.Text = (int.Parse(textmiktar.Text) * double.Parse(textsatısfiyat.Text)).ToString();

            }
            catch (Exception)
            {
                ;
            }
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from Sepet where Barkod_Numarası='"+dataGridView1.CurrentRow.Cells["Barkod_Numarası"].Value.ToString()+"'", baglantı);//ürünleri barkod numarasına göre silme işlemi yapar
            komut.ExecuteNonQuery();
            baglantı.Close();
            daset.Tables["Sepet"].Clear();
            sepetlistesi(); 
            MessageBox.Show("Ürün sepetten başarı ile çıkarıldı");
            hesap();
        }

        private void buttonsatısiptal_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from Sepet", baglantı);//satış iptali durumunda tüm ürünlerin sepetten silinmesini sağlar
            komut.ExecuteNonQuery();
            baglantı.Close();
            daset.Tables["Sepet"].Clear();
            sepetlistesi();
            MessageBox.Show("Satış iptali gerçekleştirildi");
            hesap();
        }

        private void buttonsatıslist_Click(object sender, EventArgs e)
        {
            Satışlisteleme listele = new Satışlisteleme();//satışların listelendiği formu açar
            listele.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void buttonsatısyap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("insert into Satış(Ad,Soyad,Numara,Mail,Barkod_Numarası,Ürün_Adı,Satış_Fiyatı,Miktar,Toplam_Fiyat,Tarih) values(@Ad,@Soyad,@Numara,@Mail,@Barkod_Numarası,@Ürün_Adı,@Satış_Fiyatı,@Miktar,@Toplam_Fiyat,@Tarih)", baglantı);
                komut.Parameters.AddWithValue("@Ad", textad.Text);//satış tablosuna müşteri ad bilgisini atar
                komut.Parameters.AddWithValue("@Soyad", textsoyad.Text);//satış tablosuna müşteri soyad bilgisini atar
                komut.Parameters.AddWithValue("@Numara", texttelefon.Text);//satış tablosuna müşteri numara bilgisini atar
                komut.Parameters.AddWithValue("@Mail", textmail.Text);//satış tablosuna müşteri mail bilgisini atar
                komut.Parameters.AddWithValue("@Barkod_Numarası", dataGridView1.Rows[i].Cells["Barkod_Numarası"].Value.ToString());//satış tablosuna ürün barkod bilgisini atar
                komut.Parameters.AddWithValue("@Ürün_Adı", dataGridView1.Rows[i].Cells["Ürün_Adı"].Value.ToString());//satış tablosuna ürün ad bilgisini atar
                komut.Parameters.AddWithValue("@Satış_Fiyatı", double.Parse(dataGridView1.Rows[i].Cells["Satış_Fiyatı"].Value.ToString()));//satış tablosuna ürün fiyat bilgisini atar
                komut.Parameters.AddWithValue("@Miktar", int.Parse(dataGridView1.Rows[i].Cells["Miktar"].Value.ToString()));//satış tablosuna ürün miktar bilgisini atar
                komut.Parameters.AddWithValue("@Toplam_Fiyat", double.Parse(dataGridView1.Rows[i].Cells["Toplam_Fiyat"].Value.ToString()));//satış tablosuna ürünlerin toplam fiyat bilgisini atar
                komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("update ürün_listesi set Stok_Miktarı = Stok_Miktarı -'" + int.Parse(dataGridView1.Rows[i].Cells["Miktar"].Value.ToString()) + "' where Barkod_Numarası='" + dataGridView1.Rows[i].Cells["Barkod_Numarası"].Value.ToString() + "'", baglantı);//satışla birlikte ürünlerin stoktan azalmasını sağlar
                komut2.ExecuteNonQuery();
                baglantı.Close();
            }
            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("delete from Sepet", baglantı);
            komut3.ExecuteNonQuery();
            baglantı.Close();
            daset.Tables["Sepet"].Clear();
            sepetlistesi();
            hesap();
            MessageBox.Show("Ürün satışı başarı ile gerçekleştirildi");
        }
    }
}

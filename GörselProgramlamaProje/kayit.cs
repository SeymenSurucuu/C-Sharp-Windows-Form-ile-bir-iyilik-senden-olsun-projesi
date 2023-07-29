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

namespace gorselprogramlamaproje
{
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            giris git = new giris();
            git.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string ab = kullaniciaditext.Text;
            string ac = adsoyadtext.Text;
            string ad = sifretext.Text;
            string cinsiyet = "ad";
            bool varmi = false; // kullanici adi kontrolu yaptirilacak o yuzden var



            if (!(ab == string.Empty && ac == string.Empty && ad == string.Empty) && !(erkek.Checked && kadin.Checked) && erkek.Checked || kadin.Checked)
            {
                try
                {
                    if (erkek.Checked) { cinsiyet = "erkek"; } else if (kadin.Checked) { cinsiyet = "kadin"; }

                    if (varmi == false) // kullanici adi kontrolu yaptirilacak o yuzden var
                    {
                        if (connect.State == ConnectionState.Closed)
                        {
                            connect.Open();
                            string kayit = "insert into kullanicibilgileri (kullaniciadi,adsoyad,sifre,cinsiyet) values(@kullaniciad,@adsoy,@sif,@cins)";
                            SqlCommand komut = new SqlCommand(kayit, connect);
                            komut.Parameters.AddWithValue("@kullaniciad", kullaniciaditext.Text);
                            komut.Parameters.AddWithValue("@adsoy", adsoyadtext.Text);
                            komut.Parameters.AddWithValue("@sif", sifretext.Text);
                            komut.Parameters.AddWithValue("@cins", cinsiyet);
                            komut.ExecuteNonQuery();
                            connect.Close();
                            MessageBox.Show("Başarıyla Kayıt Oldunuz!");

                        }
                    }
                    else { MessageBox.Show("Lutfen Farkli Bir Kullanici Adi Tercih Ediniz."); }

                }
                catch (Exception hata) { MessageBox.Show("Hata! Sisteme kayıt olamadınız. Hata Kodu:  " + hata.Message); }

            }
            else
            {
                MessageBox.Show("Tüm Bilgileri Doldurunuz!");

            }
        }

        private void adsoyadtext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

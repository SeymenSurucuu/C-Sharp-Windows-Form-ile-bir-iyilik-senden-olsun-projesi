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
using static gorselprogramlamaproje.giris;

namespace gorselprogramlamaproje
{
    public partial class askidafatura : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public askidafatura()
        {
            InitializeComponent();
        }
        static string conString = ("Data Source=localhost\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
        private void askidafatura_Load(object sender, EventArgs e)
        {
            
            SqlConnection connect = new SqlConnection(conString);
            connect.Open();
            string getir = "select id, fatura from kullanicibilgileri where fatura is not null and fatura > 0"; 
            SqlCommand komut = new SqlCommand(getir, connect);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad  =   giris.veri.kullanici;
            string sifre = giris.veri.sifre;
            string odeme = odemetutartxt.Text;
            string faturaid = faturaidtxt.Text;
            try { 
            int faturaid2 = int.Parse(faturaid);
            
            con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select fatura From kullanicibilgileri where id =" + faturaid2;
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                string fatura = dr["fatura"].ToString();
                    int fatura2 = int.Parse(fatura);
                    int odeme2 = int.Parse(odeme);
                    if (giris.veri.bakiyesi>= odeme2 && !(odeme2 > fatura2)) {
                        
                     
                        
                        int a = giris.veri.bakiyesi - odeme2;
                        int bee = fatura2 - odeme2;
                        giris.veridegis2("bakiye", a);
                        giris.veri.bakiyesi = a;
                        // idyi string olarak çekiyormum video da bunu fark etmedim burada bu şekilde düzelttim.
                        if (faturaid2 == int.Parse(giris.veri.idsi)) { giris.veri.fatura = bee; }
                        giris.veridegis3("fatura", bee ,faturaid2);
                        MessageBox.Show("Değerli Yardımınız İçin Teşekkür ederiz!");
                        
                    } else { MessageBox.Show("Bakiyeniz Yetersiz Veya Çok Yüksek bir Tutar Ödemeye Çalışıyorsunuz!"); }
                    
             }
            else { MessageBox.Show("Fatura Bulunamadı"); }
            }
            catch (FormatException) { MessageBox.Show("Hatalı id girişi"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(conString);
                connect.Open();
                string getir = "select id, fatura from kullanicibilgileri where fatura is not null and fatura > 0";
                SqlCommand komut = new SqlCommand(getir, connect);
                SqlDataAdapter ad = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                connect.Close();
            }
            catch (Exception ex) { MessageBox.Show("Tabloya Erisim Saglanmadi: " + ex); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anamenu git = new anamenu();
            git.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void user1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

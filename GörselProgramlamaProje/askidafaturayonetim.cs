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

namespace gorselprogramlamaproje
{
    public partial class askidafaturayonetim : Form
    {
        public askidafaturayonetim()
        {
            InitializeComponent();
        }
        static string conString = ("Data Source=localhost\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");
        private Timer timer;
        private void askidafaturayonetim_Load(object sender, EventArgs e)
        {
            try { 
            SqlConnection connect = new SqlConnection(conString);
            connect.Open();
            string getir = "select id,kullaniciadi,adsoyad,fatura from kullanicibilgileri where fatura is not null and fatura > 0";
            SqlCommand komut = new SqlCommand(getir, connect);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
            }catch (Exception ex) { MessageBox.Show("Tabloya Erisim Saglanmadi: "+ ex); }
            timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += Timer_Tick;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                uyari2.Text = "Sadece Sayı Girişi Yapabilirsiniz!";
                timer.Start();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                uyari3.Text = "Sadece Sayı Girişi Yapabilirsiniz!";
                timer.Start();
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {    
            uyari2.Text = "";
            uyari3.Text = "";
            timer.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            
            try {
                int b = int.Parse(a);
                giris.veridegis6("fatura",0,b);
                MessageBox.Show("Fatura Silindi");
            } catch (Exception ab) { MessageBox.Show(" "+ab); }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Adminmenu adminmenu = new Adminmenu();  
            adminmenu.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(conString);
                connect.Open();
                string getir = "select id,kullaniciadi,adsoyad,fatura from kullanicibilgileri where fatura is not null and fatura > 0";
                SqlCommand komut = new SqlCommand(getir, connect);
                SqlDataAdapter ad = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                connect.Close();
            }
            catch (Exception ex) { MessageBox.Show("Tabloya Erisim Saglanmadi: " + ex); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string c = textBox2.Text;
            string a = textBox1.Text;
            try
            {
                int b = int.Parse(a);
                int ce = int.Parse(c);
                giris.veridegis6("fatura", ce, b);
                MessageBox.Show("Fatura Miktari Guncellendi!");
            }
            catch (Exception ab) { MessageBox.Show(" " + ab); }
        }
    }
}

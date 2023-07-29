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
    public partial class Adminduzenle : Form
    {
        public Adminduzenle()
        {
            InitializeComponent();
        }
        static string conString = ("Data Source=localhost\\SQLEXPRESS;Initial Catalog=proje;Integrated Security=True");

        private Timer timer;
        private void Adminduzenle_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection(conString);
                connect.Open();
                string getir = "select id,kullaniciadi,adminmi,adsoyad from kullanicibilgileri";
                SqlCommand komut = new SqlCommand(getir, connect);
                SqlDataAdapter ad = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                connect.Close();
            }
            catch (Exception ex) { MessageBox.Show("Tabloya Erisim Saglanmadi: " + ex); }

            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("User");
            timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += Timer_Tick;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = comboBox1.Text;
            string c = textBox1.Text;

            if (a.Equals("Admin")) { 
                
                int asa = int.Parse(c);
                giris.veridegis6("adminmi",1,asa); 
                MessageBox.Show(asa + " ID degerine sahip kullaniciya Admin yetkisi tanımlanmıştır!");

                try
                {
                    SqlConnection connect = new SqlConnection(conString);
                    connect.Open();
                    string getir = "select id,kullaniciadi,adminmi,adsoyad from kullanicibilgileri";
                    SqlCommand komut = new SqlCommand(getir, connect);
                    SqlDataAdapter ad = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dataGridView1.DataSource = dt;
                    connect.Close();
                }
                catch (Exception ex) { MessageBox.Show("Tabloya Erisim Saglanmadi: " + ex); }



            } else if (a.Equals("User")) { 
                int asa = int.Parse(c); 
                giris.veridegis6("adminmi", 0, asa); 
                MessageBox.Show(asa + " ID degerine sahip kullaniciya User yetkisi tanımlanmıştır!");



                try
                {
                    SqlConnection connect = new SqlConnection(conString);
                    connect.Open();
                    string getir = "select id,kullaniciadi,adminmi,adsoyad from kullanicibilgileri";
                    SqlCommand komut = new SqlCommand(getir, connect);
                    SqlDataAdapter ad = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dataGridView1.DataSource = dt;
                    connect.Close();
                }
                catch (Exception ex) { MessageBox.Show("Tabloya Erisim Saglanmadi: " + ex); }




            } else { MessageBox.Show("Lutfen Yetki Seciniz."); }
        
        
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

        private void button3_Click(object sender, EventArgs e)
        {
           Adminmenu adminmenu = new Adminmenu();
            adminmenu.Show();
            this.Hide();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            uyari2.Text = "";
            uyari3.Text = "";
            timer.Stop();
        }
}
}

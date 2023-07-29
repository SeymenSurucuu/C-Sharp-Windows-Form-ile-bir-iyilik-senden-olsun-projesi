using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselprogramlamaproje
{
    public partial class bagiskurumlariduzenle : Form
    {
        public bagiskurumlariduzenle()
        {
            InitializeComponent();
        }

        private Timer timer;
        private void bagiskurumlariduzenle_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 2000; 
            timer.Tick += Timer_Tick;

            label1.Text = giris.veri.bagiskurumu1;
            label2.Text = giris.veri.bagiskurumu2;
            label3.Text = giris.veri.bagiskurumu3;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = birincikurum.Text.Trim();
            string b = ikincikurum.Text.Trim();
            string c = ucuncukurum.Text.Trim();
            
            try {
                if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b) && !string.IsNullOrEmpty(c))
                {

                    giris.veridegis4("bagisk1", a);
                    giris.veridegis4("bagisk2", b);
                    giris.veridegis4("bagisk3", c);
                    MessageBox.Show("Tum Kurum Adlari Degistirildi! Eski Adı: "
                                                     + giris.veri.bagiskurumu1 + " Yeni Adı: " + a +
                        " Ikinci Kurum Eski Adi: " + giris.veri.bagiskurumu2 + " Yeni Adi: " + b +
                        " Ucuncu Kurum Eski Adi: " + giris.veri.bagiskurumu3 + " Yeni Adi: " + c);


                    giris.veri.bagiskurumu1 = a;
                    giris.veri.bagiskurumu2 = b;
                    giris.veri.bagiskurumu3 = c;

                    label1.Text = a;
                    label2.Text = b;
                    label3.Text = c;

                }
                else if (!string.IsNullOrEmpty(b) && !string.IsNullOrEmpty(c))
                {
                    giris.veridegis4("bagisk2", b);
                    giris.veridegis4("bagisk3", c);

                    MessageBox.Show("iki ve ucuncu kurum adlari Degistirildi! " +
                        " Ikinci Kurum Eski Adi: " + giris.veri.bagiskurumu2 + " Yeni Adi: " + b +
                        " Ucuncu Kurum Eski Adi: " + giris.veri.bagiskurumu3 + " Yeni Adi: " + c);

                    giris.veri.bagiskurumu2 = b;
                    giris.veri.bagiskurumu3 = c;

                    label2.Text = b;
                    label3.Text = c;

                }
                else if (!string.IsNullOrEmpty(c) && !string.IsNullOrEmpty(a))
                {
                    giris.veridegis4("bagisk3", c);
                    giris.veridegis4("bagisk1", a);

                    MessageBox.Show("birinci ve ucuncu kurum adlari Degistirildi! " +
                        " Birinci Kurum Eski Adi: " + giris.veri.bagiskurumu1 + " Yeni Adi: " + a +
                        " Ucuncu Kurum Eski Adi: " + giris.veri.bagiskurumu3 + " Yeni Adi: " + c);


                    giris.veri.bagiskurumu3 = c;
                    giris.veri.bagiskurumu1 = a;

                    label1.Text = a;
                    label3.Text = c;
                }
                else if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b))
                {
                    giris.veridegis4("bagisk1", a);
                    giris.veridegis4("bagisk2", b);

                    MessageBox.Show("birinci ve ikinci kurum adlari Degistirildi! " +
                " Birinci Kurum Eski Adi: " + giris.veri.bagiskurumu1 + " Yeni Adi: " + a +
                " ikinci Kurum Eski Adi: " + giris.veri.bagiskurumu2 + " Yeni Adi: " + b);

                    giris.veri.bagiskurumu1 = a;
                    giris.veri.bagiskurumu2 = b;

                    label1.Text = a;
                    label2.Text = b;
                }
                else if (!string.IsNullOrEmpty(a))
                {
                    giris.veridegis4("bagisk1", a);

                    MessageBox.Show("birinci kurumun adi degistirildi! Eski Adi: " + giris.veri.bagiskurumu1 + " Yeni Adi: " + a);

                    giris.veri.bagiskurumu1 = a;


                    label1.Text = a;

                }
                else if (!string.IsNullOrEmpty(b))
                {
                    giris.veridegis4("bagisk2", b);

                    MessageBox.Show("Ikinci kurumun adi degistirildi! Eski Adi: " + giris.veri.bagiskurumu2 + " Yeni Adi: " + b);


                    giris.veri.bagiskurumu2 = b;

                    label2.Text = b;
                }
                else if (!string.IsNullOrEmpty(c))
                {
                    giris.veridegis4("bagisk3", c);

                    MessageBox.Show("Ucuncu kurumun adi degistirildi! Eski Adi: " + giris.veri.bagiskurumu3 + " Yeni Adi: " + c);

                    giris.veri.bagiskurumu3 = c;

                    label3.Text = c;
                }
                else { MessageBox.Show("Gecersiz Islem!"); }



            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kurumgorunurlugu kurumgorunurlugu = new kurumgorunurlugu();
            kurumgorunurlugu.Show();
            this.Hide();
        }

        private void birincikurum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '/')
            {
                e.Handled = true;
                
                uyari1.Text = "Kurum Adlarında Sayı ve '/' Girisi Yasaktir!";
                timer.Start();
            }
            
        }
       

        private void ikincikurum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '/')
            {
                e.Handled = true;

                uyari2.Text = "Kurum Adlarında Sayı ve '/' Girisi Yasaktir!";
                timer.Start();
            }
        }
       

        private void ucuncukurum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '/')
            {
                e.Handled = true;

                uyari3.Text = "Kurum Adlarında Sayı ve '/' Girisi Yasaktir!";
                timer.Start();
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {

            uyari1.Text = "";
            uyari2.Text = "";
            uyari3.Text = "";
            timer.Stop();
        }

        private void birincikurum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

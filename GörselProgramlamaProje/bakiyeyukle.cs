using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselprogramlamaproje
{
    public partial class bakiyeyukle : Form
    {
        public bakiyeyukle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kad = kadtxt.Text;
            string sifre = msifretxt.Text;
            string b0 = bmiktartxt.Text;

            try
            {
                int b1 = int.Parse(b0);
                int b2 = giris.veri.bakiyesi;
                int son = b1 + b2;
                if (kad.Equals(giris.veri.kullanici) && sifre.Equals(giris.veri.sifre))
                {
                    giris.veridegis2("bakiye", son);
                    giris.veri.bakiyesi = son;
                    MessageBox.Show("Bakiye Yüklemeniz Gerçekleşmiştir. Yeni Bakiyeniz: " + son);
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bilgileriniz Yanlış!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen Bakiye'ye geçerli bir değer giriniz!");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            anamenu anamenu = new anamenu();
            anamenu.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
